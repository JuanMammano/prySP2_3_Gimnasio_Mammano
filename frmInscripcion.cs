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

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("Edad no valida");
                return;
            }
            if (meses < 1 && meses > 13)
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
            subTotal = (subTotal * porcDescuento) / 100;

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
            Console.WriteLine(mayorMenor);
            string formaPago = (rbtEfectivo.Checked) ? "Efectivo" : $"Tarjeta en {cboCuotas.SelectedIndex} ";
            decimal valorCuota = (rbtEfectivo.Checked) ? subTotal : (total / cboCuotas.SelectedIndex);
            Console.WriteLine($"Forma de pago: {formaPago}");
            Console.WriteLine($"Valor de cada cuota: {valorCuota}");

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
    }
}
