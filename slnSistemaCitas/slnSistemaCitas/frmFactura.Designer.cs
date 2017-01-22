namespace slnSistemaCitas
{
    partial class frmFactura
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
            this.lblNf = new System.Windows.Forms.Label();
            this.lblN_Cita = new System.Windows.Forms.Label();
            this.lblP_id = new System.Windows.Forms.Label();
            this.lblP_nom = new System.Windows.Forms.Label();
            this.lblP_ape = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblD_nom = new System.Windows.Forms.Label();
            this.lblD_ape = new System.Windows.Forms.Label();
            this.lblCita = new System.Windows.Forms.Label();
            this.lblD_especialidad = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblHospital = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblValoresPagar = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtValorCita = new System.Windows.Forms.TextBox();
            this.lblCostoCita = new System.Windows.Forms.Label();
            this.lblTotalDescuento = new System.Windows.Forms.Label();
            this.lblDescuentoSeguro = new System.Windows.Forms.Label();
            this.lblDescuentoPromocion = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblP_Seguro = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblcstCi = new System.Windows.Forms.Label();
            this.lblDpS = new System.Windows.Forms.Label();
            this.lblDpP = new System.Windows.Forms.Label();
            this.lblTd = new System.Windows.Forms.Label();
            this.lblSt = new System.Windows.Forms.Label();
            this.lblpI = new System.Windows.Forms.Label();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lblTp = new System.Windows.Forms.Label();
            this.lblN_Factura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnPa = new System.Windows.Forms.Label();
            this.lblsegP = new System.Windows.Forms.Label();
            this.lblnomP = new System.Windows.Forms.Label();
            this.lblapeP = new System.Windows.Forms.Label();
            this.lblnomD = new System.Windows.Forms.Label();
            this.lblapeD = new System.Windows.Forms.Label();
            this.lblespeD = new System.Windows.Forms.Label();
            this.lblnomH = new System.Windows.Forms.Label();
            this.lblFe = new System.Windows.Forms.Label();
            this.lblnomC = new System.Windows.Forms.Label();
            this.lblHo = new System.Windows.Forms.Label();
            this.grbValoresPAgar = new System.Windows.Forms.GroupBox();
            this.grbCitaMedica = new System.Windows.Forms.GroupBox();
            this.grbDoctor = new System.Windows.Forms.GroupBox();
            this.grbPaciente = new System.Windows.Forms.GroupBox();
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblVerificar = new System.Windows.Forms.Label();
            this.grbValoresPAgar.SuspendLayout();
            this.grbCitaMedica.SuspendLayout();
            this.grbDoctor.SuspendLayout();
            this.grbPaciente.SuspendLayout();
            this.grpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNf
            // 
            this.lblNf.AutoSize = true;
            this.lblNf.BackColor = System.Drawing.Color.Transparent;
            this.lblNf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblNf.Location = new System.Drawing.Point(12, 22);
            this.lblNf.Name = "lblNf";
            this.lblNf.Size = new System.Drawing.Size(113, 20);
            this.lblNf.TabIndex = 0;
            this.lblNf.Text = "N° de Factura";
            // 
            // lblN_Cita
            // 
            this.lblN_Cita.AutoSize = true;
            this.lblN_Cita.BackColor = System.Drawing.Color.Transparent;
            this.lblN_Cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblN_Cita.Location = new System.Drawing.Point(169, 61);
            this.lblN_Cita.Name = "lblN_Cita";
            this.lblN_Cita.Size = new System.Drawing.Size(45, 20);
            this.lblN_Cita.TabIndex = 1;
            this.lblN_Cita.Text = "0000";
            // 
            // lblP_id
            // 
            this.lblP_id.AutoSize = true;
            this.lblP_id.BackColor = System.Drawing.Color.Transparent;
            this.lblP_id.Location = new System.Drawing.Point(122, 56);
            this.lblP_id.Name = "lblP_id";
            this.lblP_id.Size = new System.Drawing.Size(80, 17);
            this.lblP_id.TabIndex = 2;
            this.lblP_id.Text = "000000000";
            this.lblP_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblP_nom
            // 
            this.lblP_nom.AutoSize = true;
            this.lblP_nom.BackColor = System.Drawing.Color.Transparent;
            this.lblP_nom.Location = new System.Drawing.Point(312, 56);
            this.lblP_nom.Name = "lblP_nom";
            this.lblP_nom.Size = new System.Drawing.Size(28, 17);
            this.lblP_nom.TabIndex = 3;
            this.lblP_nom.Text = "NN";
            this.lblP_nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblP_ape
            // 
            this.lblP_ape.AutoSize = true;
            this.lblP_ape.BackColor = System.Drawing.Color.Transparent;
            this.lblP_ape.Location = new System.Drawing.Point(579, 56);
            this.lblP_ape.Name = "lblP_ape";
            this.lblP_ape.Size = new System.Drawing.Size(28, 17);
            this.lblP_ape.TabIndex = 4;
            this.lblP_ape.Text = "NN";
            this.lblP_ape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(14, 18);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(71, 17);
            this.lblPaciente.TabIndex = 5;
            this.lblPaciente.Text = "Paciente";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(6, 18);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(56, 17);
            this.lblDoctor.TabIndex = 6;
            this.lblDoctor.Text = "Doctor";
            // 
            // lblD_nom
            // 
            this.lblD_nom.AutoSize = true;
            this.lblD_nom.BackColor = System.Drawing.Color.Transparent;
            this.lblD_nom.Location = new System.Drawing.Point(91, 43);
            this.lblD_nom.Name = "lblD_nom";
            this.lblD_nom.Size = new System.Drawing.Size(28, 17);
            this.lblD_nom.TabIndex = 7;
            this.lblD_nom.Text = "NN";
            this.lblD_nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblD_ape
            // 
            this.lblD_ape.AutoSize = true;
            this.lblD_ape.BackColor = System.Drawing.Color.Transparent;
            this.lblD_ape.Location = new System.Drawing.Point(298, 43);
            this.lblD_ape.Name = "lblD_ape";
            this.lblD_ape.Size = new System.Drawing.Size(28, 17);
            this.lblD_ape.TabIndex = 8;
            this.lblD_ape.Text = "NN";
            this.lblD_ape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCita
            // 
            this.lblCita.AutoSize = true;
            this.lblCita.BackColor = System.Drawing.Color.Transparent;
            this.lblCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCita.Location = new System.Drawing.Point(8, 18);
            this.lblCita.Name = "lblCita";
            this.lblCita.Size = new System.Drawing.Size(180, 17);
            this.lblCita.TabIndex = 9;
            this.lblCita.Text = "Datos de la Cita Médica";
            // 
            // lblD_especialidad
            // 
            this.lblD_especialidad.AutoSize = true;
            this.lblD_especialidad.BackColor = System.Drawing.Color.Transparent;
            this.lblD_especialidad.Location = new System.Drawing.Point(565, 44);
            this.lblD_especialidad.Name = "lblD_especialidad";
            this.lblD_especialidad.Size = new System.Drawing.Size(28, 17);
            this.lblD_especialidad.TabIndex = 10;
            this.lblD_especialidad.Text = "NN";
            this.lblD_especialidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.BackColor = System.Drawing.Color.Transparent;
            this.lblCiudad.Location = new System.Drawing.Point(100, 72);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(28, 17);
            this.lblCiudad.TabIndex = 11;
            this.lblCiudad.Text = "NN";
            this.lblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.BackColor = System.Drawing.Color.Transparent;
            this.lblHospital.Location = new System.Drawing.Point(99, 48);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(28, 17);
            this.lblHospital.TabIndex = 12;
            this.lblHospital.Text = "NN";
            this.lblHospital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Location = new System.Drawing.Point(99, 114);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 17);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "DD/MM/AAAA";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Location = new System.Drawing.Point(306, 114);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(54, 17);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "HH:MM";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(501, 45);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(225, 44);
            this.txtDireccion.TabIndex = 15;
            // 
            // lblValoresPagar
            // 
            this.lblValoresPagar.AutoSize = true;
            this.lblValoresPagar.BackColor = System.Drawing.Color.Transparent;
            this.lblValoresPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoresPagar.Location = new System.Drawing.Point(11, 18);
            this.lblValoresPagar.Name = "lblValoresPagar";
            this.lblValoresPagar.Size = new System.Drawing.Size(130, 17);
            this.lblValoresPagar.TabIndex = 16;
            this.lblValoresPagar.Text = "Valores a Pagar:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Location = new System.Drawing.Point(419, 48);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 17);
            this.lblDireccion.TabIndex = 17;
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.Transparent;
            this.lblCosto.Location = new System.Drawing.Point(386, 114);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(108, 17);
            this.lblCosto.TabIndex = 18;
            this.lblCosto.Text = "Valor de la Cita:";
            this.lblCosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValorCita
            // 
            this.txtValorCita.Enabled = false;
            this.txtValorCita.Location = new System.Drawing.Point(501, 111);
            this.txtValorCita.Name = "txtValorCita";
            this.txtValorCita.Size = new System.Drawing.Size(225, 22);
            this.txtValorCita.TabIndex = 19;
            // 
            // lblCostoCita
            // 
            this.lblCostoCita.AutoSize = true;
            this.lblCostoCita.BackColor = System.Drawing.Color.Transparent;
            this.lblCostoCita.Location = new System.Drawing.Point(274, 57);
            this.lblCostoCita.Name = "lblCostoCita";
            this.lblCostoCita.Size = new System.Drawing.Size(36, 17);
            this.lblCostoCita.TabIndex = 20;
            this.lblCostoCita.Text = "0,00";
            // 
            // lblTotalDescuento
            // 
            this.lblTotalDescuento.AutoSize = true;
            this.lblTotalDescuento.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDescuento.Location = new System.Drawing.Point(274, 148);
            this.lblTotalDescuento.Name = "lblTotalDescuento";
            this.lblTotalDescuento.Size = new System.Drawing.Size(36, 17);
            this.lblTotalDescuento.TabIndex = 21;
            this.lblTotalDescuento.Text = "0,00";
            // 
            // lblDescuentoSeguro
            // 
            this.lblDescuentoSeguro.AutoSize = true;
            this.lblDescuentoSeguro.BackColor = System.Drawing.Color.Transparent;
            this.lblDescuentoSeguro.Location = new System.Drawing.Point(290, 89);
            this.lblDescuentoSeguro.Name = "lblDescuentoSeguro";
            this.lblDescuentoSeguro.Size = new System.Drawing.Size(36, 17);
            this.lblDescuentoSeguro.TabIndex = 22;
            this.lblDescuentoSeguro.Text = "0,00";
            // 
            // lblDescuentoPromocion
            // 
            this.lblDescuentoPromocion.AutoSize = true;
            this.lblDescuentoPromocion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescuentoPromocion.Location = new System.Drawing.Point(290, 121);
            this.lblDescuentoPromocion.Name = "lblDescuentoPromocion";
            this.lblDescuentoPromocion.Size = new System.Drawing.Size(36, 17);
            this.lblDescuentoPromocion.TabIndex = 23;
            this.lblDescuentoPromocion.Text = "0,00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal.Location = new System.Drawing.Point(274, 174);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(36, 17);
            this.lblSubTotal.TabIndex = 24;
            this.lblSubTotal.Text = "0,00";
            // 
            // lblP_Seguro
            // 
            this.lblP_Seguro.AutoSize = true;
            this.lblP_Seguro.BackColor = System.Drawing.Color.Transparent;
            this.lblP_Seguro.Location = new System.Drawing.Point(122, 96);
            this.lblP_Seguro.Name = "lblP_Seguro";
            this.lblP_Seguro.Size = new System.Drawing.Size(94, 17);
            this.lblP_Seguro.TabIndex = 25;
            this.lblP_Seguro.Text = "SIN SEGURO";
            this.lblP_Seguro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(274, 240);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 17);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "0,00";
            // 
            // lblcstCi
            // 
            this.lblcstCi.AutoSize = true;
            this.lblcstCi.BackColor = System.Drawing.Color.Transparent;
            this.lblcstCi.Location = new System.Drawing.Point(25, 57);
            this.lblcstCi.Name = "lblcstCi";
            this.lblcstCi.Size = new System.Drawing.Size(125, 17);
            this.lblcstCi.TabIndex = 27;
            this.lblcstCi.Text = "Costo Cita Medica:";
            // 
            // lblDpS
            // 
            this.lblDpS.AutoSize = true;
            this.lblDpS.BackColor = System.Drawing.Color.Transparent;
            this.lblDpS.Location = new System.Drawing.Point(25, 89);
            this.lblDpS.Name = "lblDpS";
            this.lblDpS.Size = new System.Drawing.Size(155, 17);
            this.lblDpS.TabIndex = 28;
            this.lblDpS.Text = "Descuento por Seguro:";
            // 
            // lblDpP
            // 
            this.lblDpP.AutoSize = true;
            this.lblDpP.BackColor = System.Drawing.Color.Transparent;
            this.lblDpP.Location = new System.Drawing.Point(25, 121);
            this.lblDpP.Name = "lblDpP";
            this.lblDpP.Size = new System.Drawing.Size(172, 17);
            this.lblDpP.TabIndex = 29;
            this.lblDpP.Text = "Descuento por Promoción";
            // 
            // lblTd
            // 
            this.lblTd.AutoSize = true;
            this.lblTd.BackColor = System.Drawing.Color.Transparent;
            this.lblTd.Location = new System.Drawing.Point(25, 148);
            this.lblTd.Name = "lblTd";
            this.lblTd.Size = new System.Drawing.Size(116, 17);
            this.lblTd.TabIndex = 30;
            this.lblTd.Text = "Total Descuento:";
            // 
            // lblSt
            // 
            this.lblSt.AutoSize = true;
            this.lblSt.BackColor = System.Drawing.Color.Transparent;
            this.lblSt.Location = new System.Drawing.Point(25, 174);
            this.lblSt.Name = "lblSt";
            this.lblSt.Size = new System.Drawing.Size(69, 17);
            this.lblSt.TabIndex = 31;
            this.lblSt.Text = "SubTotal:";
            // 
            // lblpI
            // 
            this.lblpI.AutoSize = true;
            this.lblpI.BackColor = System.Drawing.Color.Transparent;
            this.lblpI.Location = new System.Drawing.Point(25, 201);
            this.lblpI.Name = "lblpI";
            this.lblpI.Size = new System.Drawing.Size(72, 17);
            this.lblpI.TabIndex = 32;
            this.lblpI.Text = "Iva (14%):";
            // 
            // lbl_iva
            // 
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.BackColor = System.Drawing.Color.Transparent;
            this.lbl_iva.Location = new System.Drawing.Point(274, 201);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(36, 17);
            this.lbl_iva.TabIndex = 33;
            this.lbl_iva.Text = "0,00";
            // 
            // lblTp
            // 
            this.lblTp.AutoSize = true;
            this.lblTp.BackColor = System.Drawing.Color.Transparent;
            this.lblTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTp.Location = new System.Drawing.Point(25, 240);
            this.lblTp.Name = "lblTp";
            this.lblTp.Size = new System.Drawing.Size(50, 17);
            this.lblTp.TabIndex = 34;
            this.lblTp.Text = "Total:";
            // 
            // lblN_Factura
            // 
            this.lblN_Factura.AutoSize = true;
            this.lblN_Factura.BackColor = System.Drawing.Color.Transparent;
            this.lblN_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblN_Factura.ForeColor = System.Drawing.Color.Red;
            this.lblN_Factura.Location = new System.Drawing.Point(167, 22);
            this.lblN_Factura.Name = "lblN_Factura";
            this.lblN_Factura.Size = new System.Drawing.Size(45, 20);
            this.lblN_Factura.TabIndex = 35;
            this.lblN_Factura.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "N° de Consulta:";
            // 
            // lblnPa
            // 
            this.lblnPa.AutoSize = true;
            this.lblnPa.Location = new System.Drawing.Point(43, 56);
            this.lblnPa.Name = "lblnPa";
            this.lblnPa.Size = new System.Drawing.Size(56, 17);
            this.lblnPa.TabIndex = 37;
            this.lblnPa.Text = "Cedula:";
            this.lblnPa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsegP
            // 
            this.lblsegP.AutoSize = true;
            this.lblsegP.Location = new System.Drawing.Point(43, 96);
            this.lblsegP.Name = "lblsegP";
            this.lblsegP.Size = new System.Drawing.Size(58, 17);
            this.lblsegP.TabIndex = 38;
            this.lblsegP.Text = "Seguro:";
            this.lblsegP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnomP
            // 
            this.lblnomP.AutoSize = true;
            this.lblnomP.Location = new System.Drawing.Point(237, 56);
            this.lblnomP.Name = "lblnomP";
            this.lblnomP.Size = new System.Drawing.Size(69, 17);
            this.lblnomP.TabIndex = 39;
            this.lblnomP.Text = "Nombres:";
            this.lblnomP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblapeP
            // 
            this.lblapeP.AutoSize = true;
            this.lblapeP.Location = new System.Drawing.Point(504, 56);
            this.lblapeP.Name = "lblapeP";
            this.lblapeP.Size = new System.Drawing.Size(69, 17);
            this.lblapeP.TabIndex = 40;
            this.lblapeP.Text = "Apellidos:";
            this.lblapeP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnomD
            // 
            this.lblnomD.AutoSize = true;
            this.lblnomD.Location = new System.Drawing.Point(23, 44);
            this.lblnomD.Name = "lblnomD";
            this.lblnomD.Size = new System.Drawing.Size(62, 17);
            this.lblnomD.TabIndex = 41;
            this.lblnomD.Text = "Nombre:";
            this.lblnomD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblapeD
            // 
            this.lblapeD.AutoSize = true;
            this.lblapeD.Location = new System.Drawing.Point(230, 43);
            this.lblapeD.Name = "lblapeD";
            this.lblapeD.Size = new System.Drawing.Size(62, 17);
            this.lblapeD.TabIndex = 42;
            this.lblapeD.Text = "Apellido:";
            this.lblapeD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblespeD
            // 
            this.lblespeD.AutoSize = true;
            this.lblespeD.Location = new System.Drawing.Point(467, 43);
            this.lblespeD.Name = "lblespeD";
            this.lblespeD.Size = new System.Drawing.Size(92, 17);
            this.lblespeD.TabIndex = 43;
            this.lblespeD.Text = "Especialidad:";
            this.lblespeD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnomH
            // 
            this.lblnomH.AutoSize = true;
            this.lblnomH.Location = new System.Drawing.Point(33, 48);
            this.lblnomH.Name = "lblnomH";
            this.lblnomH.Size = new System.Drawing.Size(63, 17);
            this.lblnomH.TabIndex = 44;
            this.lblnomH.Text = "Hospital:";
            this.lblnomH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFe
            // 
            this.lblFe.AutoSize = true;
            this.lblFe.Location = new System.Drawing.Point(37, 114);
            this.lblFe.Name = "lblFe";
            this.lblFe.Size = new System.Drawing.Size(51, 17);
            this.lblFe.TabIndex = 45;
            this.lblFe.Text = "Fecha:";
            this.lblFe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnomC
            // 
            this.lblnomC.AutoSize = true;
            this.lblnomC.Location = new System.Drawing.Point(39, 72);
            this.lblnomC.Name = "lblnomC";
            this.lblnomC.Size = new System.Drawing.Size(56, 17);
            this.lblnomC.TabIndex = 46;
            this.lblnomC.Text = "Ciudad:";
            this.lblnomC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(257, 114);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(43, 17);
            this.lblHo.TabIndex = 47;
            this.lblHo.Text = "Hora:";
            this.lblHo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbValoresPAgar
            // 
            this.grbValoresPAgar.AutoSize = true;
            this.grbValoresPAgar.BackColor = System.Drawing.Color.Transparent;
            this.grbValoresPAgar.Controls.Add(this.lblcstCi);
            this.grbValoresPAgar.Controls.Add(this.lblCostoCita);
            this.grbValoresPAgar.Controls.Add(this.lblTotalDescuento);
            this.grbValoresPAgar.Controls.Add(this.lblDescuentoSeguro);
            this.grbValoresPAgar.Controls.Add(this.lblDescuentoPromocion);
            this.grbValoresPAgar.Controls.Add(this.lblSubTotal);
            this.grbValoresPAgar.Controls.Add(this.lblTotal);
            this.grbValoresPAgar.Controls.Add(this.lblDpS);
            this.grbValoresPAgar.Controls.Add(this.lblDpP);
            this.grbValoresPAgar.Controls.Add(this.lblTd);
            this.grbValoresPAgar.Controls.Add(this.lblSt);
            this.grbValoresPAgar.Controls.Add(this.lblpI);
            this.grbValoresPAgar.Controls.Add(this.lbl_iva);
            this.grbValoresPAgar.Controls.Add(this.lblTp);
            this.grbValoresPAgar.Controls.Add(this.lblValoresPagar);
            this.grbValoresPAgar.Location = new System.Drawing.Point(12, 478);
            this.grbValoresPAgar.Name = "grbValoresPAgar";
            this.grbValoresPAgar.Size = new System.Drawing.Size(394, 275);
            this.grbValoresPAgar.TabIndex = 48;
            this.grbValoresPAgar.TabStop = false;
            // 
            // grbCitaMedica
            // 
            this.grbCitaMedica.AutoSize = true;
            this.grbCitaMedica.BackColor = System.Drawing.Color.Transparent;
            this.grbCitaMedica.Controls.Add(this.lblCita);
            this.grbCitaMedica.Controls.Add(this.lblCiudad);
            this.grbCitaMedica.Controls.Add(this.lblHo);
            this.grbCitaMedica.Controls.Add(this.lblHospital);
            this.grbCitaMedica.Controls.Add(this.lblnomC);
            this.grbCitaMedica.Controls.Add(this.lblFecha);
            this.grbCitaMedica.Controls.Add(this.lblFe);
            this.grbCitaMedica.Controls.Add(this.lblHora);
            this.grbCitaMedica.Controls.Add(this.lblnomH);
            this.grbCitaMedica.Controls.Add(this.txtDireccion);
            this.grbCitaMedica.Controls.Add(this.lblDireccion);
            this.grbCitaMedica.Controls.Add(this.lblCosto);
            this.grbCitaMedica.Controls.Add(this.txtValorCita);
            this.grbCitaMedica.Location = new System.Drawing.Point(12, 316);
            this.grbCitaMedica.Name = "grbCitaMedica";
            this.grbCitaMedica.Size = new System.Drawing.Size(743, 154);
            this.grbCitaMedica.TabIndex = 49;
            this.grbCitaMedica.TabStop = false;
            // 
            // grbDoctor
            // 
            this.grbDoctor.AutoSize = true;
            this.grbDoctor.BackColor = System.Drawing.Color.Transparent;
            this.grbDoctor.Controls.Add(this.lblnomD);
            this.grbDoctor.Controls.Add(this.lblD_nom);
            this.grbDoctor.Controls.Add(this.lblD_ape);
            this.grbDoctor.Controls.Add(this.lblespeD);
            this.grbDoctor.Controls.Add(this.lblD_especialidad);
            this.grbDoctor.Controls.Add(this.lblapeD);
            this.grbDoctor.Controls.Add(this.lblDoctor);
            this.grbDoctor.Location = new System.Drawing.Point(12, 235);
            this.grbDoctor.Name = "grbDoctor";
            this.grbDoctor.Size = new System.Drawing.Size(743, 79);
            this.grbDoctor.TabIndex = 50;
            this.grbDoctor.TabStop = false;
            // 
            // grbPaciente
            // 
            this.grbPaciente.AutoSize = true;
            this.grbPaciente.BackColor = System.Drawing.Color.Transparent;
            this.grbPaciente.Controls.Add(this.lblPaciente);
            this.grbPaciente.Controls.Add(this.lblP_id);
            this.grbPaciente.Controls.Add(this.lblP_nom);
            this.grbPaciente.Controls.Add(this.lblapeP);
            this.grbPaciente.Controls.Add(this.lblP_ape);
            this.grbPaciente.Controls.Add(this.lblnomP);
            this.grbPaciente.Controls.Add(this.lblP_Seguro);
            this.grbPaciente.Controls.Add(this.lblsegP);
            this.grbPaciente.Controls.Add(this.lblnPa);
            this.grbPaciente.Location = new System.Drawing.Point(12, 88);
            this.grbPaciente.Name = "grbPaciente";
            this.grbPaciente.Size = new System.Drawing.Size(743, 141);
            this.grbPaciente.TabIndex = 51;
            this.grbPaciente.TabStop = false;
            // 
            // grpOpciones
            // 
            this.grpOpciones.AutoSize = true;
            this.grpOpciones.BackColor = System.Drawing.Color.Transparent;
            this.grpOpciones.Controls.Add(this.btnAceptar);
            this.grpOpciones.Controls.Add(this.btnCancelar);
            this.grpOpciones.Location = new System.Drawing.Point(468, 535);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(234, 212);
            this.grpOpciones.TabIndex = 52;
            this.grpOpciones.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnCancelar.Location = new System.Drawing.Point(42, 45);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(151, 49);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnAceptar.Location = new System.Drawing.Point(42, 128);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(151, 49);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblVerificar
            // 
            this.lblVerificar.AutoSize = true;
            this.lblVerificar.BackColor = System.Drawing.Color.Transparent;
            this.lblVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificar.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblVerificar.Location = new System.Drawing.Point(365, 35);
            this.lblVerificar.Name = "lblVerificar";
            this.lblVerificar.Size = new System.Drawing.Size(296, 32);
            this.lblVerificar.TabIndex = 53;
            this.lblVerificar.Text = "Verificar Información";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::slnSistemaCitas.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(771, 772);
            this.ControlBox = false;
            this.Controls.Add(this.lblVerificar);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.grbPaciente);
            this.Controls.Add(this.grbDoctor);
            this.Controls.Add(this.grbCitaMedica);
            this.Controls.Add(this.grbValoresPAgar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblN_Factura);
            this.Controls.Add(this.lblN_Cita);
            this.Controls.Add(this.lblNf);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.grbValoresPAgar.ResumeLayout(false);
            this.grbValoresPAgar.PerformLayout();
            this.grbCitaMedica.ResumeLayout(false);
            this.grbCitaMedica.PerformLayout();
            this.grbDoctor.ResumeLayout(false);
            this.grbDoctor.PerformLayout();
            this.grbPaciente.ResumeLayout(false);
            this.grbPaciente.PerformLayout();
            this.grpOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNf;
        private System.Windows.Forms.Label lblN_Cita;
        private System.Windows.Forms.Label lblP_id;
        private System.Windows.Forms.Label lblP_nom;
        private System.Windows.Forms.Label lblP_ape;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblD_nom;
        private System.Windows.Forms.Label lblD_ape;
        private System.Windows.Forms.Label lblCita;
        private System.Windows.Forms.Label lblD_especialidad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblValoresPagar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtValorCita;
        private System.Windows.Forms.Label lblCostoCita;
        private System.Windows.Forms.Label lblTotalDescuento;
        private System.Windows.Forms.Label lblDescuentoSeguro;
        private System.Windows.Forms.Label lblDescuentoPromocion;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblP_Seguro;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblcstCi;
        private System.Windows.Forms.Label lblDpS;
        private System.Windows.Forms.Label lblDpP;
        private System.Windows.Forms.Label lblTd;
        private System.Windows.Forms.Label lblSt;
        private System.Windows.Forms.Label lblpI;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Label lblTp;
        private System.Windows.Forms.Label lblN_Factura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnPa;
        private System.Windows.Forms.Label lblsegP;
        private System.Windows.Forms.Label lblnomP;
        private System.Windows.Forms.Label lblapeP;
        private System.Windows.Forms.Label lblnomD;
        private System.Windows.Forms.Label lblapeD;
        private System.Windows.Forms.Label lblespeD;
        private System.Windows.Forms.Label lblnomH;
        private System.Windows.Forms.Label lblFe;
        private System.Windows.Forms.Label lblnomC;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.GroupBox grbValoresPAgar;
        private System.Windows.Forms.GroupBox grbCitaMedica;
        private System.Windows.Forms.GroupBox grbDoctor;
        private System.Windows.Forms.GroupBox grbPaciente;
        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblVerificar;
    }
}