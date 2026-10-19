namespace prySP2_3_Gimnasio_Mammano
{
    public partial class frmInscripcion : Form
    {
        const decimal MONTO_CASILLERO = 3000;
        const decimal MONTO_MUSCULACION = 15000;
        const decimal MONTO_NATACION = 22000;
        const decimal MONTO_FUNCIONAL = 18000;
        const int DESC_18 = 25;
        const int DESC_65MAS = 30;
        const int DESC_ESTUDIANTE = 15;
        const int PAGO_EFECTIVO = 10;
        const int RECA_3CUO = 10;
        const int RECA_6CUO = 20;
        const int EDAD_MINIMA = 16;
        int i = 1;
        string[] nombres = new string[10];
        public frmInscripcion()
        {
            InitializeComponent();
        }
        public void Limpieza()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = " ";
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;
            cboPlan.SelectedIndex = -1;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            cboTurno.SelectedIndex = -1;
            rbtEfectivo.Checked = false;
            rbtTarjeta.Checked = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();
        }
        public void validacionCaracteres()
        {
            if (txtNombre.Text != "" && txtEdad.Text != "" && txtMeses.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            Limpieza();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);
            meses = int.Parse(txtMeses.Text);
            decimal precioMensual = 0;
            decimal subTotal = 0;
            int porcDescuento = 0;
            int porcAjuste = 0;
            decimal total = 0;
            string turno = "";
            string plan = cboPlan.Text;
            int cuotas = 0;

            switch (plan)
            {
                case "Musculación":
                    precioMensual = MONTO_MUSCULACION;
                    break;
                case "Funcional":
                    precioMensual = MONTO_FUNCIONAL;
                    break;
                case "Natación":
                    precioMensual = MONTO_NATACION;
                    break;
                default:
                    MessageBox.Show("Plan invalido");
                    break;
            }

            switch (cboTurno.SelectedIndex)
            {
                case 0:
                    turno = "Mañana";
                    break;
                case 1:
                    turno = "Tarde";
                    break;
                case 2:
                    turno = "Noche";
                    break;
            }

            switch (cboCuotas.SelectedIndex)
            {
                case 0:
                    cuotas = 1;
                    break;
                case 1:
                    cuotas = 3;
                    break;
                case 2:
                    cuotas = 6;
                    break;
            }

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("Edad no valida");
                return;
            }
            if (meses < 1 && meses > 12)
            {
                MessageBox.Show("Ingrese un mes valido...Panchxsx");
                return;
            }

            if (chkCasillero.Checked == true) precioMensual = precioMensual + MONTO_CASILLERO;
            subTotal = precioMensual * meses;

            if (edad < 19)
            {
                porcDescuento = DESC_18;

            }
            else
            {
                if (edad > 64)
                {
                    porcDescuento = DESC_65MAS;
                }
                else
                {
                    if (chkEstudiante.Checked == true)
                    {
                        porcDescuento = DESC_ESTUDIANTE;
                    }
                    else
                    {
                        porcDescuento = 0;
                    }
                }
            }
            subTotal = subTotal - (subTotal * porcDescuento) / 100;

            if (rbtEfectivo.Checked == true)
            {
                total = subTotal - (subTotal * PAGO_EFECTIVO) / 100;
            }
            if (rbtTarjeta.Checked == true && cboCuotas.SelectedIndex == 1)
            {
                total = subTotal + (subTotal * RECA_3CUO) / 100;
            }
            else if (rbtTarjeta.Checked == true && cboCuotas.SelectedIndex == 2)
            {
                total = subTotal + (subTotal * RECA_6CUO) / 100;
            }

            string mayorMenor = (edad < 18) ? "Menor" : "Mayor";
            string formaPago = (rbtEfectivo.Checked) ? "Efectivo" : $"Tarjeta en {cuotas} pagos";
            decimal valorCuota = (rbtEfectivo.Checked) ? subTotal : (total / cuotas);
            string esEstudiante = (chkEstudiante.Checked) ? "SI" : "NO";


            SOCIO unSocio;
            unSocio.nombre = txtNombre.Text;
            unSocio.edad = int.Parse(txtEdad.Text);
            unSocio.esEstudiante = esEstudiante;
            unSocio.plan = cboPlan.Text;
            unSocio.turno = cboTurno.Text;
            unSocio.meses = int.Parse(txtMeses.Text);
            unSocio.formaPago = formaPago;
            unSocio.total = total;
            unSocio.valorCuota = valorCuota;

            string mensaje = "DATOS DEL SOCIO\n" +
                             "----------------------------------------\n" +
                             $"Nombre: {unSocio.nombre}\n" +
                             $"Edad: {unSocio.edad}\n" +
                             $"Es estudiante: {unSocio.esEstudiante}\n" +
                             $"Plan: {unSocio.plan}\n" +
                             $"Horario: {unSocio.turno}\n" +
                             $"Meses: {unSocio.meses}\n" +
                             $"Forma de pago: {unSocio.formaPago}\n" +
                             $"Total: {unSocio.valorCuota.ToString("C2")}\n";

            string mensaje2 = "DATOS DEL SOCIO\n" +
                  "----------------------------------------\n" +
                  $"Nombre: {unSocio.nombre}\n" +
                  $"Edad: {unSocio.edad}\n" +
                  $"Es estudiante: {unSocio.esEstudiante}\n" +
                  $"Plan: {unSocio.plan}\n" +
                  $"Horario: {unSocio.turno}\n" +
                  $"Meses: {unSocio.meses}\n" +
                  $"Forma de pago: {unSocio.formaPago}\n" +
                  $"Total: {unSocio.total.ToString("C2")}\n" +
                  $"Valor de cuota: {unSocio.valorCuota.ToString("C2")}";

            if (rbtEfectivo.Checked == true)
            {
                MessageBox.Show(mensaje, "Resultado del Socio");
            }
            else
            {
                MessageBox.Show(mensaje2, "Resultado del Socio");
            }
                        

            if (i < nombres.Length)
            {
                nombres[i] = nombre;
                i = i + 1;
            }

            if (i == nombres.Length)
            {
                MessageBox.Show("Hasta aca llegaste, campeon");
                btnCalcular.Enabled = false;
            }

            Limpieza();

        }



        public struct SOCIO
        {
            public string nombre;
            public int edad;
            public string esEstudiante;
            public string plan;
            public string turno;
            public int meses;
            public string formaPago;
            public decimal total;
            public decimal valorCuota;
        }




        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            cboPlan.Enabled = true;
        }

        private void txtMeses_TextChanged(object sender, EventArgs e)
        {
            validacionCaracteres();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validacionCaracteres();
            txtEdad.Enabled = true;
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }

        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked == true)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }
        }

        private void cboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMeses.Enabled = true;
        }

        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTurno.Enabled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] != null)
                {
                    lstConsultar.Items.Add(nombres[i]);
                    btnConsultar.Enabled = false;
                }                
            }
            
        }
        
        
    }
    
}
