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
    public partial class frmManejoDoctores : Form
    {
        int bandera = 0;
        clsValidaciones validar = new clsValidaciones();
        clsN_Admin N_Admin = new clsN_Admin();
        clsN_Usuario N_Usuario = new clsN_Usuario();
        clsN_Doctores N_Doctores = new clsN_Doctores();
        clsN_Hospital N_Hospitales = new clsN_Hospital();
        clsN_Especialidad N_Especilidad = new clsN_Especialidad();
        DataSet ds = new DataSet();
        public frmManejoDoctores()
        {
            InitializeComponent();
        }

        private void frmManejoDoctores_Load(object sender, EventArgs e)
        {
            if (bandera == 0)
            {
                cargarEspecialidad();
                cargarHospital();
            }
            bandera = 1;
            cargarGenero();
            cargarDgv();
            formatoParaAgregar();
            txtNombre.MaxLength = 20;
            txtApellido.MaxLength = 20;
            txtCelular.MaxLength = 9;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            dgvDoctores.ReadOnly = true;
            DateTime hoy = DateTime.Today;
            dtpfechaNa.MaxDate = new DateTime(hoy.Year, hoy.Month, hoy.Day);
            dtpfechaNa.MinDate = new DateTime(hoy.Year - 120, 1, 1);
        }

        private void cargarDgv()
        {
            try
            {
                ds = N_Doctores.consultaDoctores();
                dgvDoctores.DataSource = ds;
                dgvDoctores.DataMember = "TblDoctores";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los Doctores\n" + ex.Message +
                    "\nIntente Nuevamente", "Er020",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void cargarHospital()
        {
            try
            {
                ds = N_Hospitales.consultaHospitales();
                cmbHospital.DataSource = ds.Tables["TblHospital"];
                cmbHospital.ValueMember = "idHospital";
                cmbHospital.DisplayMember = "nomHospital";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Hospitales\n" + ex.Message +
                    "\nIntente Nuevamente", "Er021",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void cargarGenero()
        {
            cmbGenero.Items.Add("FEMENINO");
            cmbGenero.Items.Add("MASCULINO");
        }

        private void cargarEspecialidad()
        {
            try
            {
                ds = N_Especilidad.consultaEspecialidad();
                cmbEspecialidad.DataSource = ds.Tables["TblEspecialidad"];
                cmbEspecialidad.ValueMember = "idEspecialidad";
                cmbEspecialidad.DisplayMember = "nomEspecialidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Especialidades\n" + ex.Message +
                    "\nIntente Nuevamente", "Er022",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void formatoParaAgregar()
        {
            mskCedula.Enabled = true;
            btnIngresar.Enabled = true;
            btnIngresar.ForeColor = Color.ForestGreen;
            btnEliminar.Enabled = false;
            btnEliminar.ForeColor = Color.Silver;
            btnModificar.Enabled = false;
            btnModificar.ForeColor = Color.Silver;
            btnAC.Enabled = false;
            btnAC.ForeColor = Color.Silver;
        }

        private void formatoModificarEliminar()
        {
            mskCedula.Enabled = false;
            btnIngresar.Enabled = false;
            btnIngresar.ForeColor = Color.Silver;
            btnEliminar.Enabled = true;
            btnEliminar.ForeColor = Color.ForestGreen;
            btnModificar.Enabled = true;
            btnModificar.ForeColor = Color.ForestGreen;
            btnAC.Enabled = true;
            btnAC.ForeColor = Color.ForestGreen;
        }

        private bool comprobar()
        {
            if (mskCedula.Text.Length == 10)
                if(txtNombre.Text != "" && txtApellido.Text!= "")
                    if (txtCelular.Text.Length == 9)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un número de Celular válido", "Er023",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                else
                {
                    MessageBox.Show("Completa los campos vacíos", "Er017",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
            else
            {
                MessageBox.Show("la cedula debe tener 10 caracteres", "Er013",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCedula.Clear();
                return false;

            }
        }

        private void limpiar()
        {
            cargarDgv();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCelular.Clear();
            mskCedula.Clear();
            cargarEspecialidad();
            cargarHospital();
            formatoParaAgregar();
            DateTime hoy = DateTime.Today;
            dtpfechaNa.Value = hoy.Date;
        }

        private void soloLetras(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void mskCedula_TextChanged(object sender, EventArgs e)
        {
            if (mskCedula.Text.Length == 10)
                verificarCi(mskCedula.Text);
            else if( mskCedula.Enabled == true)
            {
                formatoParaAgregar();
            }
        }

        private void verificarCi(string ci)
        {
            if (N_Usuario.verificarCi(ci))
            {
                if (!(N_Admin.verificarCi(ci)))
                    MessageBox.Show("Este usuario ya es administrador\n Intente Nuevamente",
                        "Er004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Este usuario ya existe\n Intente Nuevamente",
                    "Er005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (comprobar())
            {
                string cedula = mskCedula.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int genero = int.Parse(cmbGenero.SelectedValue.ToString());
                DateTime fechaN = dtpfechaNa.Value.Date;
                string cel = txtCelular.Text;
                int idHospital = int.Parse(cmbHospital.SelectedValue.ToString());
                int idEspecialidad = int.Parse(cmbEspecialidad.SelectedValue.ToString());

                try
                {
                    if (N_Doctores.agregarDocotor(cedula, nombre, apellido, genero, fechaN, cel, idHospital, idEspecialidad))
                    {
                        MessageBox.Show("Se ha ingresado correctamente el Docotor:" + txtNombre.Text + ""
                                     , "Nuevo Doctor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        cargarDgv();
                        formatoParaAgregar();
                        cargarEspecialidad();
                        cargarGenero();
                        cargarHospital();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha ingresado el Doctor" + ex.Message, "Er025",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (comprobar())
            {
                string cedula = mskCedula.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int genero = int.Parse(cmbGenero.SelectedValue.ToString());
                DateTime fechaN = dtpfechaNa.Value.Date;
                string cel = txtCelular.Text;
                int idHospital = int.Parse(cmbHospital.SelectedValue.ToString());
                int idEspecialidad = int.Parse(cmbEspecialidad.SelectedValue.ToString());

                try
                {
                    if (N_Doctores.modificarDocotor(cedula,nombre,apellido,genero,fechaN,cel,idHospital, idEspecialidad))
                    {
                        MessageBox.Show("Se ha modifcado correctamente el Docotor:" + txtNombre.Text + ""
                                     , "Doctor Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        cargarDgv();
                        formatoParaAgregar();
                        cargarEspecialidad();
                        cargarGenero();
                        cargarHospital();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message, "Er024",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();

                }
            }

        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumero(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string ci = mskCedula.Text;
                if (N_Doctores.eliminarDoctor(ci))
                { 
                        MessageBox.Show("Se ha eliminado de manera correcta el administrador:" + mskCedula.Text + "'"
                          , "Modificación Exitosa",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    cargarDgv();
                    formatoParaAgregar();
                    cargarEspecialidad();
                    cargarGenero();
                    cargarHospital();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al eliminar el doctor" +
                    "\nConsulta al administrador", "Er026",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();

            }

        }

        private void dgvDoctores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formatoModificarEliminar();
            cargarDatos();
        }

        private void cargarDatos()
        {
            mskCedula.Text= (string)dgvDoctores.CurrentRow.Cells["idDoctor"].Value;
            txtNombre.Text= (string)dgvDoctores.CurrentRow.Cells["nomDoctor"].Value;
            txtApellido.Text= (string)dgvDoctores.CurrentRow.Cells["apeoDoctor"].Value;
            DateTime fecha = (DateTime) dgvDoctores.CurrentRow.Cells["fechaN_Doctor"].Value;
            dtpfechaNa.Value = fecha.Date;
            string genero = (string)dgvDoctores.CurrentRow.Cells["genDoc"].Value;
            if (genero == "F")
                cmbGenero.SelectedIndex = 0;
            if (genero == "M")
                cmbGenero.SelectedIndex = 1;
            txtCelular.Text= (string)dgvDoctores.CurrentRow.Cells["celDoc"].Value;
            int idHospital = (int)dgvDoctores.CurrentRow.Cells["idHospital"].Value;
            int idEspecialidad = (int)dgvDoctores.CurrentRow.Cells["idEspecialidad"].Value;
            string ac = (string)dgvDoctores.CurrentRow.Cells["estAdmin"].Value;
            if (ac == "AC")
               btnAC.Text = "Descativar Administrador";
            if (ac == "DC")
                btnAC.Text = "Activar Administrador";
            cmbHospital.SelectedValue = idHospital;
            cmbEspecialidad.SelectedValue = idEspecialidad;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            if (btnAC.Text.Equals("Descativar Administrador"))
            {
                try
                {
                    if (N_Doctores.desactivarDoctor(mskCedula.Text))
                        MessageBox.Show("Se ha descativado de manera correcta el Doctor:" + mskCedula.Text + ""
                              , "Doctor Descativado", MessageBoxButtons.OK, MessageBoxIcon.Information);                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas al desactivar el Doctor" +
                        "\n" + ex.Message, "Er052",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    limpiar();
                    cargarDgv();
                    formatoParaAgregar();
                    cargarEspecialidad();
                    cargarGenero();
                    cargarHospital();

                }

            }
            if (btnAC.Text.Equals("Activar Administrador"))
            {
                try
                {
                    if (N_Admin.activarAdmin(mskCedula.Text))
                        MessageBox.Show("Se ha activado de manera correcta el Doctor" + mskCedula.Text + ""
                              , "Doctor Activado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas al activar el Doctor" +
                        "\n" + ex.Message, "Er053",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                    limpiar();
                    cargarDgv();
                    formatoParaAgregar();
                    cargarEspecialidad();
                    cargarGenero();
                    cargarHospital();
                }

            }
        }

    }    
}
