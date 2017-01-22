﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace slnSistemaCitas
{
    public partial class frmFactura : Form
    {
        clsN_Factura objN_Factura = new clsN_Factura();
        clsN_ConsultaMedica objN_ConsultaMedica = new clsN_ConsultaMedica();
        clsN_Usuario objN_Usuario = new clsN_Usuario();
        clsN_Doctores objN_Doctor = new clsN_Doctores();
        clsN_Hospital objN_Hospital = new clsN_Hospital();
        clsN_Especialidad objN_Especialidad = new clsN_Especialidad();
        clsN_Ciudad objN_Ciudad = new clsN_Ciudad();
        clsN_Seguro objN_Seguro = new clsN_Seguro();
        clsN_Hora objN_Hora = new clsN_Hora();
        public bool factura { get; set; }
        public int idFactura { get; set; }
        public int idCita { get; set; }
        public int idHos { get; set; }
        public int idEsp { get; set; }
        public int idUsuario { get; set; }
        public int idHora { get; set; }
        public int idDoctor { get; set; }
        public int idPromo { get; set; }
        public decimal porcenSeguro { get; set; }
        public decimal porcenEspecialidad { get; set; }
        public decimal valorCita { get; set; }


        public DataSet ds = new DataSet();
        public frmFactura(int idCita)
        {
            InitializeComponent();
            factura = true;
            this.idCita = idCita;
        }

        public void obtenerIdFactura()
        {
            try
            {
                ds = objN_Factura.obtenerId();
                if (ds == null)
                    idFactura = 1;
                else {
                    idFactura = int.Parse(ds.Tables[0].Rows[0][0].ToString()) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el N° de factura" + ex.Message, "Er062",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarIdFactura()
        {
            obtenerIdFactura();
            lblN_Factura.Text = idFactura.ToString();
        }

        public void cargarCita()
        {
            lblN_Cita.Text = idCita.ToString();
            try
            {
                ds = objN_ConsultaMedica.consultaCita(idCita);
                idUsuario = int.Parse(ds.Tables["TblCita"].Rows[0]["idUsuario"].ToString());
                idDoctor = int.Parse(ds.Tables["TblCita"].Rows[0]["idDoctor"].ToString());
                lblFecha.Text = ds.Tables["TblCita"].Rows[0]["fechaCita"].ToString();
                idHora = int.Parse(ds.Tables["TblCita"].Rows[0]["idHora"].ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar el datos de la Cita" + ex.Message, "Er063",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarPaciente()
        {
            try
            {
                ds = objN_Usuario.consultaUsurio(idUsuario);
                lblP_nom.Text = ds.Tables["TblUsuario"].Rows[0]["nom_pUsuario"].ToString() + " " +
                    ds.Tables["TblUsuario"].Rows[0]["nom_sUsuario"].ToString();
                lblP_ape.Text = ds.Tables["TblUsuario"].Rows[0]["ape_pUsuario"].ToString() + " " +
                    ds.Tables["TblUsuario"].Rows[0]["ape_sUsuario"].ToString();
                lblP_id.Text = idUsuario.ToString();
                cargarSeguro(int.Parse(ds.Tables["TblUsuario"].Rows[0]["idSeguro"].ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información del Paciente" + ex.Message, "Er064",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarSeguro(int idSeguro)
        {
            try
            {
                ds = objN_Seguro.consultaSeguro(idSeguro);
                lblP_Seguro.Text = ds.Tables["TblSeguro"].Rows[0]["nomSeguro"].ToString();
                porcenSeguro = decimal.Parse(ds.Tables["TblSeguro"].Rows[0]["porcenSeguro"].ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar la información del Seguro del Paciente" + ex.Message, "Er065",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarDoctor()
        {
            try
            {
                ds = objN_Doctor.consultaDoctores(idDoctor);
                idEsp = int.Parse(ds.Tables["TblDoctor"].Rows[0]["idEspecialidad"].ToString());
                idHos = int.Parse(ds.Tables["TblDoctor"].Rows[0]["idHospital"].ToString());
                lblD_nom.Text = ds.Tables["TblDoctor"].Rows[0]["nomDoctor"].ToString();
                lblD_ape.Text = ds.Tables["TblDoctor"].Rows[0]["apeDoctor"].ToString();
                cargarEspecialidad();
                cargarHospital();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del Doctor" + ex.Message, "Er066",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarEspecialidad()
        {
            try
            {
                ds = objN_Especialidad.consultaEspecialidad(idEsp);
                lblD_especialidad.Text = ds.Tables["TblEspecialidad"].Rows[0]["nomEspecialidad"].ToString();
                valorCita = decimal.Parse(ds.Tables["TblEspecialidad"].Rows[0]["costoEspecialidad"].ToString());
                txtValorCita.Text = valorCita.ToString();
                idPromo = int.Parse(ds.Tables["TblEspecialidad"].Rows[0]["idPromocion"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la especialidad del Doctor" + ex.Message, "Er067",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarHospital()
        {
            try
            {
                ds = objN_Hospital.consultaHospitales(idHos);
                lblHospital.Text = ds.Tables["TblHospital"].Rows[0]["nomHospital"].ToString();
                int idCiudad = int.Parse(ds.Tables["TblHospital"].Rows[0]["idCiudad"].ToString());
                txtDireccion.Text = ds.Tables["TblHospital"].Rows[0]["dirHospital"].ToString();
                cargarCiudad(idCiudad);
                cargarHora();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el Hospital del Doctor" + ex.Message, "Er068",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarCiudad(int idCiu)
        {            
            try
            {
                int idCiudad = idCiu;
                ds = objN_Ciudad.consultaCiudad(idCiudad);
                lblCiudad.Text = ds.Tables["TblCiudad"].Rows[0]["nomCiudad"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ciudad del Hospital" + ex.Message, "Er069",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarHora()
        {
            try
            {
                ds = objN_Hora.consultaHora(idHora);
                lblCiudad.Text = ds.Tables["TblHora"].Rows[0]["hora"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la hora de la Cita" + ex.Message, "Er070",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarPromEspecialidad()
        {
            try
            {
                ds = objN_Especialidad.consultaEspecialidad(idEsp);
                lblD_especialidad.Text = ds.Tables["TblPromocion"].Rows[0]["nomPromocion"].ToString();
                porcenEspecialidad = decimal.Parse(ds.Tables["TblPromocion"].Rows[0]["descuPromocion"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la promocion de la especialidad" + ex.Message, "Er072",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        { 

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCita = objN_ConsultaMedica.consultaId();
                objN_ConsultaMedica.eliminarCita(idCita);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al elminar la cita" + ex.Message, "Er061",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }
    }
}
