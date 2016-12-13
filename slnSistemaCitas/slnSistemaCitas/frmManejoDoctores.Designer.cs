namespace slnSistemaCitas
{
    partial class frmManejoDoctores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbPersonal = new System.Windows.Forms.GroupBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCelPrefijo = new System.Windows.Forms.TextBox();
            this.nucosto = new System.Windows.Forms.NumericUpDown();
            this.dtpfechaNa = new System.Windows.Forms.DateTimePicker();
            this.mskCedula = new System.Windows.Forms.MaskedTextBox();
            this.lblcedula = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblcosto = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblHospital = new System.Windows.Forms.Label();
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvDoctores = new System.Windows.Forms.DataGridView();
            this.grbPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nucosto)).BeginInit();
            this.grbOpciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctores)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPersonal
            // 
            this.grbPersonal.BackColor = System.Drawing.Color.Transparent;
            this.grbPersonal.Controls.Add(this.cmbGenero);
            this.grbPersonal.Controls.Add(this.lblGenero);
            this.grbPersonal.Controls.Add(this.txtCelular);
            this.grbPersonal.Controls.Add(this.txtCelPrefijo);
            this.grbPersonal.Controls.Add(this.nucosto);
            this.grbPersonal.Controls.Add(this.dtpfechaNa);
            this.grbPersonal.Controls.Add(this.mskCedula);
            this.grbPersonal.Controls.Add(this.lblcedula);
            this.grbPersonal.Controls.Add(this.txtApellido);
            this.grbPersonal.Controls.Add(this.txtNombre);
            this.grbPersonal.Controls.Add(this.lblcosto);
            this.grbPersonal.Controls.Add(this.lbltelefono);
            this.grbPersonal.Controls.Add(this.lblfecha);
            this.grbPersonal.Controls.Add(this.lblnombre);
            this.grbPersonal.Controls.Add(this.lblapellido);
            this.grbPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.grbPersonal.ForeColor = System.Drawing.Color.MintCream;
            this.grbPersonal.Location = new System.Drawing.Point(13, 46);
            this.grbPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.grbPersonal.Name = "grbPersonal";
            this.grbPersonal.Padding = new System.Windows.Forms.Padding(4);
            this.grbPersonal.Size = new System.Drawing.Size(656, 181);
            this.grbPersonal.TabIndex = 26;
            this.grbPersonal.TabStop = false;
            this.grbPersonal.Text = "Información Personal";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(112, 128);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(179, 28);
            this.cmbGenero.TabIndex = 4;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(34, 133);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(69, 20);
            this.lblGenero.TabIndex = 41;
            this.lblGenero.Text = "Género:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.txtCelular.Location = new System.Drawing.Point(161, 79);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(130, 24);
            this.txtCelular.TabIndex = 3;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtCelPrefijo
            // 
            this.txtCelPrefijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.txtCelPrefijo.ForeColor = System.Drawing.Color.Gray;
            this.txtCelPrefijo.Location = new System.Drawing.Point(112, 79);
            this.txtCelPrefijo.Name = "txtCelPrefijo";
            this.txtCelPrefijo.Size = new System.Drawing.Size(43, 24);
            this.txtCelPrefijo.TabIndex = 39;
            this.txtCelPrefijo.Text = "+593";
            // 
            // nucosto
            // 
            this.nucosto.Location = new System.Drawing.Point(189, 463);
            this.nucosto.Margin = new System.Windows.Forms.Padding(4);
            this.nucosto.Name = "nucosto";
            this.nucosto.Size = new System.Drawing.Size(259, 26);
            this.nucosto.TabIndex = 38;
            // 
            // dtpfechaNa
            // 
            this.dtpfechaNa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaNa.Location = new System.Drawing.Point(479, 131);
            this.dtpfechaNa.Margin = new System.Windows.Forms.Padding(4);
            this.dtpfechaNa.Name = "dtpfechaNa";
            this.dtpfechaNa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpfechaNa.Size = new System.Drawing.Size(161, 26);
            this.dtpfechaNa.TabIndex = 5;
            // 
            // mskCedula
            // 
            this.mskCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.mskCedula.Location = new System.Drawing.Point(111, 31);
            this.mskCedula.Margin = new System.Windows.Forms.Padding(4);
            this.mskCedula.Mask = "9999999999";
            this.mskCedula.Name = "mskCedula";
            this.mskCedula.Size = new System.Drawing.Size(179, 24);
            this.mskCedula.TabIndex = 0;
            this.mskCedula.TextChanged += new System.EventHandler(this.mskCedula_TextChanged);
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.ForeColor = System.Drawing.Color.MintCream;
            this.lblcedula.Location = new System.Drawing.Point(37, 34);
            this.lblcedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(66, 20);
            this.lblcedula.TabIndex = 25;
            this.lblcedula.Text = "Cédula:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.txtApellido.Location = new System.Drawing.Point(479, 83);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(161, 24);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.txtNombre.Location = new System.Drawing.Point(479, 30);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblcosto
            // 
            this.lblcosto.AutoSize = true;
            this.lblcosto.Location = new System.Drawing.Point(55, 465);
            this.lblcosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcosto.Name = "lblcosto";
            this.lblcosto.Size = new System.Drawing.Size(144, 20);
            this.lblcosto.TabIndex = 37;
            this.lblcosto.Text = "COSTO DE CITA:";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.ForeColor = System.Drawing.Color.MintCream;
            this.lbltelefono.Location = new System.Drawing.Point(37, 82);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(67, 20);
            this.lbltelefono.TabIndex = 29;
            this.lbltelefono.Text = "Celular:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.ForeColor = System.Drawing.Color.MintCream;
            this.lblfecha.Location = new System.Drawing.Point(322, 136);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(149, 20);
            this.lblfecha.TabIndex = 27;
            this.lblfecha.Text = "Fecha Nacimiento:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.ForeColor = System.Drawing.Color.MintCream;
            this.lblnombre.Location = new System.Drawing.Point(398, 34);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(73, 20);
            this.lblnombre.TabIndex = 21;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.ForeColor = System.Drawing.Color.MintCream;
            this.lblapellido.Location = new System.Drawing.Point(398, 86);
            this.lblapellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(73, 20);
            this.lblapellido.TabIndex = 23;
            this.lblapellido.Text = "Apellido:";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(416, 41);
            this.cmbEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(215, 28);
            this.cmbEspecialidad.TabIndex = 7;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.ForeColor = System.Drawing.Color.MintCream;
            this.lblEspecialidad.Location = new System.Drawing.Point(299, 44);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(109, 20);
            this.lblEspecialidad.TabIndex = 35;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.ForeColor = System.Drawing.Color.MintCream;
            this.lblHospital.Location = new System.Drawing.Point(7, 44);
            this.lblHospital.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(76, 20);
            this.lblHospital.TabIndex = 33;
            this.lblHospital.Text = "Hospital:";
            // 
            // grbOpciones
            // 
            this.grbOpciones.BackColor = System.Drawing.Color.Transparent;
            this.grbOpciones.Controls.Add(this.btnEliminar);
            this.grbOpciones.Controls.Add(this.btnModificar);
            this.grbOpciones.Controls.Add(this.btnIngresar);
            this.grbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.grbOpciones.ForeColor = System.Drawing.Color.MintCream;
            this.grbOpciones.Location = new System.Drawing.Point(696, 61);
            this.grbOpciones.Margin = new System.Windows.Forms.Padding(4);
            this.grbOpciones.Name = "grbOpciones";
            this.grbOpciones.Padding = new System.Windows.Forms.Padding(4);
            this.grbOpciones.Size = new System.Drawing.Size(339, 277);
            this.grbOpciones.TabIndex = 30;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Opciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnEliminar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnEliminar.Location = new System.Drawing.Point(28, 203);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(281, 52);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnModificar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnModificar.Location = new System.Drawing.Point(28, 120);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(281, 48);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.White;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnIngresar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnIngresar.Location = new System.Drawing.Point(28, 37);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(281, 46);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Agregar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cmbHospital
            // 
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.Location = new System.Drawing.Point(90, 41);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(202, 28);
            this.cmbHospital.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHospital);
            this.groupBox2.Controls.Add(this.cmbHospital);
            this.groupBox2.Controls.Add(this.lblEspecialidad);
            this.groupBox2.Controls.Add(this.cmbEspecialidad);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.groupBox2.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox2.Location = new System.Drawing.Point(13, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 100);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Laboral";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(307, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(362, 32);
            this.lblTitulo.TabIndex = 44;
            this.lblTitulo.Text = "Administración de Doctores";
            // 
            // dgvDoctores
            // 
            this.dgvDoctores.AllowUserToAddRows = false;
            this.dgvDoctores.AllowUserToDeleteRows = false;
            this.dgvDoctores.AllowUserToResizeColumns = false;
            this.dgvDoctores.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.dgvDoctores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDoctores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDoctores.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvDoctores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("HP Simplified", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("HP Simplified", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctores.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDoctores.Location = new System.Drawing.Point(7, 379);
            this.dgvDoctores.Name = "dgvDoctores";
            this.dgvDoctores.ReadOnly = true;
            this.dgvDoctores.RowTemplate.Height = 24;
            this.dgvDoctores.Size = new System.Drawing.Size(1031, 221);
            this.dgvDoctores.TabIndex = 10;
            this.dgvDoctores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctores_CellDoubleClick);
            // 
            // frmManejoDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1050, 612);
            this.Controls.Add(this.dgvDoctores);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbPersonal);
            this.Controls.Add(this.grbOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmManejoDoctores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Doctores";
            this.Load += new System.EventHandler(this.frmManejoDoctores_Load);
            this.grbPersonal.ResumeLayout(false);
            this.grbPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nucosto)).EndInit();
            this.grbOpciones.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonal;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCelPrefijo;
        private System.Windows.Forms.NumericUpDown nucosto;
        private System.Windows.Forms.DateTimePicker dtpfechaNa;
        private System.Windows.Forms.MaskedTextBox mskCedula;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblcosto;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ComboBox cmbHospital;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvDoctores;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblGenero;
    }
}