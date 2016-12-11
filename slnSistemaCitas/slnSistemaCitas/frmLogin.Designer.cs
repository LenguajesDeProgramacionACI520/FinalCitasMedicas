namespace slnSistemaCitas
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtCi = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.pcbLogin = new System.Windows.Forms.PictureBox();
            this.pcbPassVis = new System.Windows.Forms.PictureBox();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPassVis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCi
            // 
            this.txtCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtCi.Location = new System.Drawing.Point(188, 91);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(162, 28);
            this.txtCi.TabIndex = 0;
            this.txtCi.TextChanged += new System.EventHandler(this.txtCi_TextChanged);
            this.txtCi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCi_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtPass.Location = new System.Drawing.Point(188, 164);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(162, 28);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.Honeydew;
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnIngreso.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIngreso.Location = new System.Drawing.Point(56, 248);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(121, 36);
            this.btnIngreso.TabIndex = 2;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.Honeydew;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistro.Location = new System.Drawing.Point(229, 248);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(121, 36);
            this.btnRegistro.TabIndex = 3;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTitulo.Location = new System.Drawing.Point(42, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(308, 29);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Sistema de Citas Médicas";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblUsuario.ForeColor = System.Drawing.Color.Silver;
            this.lblUsuario.Location = new System.Drawing.Point(52, 91);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 24);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblContraseña.ForeColor = System.Drawing.Color.Silver;
            this.lblContraseña.Location = new System.Drawing.Point(28, 167);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(111, 24);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // pcbLogin
            // 
            this.pcbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogin.Image")));
            this.pcbLogin.Location = new System.Drawing.Point(404, -7);
            this.pcbLogin.Name = "pcbLogin";
            this.pcbLogin.Size = new System.Drawing.Size(317, 339);
            this.pcbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogin.TabIndex = 7;
            this.pcbLogin.TabStop = false;
            // 
            // pcbPassVis
            // 
            this.pcbPassVis.Image = ((System.Drawing.Image)(resources.GetObject("pcbPassVis.Image")));
            this.pcbPassVis.Location = new System.Drawing.Point(356, 164);
            this.pcbPassVis.Name = "pcbPassVis";
            this.pcbPassVis.Size = new System.Drawing.Size(31, 28);
            this.pcbPassVis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbPassVis.TabIndex = 8;
            this.pcbPassVis.TabStop = false;
            this.pcbPassVis.Click += new System.EventHandler(this.pcbPassVis_Click);
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.Location = new System.Drawing.Point(356, 91);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(31, 28);
            this.pcbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUsuario.TabIndex = 9;
            this.pcbUsuario.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(708, 324);
            this.Controls.Add(this.pcbUsuario);
            this.Controls.Add(this.pcbPassVis);
            this.Controls.Add(this.pcbLogin);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtCi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPassVis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.PictureBox pcbLogin;
        private System.Windows.Forms.PictureBox pcbPassVis;
        private System.Windows.Forms.PictureBox pcbUsuario;
    }
}