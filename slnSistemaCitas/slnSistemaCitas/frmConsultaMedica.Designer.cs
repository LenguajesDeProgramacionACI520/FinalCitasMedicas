namespace slnSistemaCitas
{
    partial class frmConsultaMedia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblHospital = new System.Windows.Forms.Label();
            this.lstEspecialidad = new System.Windows.Forms.ListBox();
            this.lstHospital = new System.Windows.Forms.ListBox();
            this.lblFeha = new System.Windows.Forms.Label();
            this.mtcFecha = new System.Windows.Forms.MonthCalendar();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lstDoctor = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lblEspecialidad.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblEspecialidad.Location = new System.Drawing.Point(76, 92);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(168, 31);
            this.lblEspecialidad.TabIndex = 1;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.BackColor = System.Drawing.Color.Transparent;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lblCiudad.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblCiudad.Location = new System.Drawing.Point(445, 92);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(100, 31);
            this.lblCiudad.TabIndex = 3;
            this.lblCiudad.Text = "Ciudad";
            this.lblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.BackColor = System.Drawing.Color.Transparent;
            this.lblHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lblHospital.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblHospital.Location = new System.Drawing.Point(412, 185);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(190, 31);
            this.lblHospital.TabIndex = 4;
            this.lblHospital.Text = "Centro Medico";
            // 
            // lstEspecialidad
            // 
            this.lstEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lstEspecialidad.FormattingEnabled = true;
            this.lstEspecialidad.ItemHeight = 22;
            this.lstEspecialidad.Location = new System.Drawing.Point(25, 143);
            this.lstEspecialidad.Name = "lstEspecialidad";
            this.lstEspecialidad.Size = new System.Drawing.Size(290, 576);
            this.lstEspecialidad.TabIndex = 5;
            this.lstEspecialidad.SelectedIndexChanged += new System.EventHandler(this.lstEspecialidad_SelectedIndexChanged);
            // 
            // lstHospital
            // 
            this.lstHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lstHospital.FormattingEnabled = true;
            this.lstHospital.ItemHeight = 22;
            this.lstHospital.Location = new System.Drawing.Point(370, 231);
            this.lstHospital.Name = "lstHospital";
            this.lstHospital.Size = new System.Drawing.Size(290, 224);
            this.lstHospital.TabIndex = 6;
            this.lstHospital.SelectedIndexChanged += new System.EventHandler(this.lstHospital_SelectedIndexChanged);
            // 
            // lblFeha
            // 
            this.lblFeha.AutoSize = true;
            this.lblFeha.BackColor = System.Drawing.Color.Transparent;
            this.lblFeha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.lblFeha.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblFeha.Location = new System.Drawing.Point(462, 471);
            this.lblFeha.Name = "lblFeha";
            this.lblFeha.Size = new System.Drawing.Size(94, 32);
            this.lblFeha.TabIndex = 7;
            this.lblFeha.Text = "Fecha";
            // 
            // mtcFecha
            // 
            this.mtcFecha.BackColor = System.Drawing.Color.White;
            this.mtcFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.mtcFecha.Location = new System.Drawing.Point(370, 512);
            this.mtcFecha.MaxSelectionCount = 1;
            this.mtcFecha.Name = "mtcFecha";
            this.mtcFecha.TabIndex = 8;
            this.mtcFecha.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mtcFecha_DateSelected);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(370, 143);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(290, 30);
            this.cmbCiudad.TabIndex = 2;
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.cmbCiudad_SelectedIndexChanged);
            // 
            // cmbHora
            // 
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(730, 143);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(290, 30);
            this.cmbHora.TabIndex = 9;
            this.cmbHora.SelectedIndexChanged += new System.EventHandler(this.cmbHora_SelectedIndexChanged);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lblHora.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblHora.Location = new System.Drawing.Point(827, 92);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(73, 31);
            this.lblHora.TabIndex = 10;
            this.lblHora.Text = "Hora";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lblDoctor.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblDoctor.Location = new System.Drawing.Point(827, 185);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(95, 31);
            this.lblDoctor.TabIndex = 11;
            this.lblDoctor.Text = "Doctor";
            // 
            // lstDoctor
            // 
            this.lstDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lstDoctor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstDoctor.FormattingEnabled = true;
            this.lstDoctor.ItemHeight = 22;
            this.lstDoctor.Location = new System.Drawing.Point(730, 231);
            this.lstDoctor.Name = "lstDoctor";
            this.lstDoctor.Size = new System.Drawing.Size(290, 488);
            this.lstDoctor.TabIndex = 12;
            this.lstDoctor.SelectedIndexChanged += new System.EventHandler(this.lstDoctor_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.2F);
            this.lblTitulo.ForeColor = System.Drawing.Color.MintCream;
            this.lblTitulo.Location = new System.Drawing.Point(279, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(470, 59);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Solicitar Nueva Cita";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.btnIngresar.ForeColor = System.Drawing.Color.DimGray;
            this.btnIngresar.Location = new System.Drawing.Point(783, 736);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(187, 46);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Continuar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmConsultaMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::slnSistemaCitas.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1045, 794);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstDoctor);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.mtcFecha);
            this.Controls.Add(this.lblFeha);
            this.Controls.Add(this.lstHospital);
            this.Controls.Add(this.lstEspecialidad);
            this.Controls.Add(this.lblHospital);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.lblEspecialidad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaMedia";
            this.Text = "Solicitar Cita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.ListBox lstEspecialidad;
        private System.Windows.Forms.ListBox lstHospital;
        private System.Windows.Forms.Label lblFeha;
        private System.Windows.Forms.MonthCalendar mtcFecha;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ListBox lstDoctor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnIngresar;
    }
}