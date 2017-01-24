using System;
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
    public partial class frmConsultaMedia : Form
    {
        clsN_ConsultaMedica objN_ConsultaMedica = new clsN_ConsultaMedica();
        clsN_Ciudad objN_Ciudad = new clsN_Ciudad();
        clsN_Especialidad objN_Especialidad = new clsN_Especialidad();
        clsN_Doctores objN_Doctor = new clsN_Doctores();
        clsN_Hospital objN_Hospital = new clsN_Hospital();
        clsN_Hora objN_Hora = new clsN_Hora();
        DataSet ds = new DataSet();
        public string idUser { get; set; }
        public int idCita { get; set; }
        public int bandera { get; set; }
        public int banderaH { get; set; }
        
        public frmConsultaMedia(string idUsuario)
        {
            InitializeComponent();
            if (bandera == 0)
            {
                cargar();
            }
            bandera = 1;
            idUser = idUsuario;
        }        

        public void cargar()
        {
            lstEspecialidad.Enabled = true;
            cmbCiudad.Enabled = false;
            lstHospital.Enabled = false;
            dtpFechaCita.Enabled = false;
            cmbHora.Enabled = false;
            dgvDoctor.Enabled = false;
            btnIngresar.Enabled = false;
            dtpFechaCita.MinDate = DateTime.Today;
            dtpFechaCita.MaxDate = DateTime.Today.AddMonths(3);
            cargarEspecialidad();

        }

        public void cargarEspecialidad()
        {
            try
            {
                ds = objN_Especialidad.consultaEspecialidad();
                lstEspecialidad.DataSource = ds.Tables["TblEspecialidad"];
                lstEspecialidad.ValueMember = "idEspecialidad";
                lstEspecialidad.DisplayMember = "nomEspecialidad";
                cargarCiudad();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problemas al cargar las Espcialidades" +
                    "\n" + ex.Message, "Er055",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarCiudad()
        {
            try
            {
                ds = objN_Ciudad.consultaCiudad();
                cmbCiudad.DataSource = ds.Tables["TblCiudad"];
                cmbCiudad.ValueMember = "idCiudad";
                cmbCiudad.DisplayMember = "nomCiudad";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problemas al cargar las Ciudades" +
                    "\n" + ex.Message, "Er056",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarHospital(int ciudad)
        {
            try
            {
                ds = objN_Hospital.consultaHospitalesCiudad(ciudad);
                if (ds == null)
                    lstEspecialidad.Items.Insert(0,"No Disponible");
                else
                {
                    lstHospital.DataSource = ds.Tables["tblHospital"];
                    lstHospital.ValueMember = "idHospital";
                    lstHospital.DisplayMember = "nomHospital";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problemas al cargar los Hospitales" +
                    "\n" + ex.Message, "Er057",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarHora()
        {
            if (banderaH == 0)
            {
                try
                {
                    ds = objN_Hora.consultaHoraAc();
                    cmbHora.DataSource = ds.Tables["TblHora"];
                    cmbHora.ValueMember = "idHora";
                    cmbHora.DisplayMember = "hora";
                    habilitarHoras();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas al cargar Horario" +
                        "\n" + ex.Message, "Er058",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            banderaH = 1;
        }

        public void habilitarHoras()
        {
            int hora = DateTime.Today.Hour;
            int j = 0;
            if (hora > 7 && hora < 8)
            {
                j = 1;
                for(int i=0; i<j; i++)
                {
                    cmbHora.Items.RemoveAt(i);
                }
            }if (hora > 8 && hora < 9)
            {
                j = 2;
                for (int i = 0; i < j; i++)
                {
                    cmbHora.Items.RemoveAt(i);
                }
            }if (hora > 9 && hora < 10)
            {
                j = 3;
                for (int i = 0; i < j; i++)
                {
                    cmbHora.Items.RemoveAt(i);
                }
            }
            if (hora > 10 && hora < 11)
            {
                j = 4;
                for (int i = 0; i < j; i++)
                {
                    cmbHora.Items.RemoveAt(i);
                }
            }if(hora > 11 && hora < 12)
            {
                j = 5;
                for (int i = 0; i < j; i++)
                {
                    cmbHora.Items.RemoveAt(i);
                }
            }
            if (hora > 12 && hora < 13)
            {
                j = 6;
                for (int i = 0; i < j; i++)
                {
                    cmbHora.Items.RemoveAt(i);
                }
            }
            if (hora > 13 && hora < 14)
            {
                j = 7;
                for (int i = 0; i < j; i++)
                {
                    cmbHora.Items.RemoveAt(i);
                }
            }
            if (hora > 14 && hora < 15)
            {
                j = 8;
                for (int i = 0; i < j; i++)
                {
                    cmbHora.Items.RemoveAt(i);
                }
            }
            if (hora > 15 && hora < 16)
            {
                j = 9;
                for (int i = 0; i < j; i++)
                {
                    cmbHora.Items.RemoveAt(i);
                }
            }
            if (hora > 16 && hora < 17)
            {
                j = 10;
                for (int i = 0; i < j; i++)
                {
                    cmbHora.Items.RemoveAt(i);
                }
            }
            if (hora > 17 && hora < 18)
            {
                j = 11;
                for (int i = 0; i < j; i++)
                {
                    cmbHora.Items.RemoveAt(i);
                }
            }
            if (hora > 18)
            {
                j = 12;
                for (int i = 0; i < j; i++)
                {
                    cmbHora.Items.RemoveAt(i);
                }
                MessageBox.Show("No se pueden elegir mas citas el: " + DateTime.Today.Date + ""
                             , "Seleccione otra Día", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void cargarDoctor()
        {
            try
            {
                int esp = int.Parse(lstEspecialidad.SelectedValue.ToString());
                int hosp = int.Parse(lstHospital.SelectedValue.ToString());
                DateTime fecha = dtpFechaCita.Value.Date;
                int hora = int.Parse(cmbHora.SelectedValue.ToString());
                var doctores = objN_Doctor.consultaDocHora(esp,hosp,fecha,hora);
                dgvDoctor.DataSource = doctores;
            }catch (Exception ex)
            {
                MessageBox.Show("Problemas al cargar los Doctores" +
                    "\n" + ex.Message, "Er059",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void especialidad()
        {
            cmbCiudad.Enabled = true;
            lstHospital.Enabled = false;
            dtpFechaCita.Enabled = false;
            cmbHora.Enabled = false;
            dgvDoctor.Enabled = false;
            btnIngresar.Enabled = false;

        }

        public void ciudad()
        {
            lstHospital.Enabled = true;
            dtpFechaCita.Enabled = false;
            cmbHora.Enabled = false;
            dgvDoctor.Enabled = false;
            btnIngresar.Enabled = false;
        }

        public void hospital()
        {
            dtpFechaCita.Enabled = true;
            cmbHora.Enabled = false;
            dgvDoctor.Enabled = false;
            btnIngresar.Enabled = false;
        }

        public void fecha()
        {
            cmbHora.Enabled = true;
            dgvDoctor.Enabled = false;
            btnIngresar.Enabled = false;
        }

        public void doctor()
        {
            dgvDoctor.Enabled = true;
            btnIngresar.Enabled = false;
        }

        public void ingresar()
        {
            btnIngresar.Enabled = true;
        }

        private void lstEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCiudad();
            especialidad();
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bandera != 0)
            {
                int idCiudad = int.Parse(cmbCiudad.SelectedValue.ToString());
                cargarHospital(idCiudad);
                ciudad();
            }
        }

        private void lstHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            hospital();
        }

        private void mtcFecha_DateSelected(object sender, DateRangeEventArgs e)
        {           
        }
        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (banderaH != 0)
            {
                cargarDoctor();
                doctor();
            }
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DateTime fechaCita = dtpFechaCita.Value.Date;
            int idHora = int.Parse(cmbHora.SelectedValue.ToString());
            string idDoctor = (string)dgvDoctor.CurrentRow.Cells["Cedula"].Value;
            int idEspecialidad = int.Parse(lstEspecialidad.SelectedValue.ToString());
            int idCiudad = int.Parse(cmbCiudad.SelectedValue.ToString());
            int idHospital = int.Parse(lstHospital.SelectedValue.ToString());
            Console.WriteLine("Esp:" + idEspecialidad+ " Hos" + idHospital + " Fecha" + fechaCita + " Hora: " + idHora + " Doctor:"+idDoctor
                +" Usuario:" +idUser);
            try
            {
                obteneridCita();       
                if(objN_ConsultaMedica.agregarCita(idUser,idDoctor,fechaCita,idHora,"AC"))
                {
                    frmFactura factura = new frmFactura(idCita, this);
                    factura.ShowDialog();                   
                }
                else
                {
                    cargar();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ingresar la cita" + ex.Message, "Er060",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

        }

        private void obteneridCita()
        {
            try
            {
                ds = objN_ConsultaMedica.consultaId();
                int id = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                idCita = id + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror al obtener un nuevo id\n" + ex.Message, "Er014",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            cargarHora();
            fecha();
        }

        private void dgvDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ingresar();
        }
    }
}
