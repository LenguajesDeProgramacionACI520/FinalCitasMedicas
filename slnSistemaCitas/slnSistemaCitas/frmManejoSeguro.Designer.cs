﻿namespace slnSistemaCitas
{
    partial class frmManejoSeguro
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
            this.lblPrct = new System.Windows.Forms.Label();
            this.mskDescuento = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCobertura = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvSeguro = new System.Windows.Forms.DataGridView();
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguro)).BeginInit();
            this.grbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrct
            // 
            this.lblPrct.AutoSize = true;
            this.lblPrct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblPrct.ForeColor = System.Drawing.Color.MintCream;
            this.lblPrct.Location = new System.Drawing.Point(260, 215);
            this.lblPrct.Name = "lblPrct";
            this.lblPrct.Size = new System.Drawing.Size(24, 20);
            this.lblPrct.TabIndex = 71;
            this.lblPrct.Text = "%";
            // 
            // mskDescuento
            // 
            this.mskDescuento.Location = new System.Drawing.Point(118, 212);
            this.mskDescuento.Mask = "999";
            this.mskDescuento.Name = "mskDescuento";
            this.mskDescuento.Size = new System.Drawing.Size(144, 22);
            this.mskDescuento.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(117, 110);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(85, 22);
            this.txtId.TabIndex = 0;
            // 
            // lblCobertura
            // 
            this.lblCobertura.AutoSize = true;
            this.lblCobertura.BackColor = System.Drawing.Color.Transparent;
            this.lblCobertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblCobertura.ForeColor = System.Drawing.Color.MintCream;
            this.lblCobertura.Location = new System.Drawing.Point(16, 212);
            this.lblCobertura.Name = "lblCobertura";
            this.lblCobertura.Size = new System.Drawing.Size(88, 20);
            this.lblCobertura.TabIndex = 70;
            this.lblCobertura.Text = "Cobertura:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblNombre.ForeColor = System.Drawing.Color.MintCream;
            this.lblNombre.Location = new System.Drawing.Point(38, 162);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 69;
            this.lblNombre.Text = "Nombre:";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lbl_Id.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_Id.Location = new System.Drawing.Point(84, 110);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(27, 20);
            this.lbl_Id.TabIndex = 68;
            this.lbl_Id.Text = "Id:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.lblTitulo.ForeColor = System.Drawing.Color.MintCream;
            this.lblTitulo.Location = new System.Drawing.Point(176, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 32);
            this.lblTitulo.TabIndex = 67;
            this.lblTitulo.Text = "Seguros de Vida";
            // 
            // dgvSeguro
            // 
            this.dgvSeguro.AllowUserToAddRows = false;
            this.dgvSeguro.AllowUserToDeleteRows = false;
            this.dgvSeguro.AllowUserToResizeColumns = false;
            this.dgvSeguro.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.dgvSeguro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSeguro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeguro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvSeguro.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvSeguro.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("HP Simplified", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeguro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSeguro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("HP Simplified", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeguro.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSeguro.Location = new System.Drawing.Point(24, 280);
            this.dgvSeguro.Name = "dgvSeguro";
            this.dgvSeguro.ReadOnly = true;
            this.dgvSeguro.RowTemplate.Height = 24;
            this.dgvSeguro.Size = new System.Drawing.Size(541, 230);
            this.dgvSeguro.TabIndex = 6;
            this.dgvSeguro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeguro_CellDoubleClick);
            // 
            // grbOpciones
            // 
            this.grbOpciones.BackColor = System.Drawing.Color.Transparent;
            this.grbOpciones.Controls.Add(this.btnEliminar);
            this.grbOpciones.Controls.Add(this.btnModificar);
            this.grbOpciones.Controls.Add(this.btnAgregar);
            this.grbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.grbOpciones.ForeColor = System.Drawing.Color.MintCream;
            this.grbOpciones.Location = new System.Drawing.Point(329, 81);
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
            this.txtNombre.Location = new System.Drawing.Point(117, 162);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // frmManejoSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(577, 536);
            this.Controls.Add(this.lblPrct);
            this.Controls.Add(this.mskDescuento);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblCobertura);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvSeguro);
            this.Controls.Add(this.grbOpciones);
            this.Controls.Add(this.txtNombre);
            this.MaximizeBox = false;
            this.Name = "frmManejoSeguro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Seguros";
            this.Load += new System.EventHandler(this.frmManejoSeguro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguro)).EndInit();
            this.grbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrct;
        private System.Windows.Forms.MaskedTextBox mskDescuento;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCobertura;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvSeguro;
        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
    }
}