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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbOpciones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvEspecialidad = new System.Windows.Forms.DataGridView();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.mskCosto = new System.Windows.Forms.MaskedTextBox();
            this.mskDescuento = new System.Windows.Forms.MaskedTextBox();
            this.gpbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).BeginInit();
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
            this.txtNombre.Size = new System.Drawing.Size(153, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblID.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblID.Location = new System.Drawing.Point(12, 90);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(129, 24);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Id Especialidad: ";
            this.lblID.UseCompatibleTextRendering = true;
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblNombreE.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblNombreE.Location = new System.Drawing.Point(71, 150);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(75, 24);
            this.lblNombreE.TabIndex = 3;
            this.lblNombreE.Text = "Nombre: ";
            this.lblNombreE.UseCompatibleTextRendering = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lblTitulo.Location = new System.Drawing.Point(91, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 26);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Especialidades";
            // 
            // gpbOpciones
            // 
            this.gpbOpciones.Controls.Add(this.btnEliminar);
            this.gpbOpciones.Controls.Add(this.btnModificar);
            this.gpbOpciones.Controls.Add(this.btnAgregar);
            this.gpbOpciones.Location = new System.Drawing.Point(348, 59);
            this.gpbOpciones.Name = "gpbOpciones";
            this.gpbOpciones.Size = new System.Drawing.Size(205, 177);
            this.gpbOpciones.TabIndex = 5;
            this.gpbOpciones.TabStop = false;
            this.gpbOpciones.Text = "Opciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Location = new System.Drawing.Point(53, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 32);
            this.btnEliminar.TabIndex = 2;
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
            this.btnModificar.TabIndex = 1;
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
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvEspecialidad
            // 
            this.dgvEspecialidad.AllowUserToAddRows = false;
            this.dgvEspecialidad.AllowUserToDeleteRows = false;
            this.dgvEspecialidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEspecialidad.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("HP Simplified", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecialidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("HP Simplified", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEspecialidad.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEspecialidad.Location = new System.Drawing.Point(-4, 301);
            this.dgvEspecialidad.Name = "dgvEspecialidad";
            this.dgvEspecialidad.ReadOnly = true;
            this.dgvEspecialidad.RowTemplate.Height = 24;
            this.dgvEspecialidad.Size = new System.Drawing.Size(570, 192);
            this.dgvEspecialidad.TabIndex = 6;
            this.dgvEspecialidad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecialidad_CellDoubleClick);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblCosto.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblCosto.Location = new System.Drawing.Point(83, 204);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(58, 20);
            this.lblCosto.TabIndex = 7;
            this.lblCosto.Text = "Costo:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblDescuento.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblDescuento.Location = new System.Drawing.Point(46, 249);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(95, 20);
            this.lblDescuento.TabIndex = 8;
            this.lblDescuento.Text = "Descuento:";
            // 
            // mskCosto
            // 
            this.mskCosto.Location = new System.Drawing.Point(163, 204);
            this.mskCosto.Mask = "999.99";
            this.mskCosto.Name = "mskCosto";
            this.mskCosto.Size = new System.Drawing.Size(138, 22);
            this.mskCosto.TabIndex = 9;
            // 
            // mskDescuento
            // 
            this.mskDescuento.Location = new System.Drawing.Point(163, 249);
            this.mskDescuento.Mask = "099";
            this.mskDescuento.Name = "mskDescuento";
            this.mskDescuento.Size = new System.Drawing.Size(138, 22);
            this.mskDescuento.TabIndex = 10;
            this.mskDescuento.TextChanged += new System.EventHandler(this.mskDescuento_TextChanged);
            // 
            // frmEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(565, 493);
            this.Controls.Add(this.mskDescuento);
            this.Controls.Add(this.mskCosto);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.dgvEspecialidad);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvEspecialidad;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.MaskedTextBox mskCosto;
        private System.Windows.Forms.MaskedTextBox mskDescuento;
    }
}