namespace slnSistemaCitas
{
    partial class frmMdi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mestInicio = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDeEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDeDoctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDeHorariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segurosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promocionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDeAdministradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarCitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vincularHorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mestInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // mestInicio
            // 
            this.mestInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mestInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.adminUsuarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mestInicio.Location = new System.Drawing.Point(0, 0);
            this.mestInicio.Name = "mestInicio";
            this.mestInicio.Size = new System.Drawing.Size(974, 28);
            this.mestInicio.TabIndex = 1;
            this.mestInicio.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manejoDeUsuariosToolStripMenuItem,
            this.manejoDeEspecialidadesToolStripMenuItem,
            this.manjeToolStripMenuItem,
            this.manejoDeDoctoresToolStripMenuItem,
            this.manejoDeHorariosToolStripMenuItem,
            this.segurosToolStripMenuItem,
            this.promocionesToolStripMenuItem,
            this.manejoDeAdministradoresToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // manejoDeUsuariosToolStripMenuItem
            // 
            this.manejoDeUsuariosToolStripMenuItem.Name = "manejoDeUsuariosToolStripMenuItem";
            this.manejoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.manejoDeUsuariosToolStripMenuItem.Text = "Usuarios";
            this.manejoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.manejoDeUsuariosToolStripMenuItem_Click);
            // 
            // manejoDeEspecialidadesToolStripMenuItem
            // 
            this.manejoDeEspecialidadesToolStripMenuItem.Name = "manejoDeEspecialidadesToolStripMenuItem";
            this.manejoDeEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.manejoDeEspecialidadesToolStripMenuItem.Text = "Especialidades";
            this.manejoDeEspecialidadesToolStripMenuItem.Click += new System.EventHandler(this.manejoDeEspecialidadesToolStripMenuItem_Click);
            // 
            // manjeToolStripMenuItem
            // 
            this.manjeToolStripMenuItem.Name = "manjeToolStripMenuItem";
            this.manjeToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.manjeToolStripMenuItem.Text = "Hospitales";
            this.manjeToolStripMenuItem.Click += new System.EventHandler(this.manjeToolStripMenuItem_Click);
            // 
            // manejoDeDoctoresToolStripMenuItem
            // 
            this.manejoDeDoctoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDoctorToolStripMenuItem,
            this.vincularHorarioToolStripMenuItem});
            this.manejoDeDoctoresToolStripMenuItem.Name = "manejoDeDoctoresToolStripMenuItem";
            this.manejoDeDoctoresToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.manejoDeDoctoresToolStripMenuItem.Text = "Doctores";
            this.manejoDeDoctoresToolStripMenuItem.Click += new System.EventHandler(this.manejoDeDoctoresToolStripMenuItem_Click);
            // 
            // manejoDeHorariosToolStripMenuItem
            // 
            this.manejoDeHorariosToolStripMenuItem.Name = "manejoDeHorariosToolStripMenuItem";
            this.manejoDeHorariosToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.manejoDeHorariosToolStripMenuItem.Text = "Horarios";
            // 
            // segurosToolStripMenuItem
            // 
            this.segurosToolStripMenuItem.Name = "segurosToolStripMenuItem";
            this.segurosToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.segurosToolStripMenuItem.Text = "Seguros";
            this.segurosToolStripMenuItem.Click += new System.EventHandler(this.segurosToolStripMenuItem_Click);
            // 
            // promocionesToolStripMenuItem
            // 
            this.promocionesToolStripMenuItem.Name = "promocionesToolStripMenuItem";
            this.promocionesToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.promocionesToolStripMenuItem.Text = "Promociones";
            this.promocionesToolStripMenuItem.Click += new System.EventHandler(this.promocionesToolStripMenuItem_Click);
            // 
            // manejoDeAdministradoresToolStripMenuItem
            // 
            this.manejoDeAdministradoresToolStripMenuItem.Name = "manejoDeAdministradoresToolStripMenuItem";
            this.manejoDeAdministradoresToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.manejoDeAdministradoresToolStripMenuItem.Text = "Manejo de Administradores";
            this.manejoDeAdministradoresToolStripMenuItem.Click += new System.EventHandler(this.manejoDeAdministradoresToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitarCitToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // solicitarCitToolStripMenuItem
            // 
            this.solicitarCitToolStripMenuItem.Name = "solicitarCitToolStripMenuItem";
            this.solicitarCitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.solicitarCitToolStripMenuItem.Text = "Nueva Cita";
            this.solicitarCitToolStripMenuItem.Click += new System.EventHandler(this.solicitarCitToolStripMenuItem_Click);
            // 
            // adminUsuarioToolStripMenuItem
            // 
            this.adminUsuarioToolStripMenuItem.Name = "adminUsuarioToolStripMenuItem";
            this.adminUsuarioToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.adminUsuarioToolStripMenuItem.Text = "Admin_Usuario";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // agregarDoctorToolStripMenuItem
            // 
            this.agregarDoctorToolStripMenuItem.Name = "agregarDoctorToolStripMenuItem";
            this.agregarDoctorToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.agregarDoctorToolStripMenuItem.Text = "Agregar Doctor";
            this.agregarDoctorToolStripMenuItem.Click += new System.EventHandler(this.agregarDoctorToolStripMenuItem_Click);
            // 
            // vincularHorarioToolStripMenuItem
            // 
            this.vincularHorarioToolStripMenuItem.Name = "vincularHorarioToolStripMenuItem";
            this.vincularHorarioToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.vincularHorarioToolStripMenuItem.Text = "Vincular Horario";
            this.vincularHorarioToolStripMenuItem.Click += new System.EventHandler(this.vincularHorarioToolStripMenuItem_Click);
            // 
            // frmMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 511);
            this.Controls.Add(this.mestInicio);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mestInicio;
            this.MaximizeBox = false;
            this.Name = "frmMdi";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Citas Médicas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMdi_Load);
            this.mestInicio.ResumeLayout(false);
            this.mestInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mestInicio;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDeEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDeDoctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDeHorariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segurosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDeAdministradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promocionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarCitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vincularHorarioToolStripMenuItem;
    }
}

