namespace slnSistemaCitas
{
    partial class frmDoctorHorario
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
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grbInformacion = new System.Windows.Forms.GroupBox();
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvDoctorHorario = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grbInformacion.SuspendLayout();
            this.grbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHorario
            // 
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(123, 61);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(172, 24);
            this.cmbHorario.TabIndex = 0;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(123, 98);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(172, 24);
            this.cmbDoctor.TabIndex = 1;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblHora.ForeColor = System.Drawing.Color.LightCyan;
            this.lblHora.Location = new System.Drawing.Point(36, 65);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 20);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora:";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblDoctor.ForeColor = System.Drawing.Color.LightCyan;
            this.lblDoctor.Location = new System.Drawing.Point(22, 101);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(65, 20);
            this.lblDoctor.TabIndex = 3;
            this.lblDoctor.Text = "Doctor:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(54, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Ingresar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(54, 89);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 38);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grbInformacion
            // 
            this.grbInformacion.BackColor = System.Drawing.Color.Transparent;
            this.grbInformacion.Controls.Add(this.txtId);
            this.grbInformacion.Controls.Add(this.lblId);
            this.grbInformacion.Controls.Add(this.cmbHorario);
            this.grbInformacion.Controls.Add(this.cmbDoctor);
            this.grbInformacion.Controls.Add(this.lblHora);
            this.grbInformacion.Controls.Add(this.lblDoctor);
            this.grbInformacion.Location = new System.Drawing.Point(24, 52);
            this.grbInformacion.Name = "grbInformacion";
            this.grbInformacion.Size = new System.Drawing.Size(317, 156);
            this.grbInformacion.TabIndex = 6;
            this.grbInformacion.TabStop = false;
            // 
            // grbOpciones
            // 
            this.grbOpciones.BackColor = System.Drawing.Color.Transparent;
            this.grbOpciones.Controls.Add(this.btnAgregar);
            this.grbOpciones.Controls.Add(this.btnEliminar);
            this.grbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.grbOpciones.Location = new System.Drawing.Point(361, 52);
            this.grbOpciones.Name = "grbOpciones";
            this.grbOpciones.Size = new System.Drawing.Size(200, 156);
            this.grbOpciones.TabIndex = 7;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Opciones";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lblTitulo.ForeColor = System.Drawing.Color.LightCyan;
            this.lblTitulo.Location = new System.Drawing.Point(140, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 31);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Asignación de Horarios";
            // 
            // dgvDoctorHorario
            // 
            this.dgvDoctorHorario.AllowUserToAddRows = false;
            this.dgvDoctorHorario.AllowUserToDeleteRows = false;
            this.dgvDoctorHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorHorario.Location = new System.Drawing.Point(24, 226);
            this.dgvDoctorHorario.Name = "dgvDoctorHorario";
            this.dgvDoctorHorario.ReadOnly = true;
            this.dgvDoctorHorario.RowTemplate.Height = 24;
            this.dgvDoctorHorario.Size = new System.Drawing.Size(537, 174);
            this.dgvDoctorHorario.TabIndex = 9;
            this.dgvDoctorHorario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctorHorario_CellDoubleClick);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblId.ForeColor = System.Drawing.Color.LightCyan;
            this.lblId.Location = new System.Drawing.Point(60, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(122, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(90, 22);
            this.txtId.TabIndex = 5;
            // 
            // frmDoctorHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::slnSistemaCitas.Properties.Resources.fondo3;
            this.ClientSize = new System.Drawing.Size(586, 418);
            this.Controls.Add(this.dgvDoctorHorario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbOpciones);
            this.Controls.Add(this.grbInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoctorHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Horario a Doctor";
            this.Load += new System.EventHandler(this.frmDoctorHorario_Load);
            this.grbInformacion.ResumeLayout(false);
            this.grbInformacion.PerformLayout();
            this.grbOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grbInformacion;
        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvDoctorHorario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}