namespace slnSistemaCitas
{
    partial class frmEspecialidad
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbOpciones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCosto = new System.Windows.Forms.Label();
            this.mskCosto = new System.Windows.Forms.MaskedTextBox();
            this.dgvEspe = new System.Windows.Forms.DataGridView();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.cmbPromocion = new System.Windows.Forms.ComboBox();
            this.gpbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.txtId.Location = new System.Drawing.Point(163, 88);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(68, 24);
            this.txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.txtNombre.Location = new System.Drawing.Point(163, 148);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblID.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblID.Location = new System.Drawing.Point(17, 90);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(125, 24);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Id Especialidad:";
            this.lblID.UseCompatibleTextRendering = true;
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblNombreE.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblNombreE.Location = new System.Drawing.Point(67, 150);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(75, 24);
            this.lblNombreE.TabIndex = 3;
            this.lblNombreE.Text = "Nombre: ";
            this.lblNombreE.UseCompatibleTextRendering = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblTitulo.Location = new System.Drawing.Point(192, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 29);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Especialidades";
            // 
            // gpbOpciones
            // 
            this.gpbOpciones.Controls.Add(this.btnEliminar);
            this.gpbOpciones.Controls.Add(this.btnModificar);
            this.gpbOpciones.Controls.Add(this.btnAgregar);
            this.gpbOpciones.Location = new System.Drawing.Point(368, 100);
            this.gpbOpciones.Name = "gpbOpciones";
            this.gpbOpciones.Size = new System.Drawing.Size(204, 188);
            this.gpbOpciones.TabIndex = 3;
            this.gpbOpciones.TabStop = false;
            this.gpbOpciones.Text = "Opciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Location = new System.Drawing.Point(53, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 32);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnModificar.Location = new System.Drawing.Point(53, 78);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 32);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAgregar.Location = new System.Drawing.Point(53, 31);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 32);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblCosto.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblCosto.Location = new System.Drawing.Point(84, 204);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(58, 20);
            this.lblCosto.TabIndex = 7;
            this.lblCosto.Text = "Costo:";
            // 
            // mskCosto
            // 
            this.mskCosto.Location = new System.Drawing.Point(163, 204);
            this.mskCosto.Mask = "99999999,99";
            this.mskCosto.Name = "mskCosto";
            this.mskCosto.Size = new System.Drawing.Size(170, 22);
            this.mskCosto.TabIndex = 2;
            // 
            // dgvEspe
            // 
            this.dgvEspe.AllowUserToAddRows = false;
            this.dgvEspe.AllowUserToDeleteRows = false;
            this.dgvEspe.AllowUserToResizeColumns = false;
            this.dgvEspe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.dgvEspe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEspe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEspe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvEspe.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvEspe.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("HP Simplified", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEspe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("HP Simplified", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEspe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEspe.Location = new System.Drawing.Point(12, 425);
            this.dgvEspe.Name = "dgvEspe";
            this.dgvEspe.ReadOnly = true;
            this.dgvEspe.RowTemplate.Height = 24;
            this.dgvEspe.Size = new System.Drawing.Size(550, 193);
            this.dgvEspe.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblDescripcion.Location = new System.Drawing.Point(38, 296);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 20);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.txtDescripcion.Location = new System.Drawing.Point(163, 294);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(170, 101);
            this.txtDescripcion.TabIndex = 9;
            // 
            // lblPromocion
            // 
            this.lblPromocion.AutoSize = true;
            this.lblPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblPromocion.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblPromocion.Location = new System.Drawing.Point(48, 251);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(94, 20);
            this.lblPromocion.TabIndex = 10;
            this.lblPromocion.Text = "Promocion:";
            // 
            // cmbPromocion
            // 
            this.cmbPromocion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPromocion.FormattingEnabled = true;
            this.cmbPromocion.Location = new System.Drawing.Point(163, 251);
            this.cmbPromocion.Name = "cmbPromocion";
            this.cmbPromocion.Size = new System.Drawing.Size(170, 24);
            this.cmbPromocion.TabIndex = 11;
            // 
            // frmEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 643);
            this.Controls.Add(this.cmbPromocion);
            this.Controls.Add(this.lblPromocion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dgvEspe);
            this.Controls.Add(this.mskCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.gpbOpciones);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombreE);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.MaximizeBox = false;
            this.Name = "frmEspecialidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Especialidades";
            this.Load += new System.EventHandler(this.frmEspecialidad_Load);
            this.gpbOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpbOpciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.MaskedTextBox mskCosto;
        private System.Windows.Forms.DataGridView dgvEspe;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPromocion;
        private System.Windows.Forms.ComboBox cmbPromocion;
    }
}