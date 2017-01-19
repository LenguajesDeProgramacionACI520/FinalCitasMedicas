namespace slnSistemaCitas
{
    partial class frmPromociones
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
            this.lblValor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvPro = new System.Windows.Forms.DataGridView();
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mskDescuento = new System.Windows.Forms.MaskedTextBox();
            this.lblPrct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).BeginInit();
            this.grbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(132, 96);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(85, 22);
            this.txtId.TabIndex = 0;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblValor.ForeColor = System.Drawing.Color.MintCream;
            this.lblValor.Location = new System.Drawing.Point(31, 198);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(95, 20);
            this.lblValor.TabIndex = 60;
            this.lblValor.Text = "Descuento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblNombre.ForeColor = System.Drawing.Color.MintCream;
            this.lblNombre.Location = new System.Drawing.Point(53, 148);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 59;
            this.lblNombre.Text = "Nombre:";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lbl_Id.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_Id.Location = new System.Drawing.Point(99, 96);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(27, 20);
            this.lbl_Id.TabIndex = 58;
            this.lbl_Id.Text = "Id:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.lblTitulo.ForeColor = System.Drawing.Color.MintCream;
            this.lblTitulo.Location = new System.Drawing.Point(191, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(181, 32);
            this.lblTitulo.TabIndex = 57;
            this.lblTitulo.Text = "Promociones";
            // 
            // dgvPro
            // 
            this.dgvPro.AllowUserToAddRows = false;
            this.dgvPro.AllowUserToDeleteRows = false;
            this.dgvPro.AllowUserToResizeColumns = false;
            this.dgvPro.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.dgvPro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPro.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvPro.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("HP Simplified", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("HP Simplified", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPro.Location = new System.Drawing.Point(42, 261);
            this.dgvPro.Name = "dgvPro";
            this.dgvPro.ReadOnly = true;
            this.dgvPro.RowTemplate.Height = 24;
            this.dgvPro.Size = new System.Drawing.Size(541, 186);
            this.dgvPro.TabIndex = 6;
            this.dgvPro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHosp_CellDoubleClick);
            // 
            // grbOpciones
            // 
            this.grbOpciones.BackColor = System.Drawing.Color.Transparent;
            this.grbOpciones.Controls.Add(this.btnEliminar);
            this.grbOpciones.Controls.Add(this.btnModificar);
            this.grbOpciones.Controls.Add(this.btnAgregar);
            this.grbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.grbOpciones.ForeColor = System.Drawing.Color.MintCream;
            this.grbOpciones.Location = new System.Drawing.Point(347, 79);
            this.grbOpciones.Name = "grbOpciones";
            this.grbOpciones.Size = new System.Drawing.Size(226, 172);
            this.grbOpciones.TabIndex = 3;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Opciones";
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 148);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // mskDescuento
            // 
            this.mskDescuento.Location = new System.Drawing.Point(133, 198);
            this.mskDescuento.Mask = "999";
            this.mskDescuento.Name = "mskDescuento";
            this.mskDescuento.Size = new System.Drawing.Size(144, 22);
            this.mskDescuento.TabIndex = 2;
            // 
            // lblPrct
            // 
            this.lblPrct.AutoSize = true;
            this.lblPrct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblPrct.ForeColor = System.Drawing.Color.MintCream;
            this.lblPrct.Location = new System.Drawing.Point(275, 201);
            this.lblPrct.Name = "lblPrct";
            this.lblPrct.Size = new System.Drawing.Size(24, 20);
            this.lblPrct.TabIndex = 61;
            this.lblPrct.Text = "%";
            // 
            // frmPromociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(624, 472);
            this.Controls.Add(this.lblPrct);
            this.Controls.Add(this.mskDescuento);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvPro);
            this.Controls.Add(this.grbOpciones);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmPromociones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Promociones";
            this.Load += new System.EventHandler(this.frmPromociones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).EndInit();
            this.grbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvPro;
        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mskDescuento;
        private System.Windows.Forms.Label lblPrct;
    }
}