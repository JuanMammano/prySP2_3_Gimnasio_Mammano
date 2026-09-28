namespace prySP2_3_Gimnasio_Mammano
{
    public partial class frmInscripcion : Form
    {
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
    }
}
