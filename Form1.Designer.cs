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
            groupBox1 = new GroupBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            grbPago.SuspendLayout();
            gpbDatosPersonales.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(14, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(14, 57);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(89, 27);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(89, 57);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(52, 23);
            txtEdad.TabIndex = 3;
            // 
            // lblCantMeses
            // 
            lblCantMeses.AutoSize = true;
            lblCantMeses.Location = new Point(6, 93);
            lblCantMeses.Name = "lblCantMeses";
            lblCantMeses.Size = new Size(107, 15);
            lblCantMeses.TabIndex = 4;
            lblCantMeses.Text = "Cantidad de Meses";
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(119, 90);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(70, 23);
            txtMeses.TabIndex = 5;
            // 
            // lblCasillero
            // 
            lblCasillero.AutoSize = true;
            lblCasillero.Location = new Point(6, 123);
            lblCasillero.Name = "lblCasillero";
            lblCasillero.Size = new Size(126, 15);
            lblCasillero.TabIndex = 6;
            lblCasillero.Text = "Casillero ($ 3.000/mes)";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(138, 124);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(15, 14);
            chkCasillero.TabIndex = 7;
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(14, 29);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(102, 28);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // grbPago
            // 
            grbPago.Controls.Add(cboCuotas);
            grbPago.Controls.Add(rbtTarjeta);
            grbPago.Controls.Add(rbtEfectivo);
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
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1 cuota ( Sin Recargo )", "3 cuotas (10% Recargo)", "6 cuotas (20% Recargo)" });
            cboCuotas.Location = new Point(183, 27);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(121, 23);
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
            chkEstudiante.Location = new Point(89, 89);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(15, 14);
            chkEstudiante.TabIndex = 5;
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Location = new Point(14, 88);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(67, 15);
            lblEstudiante.TabIndex = 4;
            lblEstudiante.Text = "Estudiante?";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(6, 25);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "Plan";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(57, 22);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(157, 23);
            cboPlan.TabIndex = 1;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(6, 62);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 2;
            lblTurno.Text = "Turno";
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(57, 54);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(157, 23);
            cboTurno.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCantMeses);
            groupBox1.Controls.Add(cboTurno);
            groupBox1.Controls.Add(txtMeses);
            groupBox1.Controls.Add(lblTurno);
            groupBox1.Controls.Add(lblCasillero);
            groupBox1.Controls.Add(cboPlan);
            groupBox1.Controls.Add(chkCasillero);
            groupBox1.Controls.Add(lblPlan);
            groupBox1.Location = new Point(30, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 179);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(64, 462);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(98, 36);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(196, 462);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(98, 36);
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
            ClientSize = new Size(397, 525);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox1);
            Controls.Add(gpbDatosPersonales);
            Controls.Add(grbPago);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo - Inscripcion";
            Load += frmInscripcion_Load;
            grbPago.ResumeLayout(false);
            grbPago.PerformLayout();
            gpbDatosPersonales.ResumeLayout(false);
            gpbDatosPersonales.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}
