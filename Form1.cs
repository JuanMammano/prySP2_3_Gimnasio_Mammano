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
        public frmInscripcion()
        {
            InitializeComponent();
        }
        public void Limpieza()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;
            cboPlan.SelectedIndex = 1;
            cboCuotas.SelectedIndex = 0;
            cboCuotas.Enabled = false;
            cboTurno.SelectedIndex = 1;
            rbtEfectivo.Checked = false;
            rbtTarjeta.Checked = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();
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
            string nombre = " ";
            int edad = 0;
            string meses = " ";
            decimal precioMensual = 0;
            decimal subTotal = 0;
            int porcDescuento = 0;
            int porcAjuste = 0;
            decimal total = 0;
            decimal valorCuota = 0;
        }
    }
}
