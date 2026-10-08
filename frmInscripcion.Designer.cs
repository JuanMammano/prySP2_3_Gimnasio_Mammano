namespace prySP2_3_Gimnasio_Mammano
{
    partial class frmInscripcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcion));
            lblNombre = new Label();
            lblEdad = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            lblCantMeses = new Label();
            txtMeses = new TextBox();
            lblCasillero = new Label();
            chkCasillero = new CheckBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            grbPago = new GroupBox();
            cboCuotas = new ComboBox();
            gpbDatosPersonales = new GroupBox();
            chkEstudiante = new CheckBox();
            lblEstudiante = new Label();
            lblPlan = new Label();
            cboPlan = new ComboBox();
            lblTurno = new Label();
            cboTurno = new ComboBox();
            grbPlan = new GroupBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            grbPago.SuspendLayout();
            gpbDatosPersonales.SuspendLayout();
            grbPlan.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            lblNombre.Location = new Point(14, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 18);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            lblEdad.Location = new Point(14, 57);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(48, 18);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(89, 27);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 24);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(89, 57);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(52, 24);
            txtEdad.TabIndex = 3;
            txtEdad.TextChanged += txtEdad_TextChanged;
            txtEdad.KeyPress += txtMeses_KeyPress;
            // 
            // lblCantMeses
            // 
            lblCantMeses.AutoSize = true;
            lblCantMeses.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            lblCantMeses.Location = new Point(6, 93);
            lblCantMeses.Name = "lblCantMeses";
            lblCantMeses.Size = new Size(149, 18);
            lblCantMeses.TabIndex = 4;
            lblCantMeses.Text = "Cantidad de Meses";
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(161, 92);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(70, 24);
            txtMeses.TabIndex = 5;
            txtMeses.TextChanged += txtMeses_TextChanged;
            txtMeses.KeyPress += txtMeses_KeyPress;
            // 
            // lblCasillero
            // 
            lblCasillero.AutoSize = true;
            lblCasillero.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            lblCasillero.Location = new Point(6, 128);
            lblCasillero.Name = "lblCasillero";
            lblCasillero.Size = new Size(188, 18);
            lblCasillero.TabIndex = 6;
            lblCasillero.Text = "Casillero ($ 3.000/mes)";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(210, 132);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(15, 14);
            chkCasillero.TabIndex = 7;
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            rbtEfectivo.Location = new Point(14, 29);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(88, 22);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            //rbtEfectivo.CheckedChanged += this.rbtEfectivo_CheckedChanged;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            rbtTarjeta.Location = new Point(102, 28);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(82, 22);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;
            // 
            // grbPago
            // 
            grbPago.Controls.Add(cboCuotas);
            grbPago.Controls.Add(rbtTarjeta);
            grbPago.Controls.Add(rbtEfectivo);
            grbPago.Font = new Font("Monotype Corsiva", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grbPago.Location = new Point(30, 383);
            grbPago.Name = "grbPago";
            grbPago.Size = new Size(317, 73);
            grbPago.TabIndex = 2;
            grbPago.TabStop = false;
            grbPago.Text = "Forma de pago";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.Enabled = false;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1 cuota ( Sin Recargo )", "3 cuotas (10% Recargo)", "6 cuotas (20% Recargo)" });
            cboCuotas.Location = new Point(183, 27);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(121, 25);
            cboCuotas.TabIndex = 2;
            // 
            // gpbDatosPersonales
            // 
            gpbDatosPersonales.Controls.Add(chkEstudiante);
            gpbDatosPersonales.Controls.Add(lblEstudiante);
            gpbDatosPersonales.Controls.Add(lblEdad);
            gpbDatosPersonales.Controls.Add(lblNombre);
            gpbDatosPersonales.Controls.Add(txtNombre);
            gpbDatosPersonales.Controls.Add(txtEdad);
            gpbDatosPersonales.Font = new Font("Monotype Corsiva", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gpbDatosPersonales.Location = new Point(30, 63);
            gpbDatosPersonales.Name = "gpbDatosPersonales";
            gpbDatosPersonales.Size = new Size(317, 120);
            gpbDatosPersonales.TabIndex = 0;
            gpbDatosPersonales.TabStop = false;
            gpbDatosPersonales.Text = "Datos Personales";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(117, 92);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(15, 14);
            chkEstudiante.TabIndex = 5;
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            lblEstudiante.Location = new Point(14, 88);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(98, 18);
            lblEstudiante.TabIndex = 4;
            lblEstudiante.Text = "Estudiante?";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            lblPlan.Location = new Point(6, 25);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(43, 18);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "Plan";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(68, 23);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(157, 25);
            cboPlan.TabIndex = 1;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Georgia", 11.25F, FontStyle.Bold);
            lblTurno.Location = new Point(6, 62);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(56, 18);
            lblTurno.TabIndex = 2;
            lblTurno.Text = "Turno";
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(68, 55);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(157, 25);
            cboTurno.TabIndex = 3;
            // 
            // grbPlan
            // 
            grbPlan.Controls.Add(lblCantMeses);
            grbPlan.Controls.Add(cboTurno);
            grbPlan.Controls.Add(txtMeses);
            grbPlan.Controls.Add(lblTurno);
            grbPlan.Controls.Add(lblCasillero);
            grbPlan.Controls.Add(cboPlan);
            grbPlan.Controls.Add(chkCasillero);
            grbPlan.Controls.Add(lblPlan);
            grbPlan.Font = new Font("Monotype Corsiva", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grbPlan.Location = new Point(30, 198);
            grbPlan.Name = "grbPlan";
            grbPlan.Size = new Size(317, 179);
            grbPlan.TabIndex = 1;
            grbPlan.TabStop = false;
            grbPlan.Text = "Plan";
            // 
            // btnCalcular
            // 
            btnCalcular.Enabled = false;
            btnCalcular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(132, 462);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 51);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(251, 462);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 51);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(379, 527);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(grbPlan);
            Controls.Add(gpbDatosPersonales);
            Controls.Add(grbPago);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo - Inscripcion";
            Load += frmInscripcion_Load;
            grbPago.ResumeLayout(false);
            grbPago.PerformLayout();
            gpbDatosPersonales.ResumeLayout(false);
            gpbDatosPersonales.PerformLayout();
            grbPlan.ResumeLayout(false);
            grbPlan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private Label lblEdad;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label lblCantMeses;
        private TextBox txtMeses;
        private Label lblCasillero;
        private CheckBox chkCasillero;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTarjeta;
        private GroupBox grbPago;
        private ComboBox cboCuotas;
        private GroupBox gpbDatosPersonales;
        private CheckBox chkEstudiante;
        private Label lblEstudiante;
        private Label lblPlan;
        private ComboBox cboPlan;
        private Label lblTurno;
        private ComboBox cboTurno;
        private GroupBox grbPlan;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}
