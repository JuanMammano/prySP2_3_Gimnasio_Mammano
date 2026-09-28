namespace prySP2_3_Gimnasio_Mammano
{
    partial class frmCalculadora
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
            grbPlan = new GroupBox();
            rdbMusculacion = new RadioButton();
            rdbFuncional = new RadioButton();
            rdbNatacion = new RadioButton();
            grbTurno = new GroupBox();
            rdbNoche = new RadioButton();
            rdbTarde = new RadioButton();
            rdbMañana = new RadioButton();
            lblCantMeses = new Label();
            txtMeses = new TextBox();
            lblCasillero = new Label();
            chkCasillero = new CheckBox();
            rdbEfectivo = new RadioButton();
            rdbTarjeta = new RadioButton();
            grbPago = new GroupBox();
            comboBox1 = new ComboBox();
            grbPlan.SuspendLayout();
            grbTurno.SuspendLayout();
            grbPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(12, 100);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(69, 100);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(52, 23);
            txtEdad.TabIndex = 3;
            // 
            // grbPlan
            // 
            grbPlan.Controls.Add(rdbNatacion);
            grbPlan.Controls.Add(rdbFuncional);
            grbPlan.Controls.Add(rdbMusculacion);
            grbPlan.Location = new Point(12, 129);
            grbPlan.Name = "grbPlan";
            grbPlan.Size = new Size(320, 55);
            grbPlan.TabIndex = 4;
            grbPlan.TabStop = false;
            grbPlan.Text = "Plan";
            // 
            // rdbMusculacion
            // 
            rdbMusculacion.AutoSize = true;
            rdbMusculacion.Location = new Point(16, 22);
            rdbMusculacion.Name = "rdbMusculacion";
            rdbMusculacion.Size = new Size(93, 19);
            rdbMusculacion.TabIndex = 0;
            rdbMusculacion.TabStop = true;
            rdbMusculacion.Text = "Musculacion";
            rdbMusculacion.UseVisualStyleBackColor = true;
            // 
            // rdbFuncional
            // 
            rdbFuncional.AutoSize = true;
            rdbFuncional.Location = new Point(125, 22);
            rdbFuncional.Name = "rdbFuncional";
            rdbFuncional.Size = new Size(77, 19);
            rdbFuncional.TabIndex = 1;
            rdbFuncional.TabStop = true;
            rdbFuncional.Text = "Funcional";
            rdbFuncional.UseVisualStyleBackColor = true;
            // 
            // rdbNatacion
            // 
            rdbNatacion.AutoSize = true;
            rdbNatacion.Location = new Point(218, 22);
            rdbNatacion.Name = "rdbNatacion";
            rdbNatacion.Size = new Size(73, 19);
            rdbNatacion.TabIndex = 2;
            rdbNatacion.TabStop = true;
            rdbNatacion.Text = "Natacion";
            rdbNatacion.UseVisualStyleBackColor = true;
            // 
            // grbTurno
            // 
            grbTurno.Controls.Add(rdbMañana);
            grbTurno.Controls.Add(rdbTarde);
            grbTurno.Controls.Add(rdbNoche);
            grbTurno.Location = new Point(14, 190);
            grbTurno.Name = "grbTurno";
            grbTurno.Size = new Size(318, 47);
            grbTurno.TabIndex = 5;
            grbTurno.TabStop = false;
            grbTurno.Text = "Turno";
            // 
            // rdbNoche
            // 
            rdbNoche.AutoSize = true;
            rdbNoche.Location = new Point(202, 22);
            rdbNoche.Name = "rdbNoche";
            rdbNoche.Size = new Size(84, 19);
            rdbNoche.TabIndex = 0;
            rdbNoche.TabStop = true;
            rdbNoche.Text = "18hs - 23hs";
            rdbNoche.UseVisualStyleBackColor = true;
            // 
            // rdbTarde
            // 
            rdbTarde.AutoSize = true;
            rdbTarde.Location = new Point(108, 22);
            rdbTarde.Name = "rdbTarde";
            rdbTarde.Size = new Size(84, 19);
            rdbTarde.TabIndex = 1;
            rdbTarde.TabStop = true;
            rdbTarde.Text = "14hs - 18hs";
            rdbTarde.UseVisualStyleBackColor = true;
            // 
            // rdbMañana
            // 
            rdbMañana.AutoSize = true;
            rdbMañana.Location = new Point(14, 22);
            rdbMañana.Name = "rdbMañana";
            rdbMañana.Size = new Size(78, 19);
            rdbMañana.TabIndex = 2;
            rdbMañana.TabStop = true;
            rdbMañana.Text = "7hs - 12hs";
            rdbMañana.UseVisualStyleBackColor = true;
            // 
            // lblCantMeses
            // 
            lblCantMeses.AutoSize = true;
            lblCantMeses.Location = new Point(14, 256);
            lblCantMeses.Name = "lblCantMeses";
            lblCantMeses.Size = new Size(107, 15);
            lblCantMeses.TabIndex = 6;
            lblCantMeses.Text = "Cantidad de Meses";
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(122, 253);
            txtMeses.MaxLength = 12;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(70, 23);
            txtMeses.TabIndex = 7;
            // 
            // lblCasillero
            // 
            lblCasillero.AutoSize = true;
            lblCasillero.Location = new Point(216, 256);
            lblCasillero.Name = "lblCasillero";
            lblCasillero.Size = new Size(57, 15);
            lblCasillero.TabIndex = 8;
            lblCasillero.Text = "Casillero?";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(279, 256);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(15, 14);
            chkCasillero.TabIndex = 11;
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // rdbEfectivo
            // 
            rdbEfectivo.AutoSize = true;
            rdbEfectivo.Location = new Point(14, 29);
            rdbEfectivo.Name = "rdbEfectivo";
            rdbEfectivo.Size = new Size(67, 19);
            rdbEfectivo.TabIndex = 12;
            rdbEfectivo.TabStop = true;
            rdbEfectivo.Text = "Efectivo";
            rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rdbTarjeta
            // 
            rdbTarjeta.AutoSize = true;
            rdbTarjeta.Location = new Point(123, 29);
            rdbTarjeta.Name = "rdbTarjeta";
            rdbTarjeta.Size = new Size(60, 19);
            rdbTarjeta.TabIndex = 13;
            rdbTarjeta.TabStop = true;
            rdbTarjeta.Text = "Tarjeta";
            rdbTarjeta.UseVisualStyleBackColor = true;
            // 
            // grbPago
            // 
            grbPago.Controls.Add(comboBox1);
            grbPago.Controls.Add(rdbTarjeta);
            grbPago.Controls.Add(rdbEfectivo);
            grbPago.Location = new Point(14, 291);
            grbPago.Name = "grbPago";
            grbPago.Size = new Size(318, 73);
            grbPago.TabIndex = 14;
            grbPago.TabStop = false;
            grbPago.Text = "Forma de pago";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1 cuota ( Sin Recargo )", "3 cuotas (10% Recargo)", "6 cuotas (20% Recargo)" });
            comboBox1.Location = new Point(189, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 15;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 525);
            Controls.Add(grbPago);
            Controls.Add(chkCasillero);
            Controls.Add(lblCasillero);
            Controls.Add(txtMeses);
            Controls.Add(lblCantMeses);
            Controls.Add(grbTurno);
            Controls.Add(grbPlan);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "frmCalculadora";
            Text = "Calculadora de Inscripcion";
            grbPlan.ResumeLayout(false);
            grbPlan.PerformLayout();
            grbTurno.ResumeLayout(false);
            grbTurno.PerformLayout();
            grbPago.ResumeLayout(false);
            grbPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEdad;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private GroupBox grbPlan;
        private RadioButton rdbNatacion;
        private RadioButton rdbFuncional;
        private RadioButton rdbMusculacion;
        private GroupBox grbTurno;
        private RadioButton rdbMañana;
        private RadioButton rdbTarde;
        private RadioButton rdbNoche;
        private Label lblCantMeses;
        private TextBox txtMeses;
        private Label lblCasillero;
        private CheckBox chkCasillero;
        private RadioButton rdbEfectivo;
        private RadioButton rdbTarjeta;
        private GroupBox grbPago;
        private ComboBox comboBox1;
    }
}
