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
    public partial class frmDoctorHorario : Form
    {
        DataSet ds = new DataSet();
        clsN_Hora objN_Hora = new clsN_Hora();
        clsN_Doctores objN_Doctor = new clsN_Doctores();
        clsN_DoctorHorario objN_DoctorHorario = new clsN_DoctorHorario();


        public frmDoctorHorario()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

        private void frmDoctorHorario_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            cargarId();
            cargarHorario();
            cargarDoctores();
            cargarDgv();
        }

        public void cargarId()
        {
            try
            {
                ds = objN_DoctorHorario.consultaId();
                if (ds.Tables[0].Rows[0][0] != null)
                {
                    int id = (int)ds.Tables[0].Rows[0][0];
                    id = id + 1;
                    txtId.Text = id.ToString();
                }
                else
                {
                    txtId.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror al obtener un nuevo id\n" + ex.Message, "Er014",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarHorario()
        {
            try
            {
                ds = objN_Hora.consultaHoraAc();
                cmbHorario.DataSource = ds.Tables["TblHora"];
                cmbHorario.ValueMember = "idHora";
                cmbHorario.DisplayMember = "hora";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problemas al cargar Horario" +
                    "\n" + ex.Message, "Er058",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarDoctores()
        {
            try
            {
                ds = objN_Doctor.consultaDoctores();
                cmbDoctor.DataSource = ds.Tables["TblDoctor"];
                cmbDoctor.ValueMember = "idCedula";
                cmbDoctor.DisplayMember = "nomDoctor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al cargar los Doctores" +
                    "\n" + ex.Message, "Er059",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarDgv()
        {
            try
            {
                ds = objN_DoctorHorario.consultaRelacion();
                dgvDoctorHorario.DataSource = ds;
                dgvDoctorHorario.DataMember = "TblDoctorHora";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al recuperar la informacion de los Doctores y Los horarios" + ex.Message, "Er077",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void formatoAgregar()
        {
            btnAgregar.Enabled = true;
            cmbDoctor.Enabled = true;
            cmbHorario.Enabled = true;
            btnEliminar.Enabled = false;
        }

        public void formatoEliminar()
        {
            btnAgregar.Enabled = false;
            cmbDoctor.Enabled = false;
            cmbHorario.Enabled = false;
            btnEliminar.Enabled = true;

        }

        public void comprobarRelacion()
        {
            int hora = int.Parse(cmbHorario.SelectedValue.ToString());
            string doctor = cmbDoctor.SelectedValue.ToString();
            Console.WriteLine("Cedula Doctor: " + doctor);
            if(objN_DoctorHorario.comprobarRelacion(hora, doctor))
            {
                try
                {
                    if(objN_DoctorHorario.agregar(hora,doctor))
                        MessageBox.Show("Se asigno al Doctor: " + cmbDoctor.SelectedText + "el Horario de: " +
                    cmbHorario.SelectedText + "\n", "Nuevo Horario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al vincular el Doctor con el Horario \n" + ex.Message, "Er077",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    cargar();
                }
            }
            else
            {
                MessageBox.Show("El Doctor: "+cmbDoctor.SelectedText +"Ya tiene asignado el Horario de: " +
                    cmbHorario.SelectedText +"\n", "Er076",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void eliminar()
        {
            try
            {
                int idHoraDoc = int.Parse(txtId.Text);
                if (objN_DoctorHorario.eliminar(idHoraDoc))
                    MessageBox.Show("Se asigno al Doctor: " + cmbDoctor.SelectedText + "el Horario de: " +
                cmbHorario.SelectedText + "\n", "Nuevo Horario",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al vincular el Doctor con el Horario \n" + ex.Message, "Er077",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                cargar();
            }

        }

        public void cargarDatos()
        {
            txtId.Text = (string)dgvDoctorHorario.CurrentRow.Cells["idDoctorHorario"].Value;
            cmbHorario.SelectedValue = (int)dgvDoctorHorario.CurrentRow.Cells["idHorario"].Value;
            cmbDoctor.SelectedValue = (int)dgvDoctorHorario.CurrentRow.Cells["idDoctor"].Value;
            formatoEliminar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            comprobarRelacion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void dgvDoctorHorario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarDatos();
        }
    }
}
