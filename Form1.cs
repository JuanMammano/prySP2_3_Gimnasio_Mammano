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
            int.Parse(txtEdad.Text);
            int.Parse(txtMeses.Text);

            string nombre = " ";
            int edad = 0;
            int meses = 0;
            meses = int.Parse(txtMeses.Text);
            decimal precioMensual = 0;
            decimal subTotal = 0;
            int porcDescuento = 0;
            int porcAjuste = 0;
            decimal total = 0;
            decimal valorCuota = 0;
            string turno = "";

            string plan = cboPlan.Text;
            switch (plan)
            {
                case "Musculación": precioMensual=MONTO_MUSCULACION;
                    break;
                case "Funcional": precioMensual = MONTO_FUNCIONAL;
                    break;
                case "Natación": precioMensual = MONTO_NATACION;
                    break;
                default:MessageBox.Show("Plan invalido");
                    break;
            }
            switch (cboTurno.SelectedIndex)
            {
                case 0: turno = "Mañana";
                    break;
                case 1: turno = "Tarde";
                    break;
                case 2: turno = "Noche";
                    break;
            }
            if (chkCasillero.Checked==true) precioMensual = precioMensual + MONTO_CASILLERO;
            subTotal = precioMensual * meses;

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("Edad no valida");
                return;
            }
            if (meses < 1 && meses>13)
            {
                MessageBox.Show("Ingrese un mes valido...Panchxsx");
                return;
            }


        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            validacionCaracteres();
        }

        private void txtMeses_TextChanged(object sender, EventArgs e)
        {
            validacionCaracteres();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validacionCaracteres();
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }

            //char.IsDigit(e.KeyChar);

        }
    }
}
