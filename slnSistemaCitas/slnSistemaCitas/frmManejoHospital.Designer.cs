namespace slnSistemaCitas
{
    partial class frmManejoHospital
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvHosp = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.grbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHosp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 131);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(101, 181);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(163, 24);
            this.cmbCiudad.TabIndex = 2;
            // 
            // grbOpciones
            // 
            this.grbOpciones.BackColor = System.Drawing.Color.Transparent;
            this.grbOpciones.Controls.Add(this.btnEliminar);
            this.grbOpciones.Controls.Add(this.btnModificar);
            this.grbOpciones.Controls.Add(this.btnAgregar);
            this.grbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.grbOpciones.ForeColor = System.Drawing.Color.MintCream;
            this.grbOpciones.Location = new System.Drawing.Point(316, 62);
            this.grbOpciones.Name = "grbOpciones";
            this.grbOpciones.Size = new System.Drawing.Size(226, 172);
            this.grbOpciones.TabIndex = 10;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Opciones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.Location = new System.Drawing.Point(53, 21);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 36);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnModificar.Location = new System.Drawing.Point(53, 69);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 36);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnEliminar.Location = new System.Drawing.Point(53, 119);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 36);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvHosp
            // 
            this.dgvHosp.AllowUserToAddRows = false;
            this.dgvHosp.AllowUserToDeleteRows = false;
            this.dgvHosp.AllowUserToResizeColumns = false;
            this.dgvHosp.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.dgvHosp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHosp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHosp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvHosp.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvHosp.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("HP Simplified", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHosp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHosp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("HP Simplified", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHosp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHosp.Location = new System.Drawing.Point(11, 244);
            this.dgvHosp.Name = "dgvHosp";
            this.dgvHosp.ReadOnly = true;
            this.dgvHosp.RowTemplate.Height = 24;
            this.dgvHosp.Size = new System.Drawing.Size(541, 186);
            this.dgvHosp.TabIndex = 6;
            this.dgvHosp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHosp_CellDoubleClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.lblTitulo.ForeColor = System.Drawing.Color.MintCream;
            this.lblTitulo.Location = new System.Drawing.Point(160, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(149, 32);
            this.lblTitulo.TabIndex = 48;
            this.lblTitulo.Text = "Hospitales";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lbl_Id.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_Id.Location = new System.Drawing.Point(68, 79);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(27, 20);
            this.lbl_Id.TabIndex = 49;
            this.lbl_Id.Text = "Id:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblNombre.ForeColor = System.Drawing.Color.MintCream;
            this.lblNombre.Location = new System.Drawing.Point(22, 131);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 50;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.BackColor = System.Drawing.Color.Transparent;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblCiudad.ForeColor = System.Drawing.Color.MintCream;
            this.lblCiudad.Location = new System.Drawing.Point(29, 181);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(66, 20);
            this.lblCiudad.TabIndex = 51;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(101, 79);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(85, 22);
            this.txtId.TabIndex = 0;
            // 
            // frmManejoHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(564, 442);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvHosp);
            this.Controls.Add(this.grbOpciones);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "frmManejoHospital";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Hospitales";
            this.Load += new System.EventHandler(this.frmManejoHospital_Load);
            this.grbOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHosp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvHosp;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtId;
    }
}