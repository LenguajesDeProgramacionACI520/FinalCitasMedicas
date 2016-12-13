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
        clsN_Genero N_Genero = new clsN_Genero();
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
                cargarGenero();
            }
            bandera = 1;
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
            txtCelPrefijo.Enabled = false;
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
                cmbHospital.ValueMember = "idH";
                cmbHospital.DisplayMember = "nombreH";
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
            try
            {
                ds = N_Genero.consultaGenero();
                cmbGenero.DataSource = ds.Tables["TblGenero"];
                cmbGenero.ValueMember = "id";
                cmbGenero.DisplayMember = "gen_nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al Cargar el Genero \n" +ex.Message+"\n"+
                    "Cierre y vuelva a intentarlo", "Er002",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarEspecialidad()
        {
            try
            {
                ds = N_Especilidad.consultaEspecialidad();
                cmbEspecialidad.DataSource = ds.Tables["TblEspecialidad"];
                cmbEspecialidad.ValueMember = "id";
                cmbEspecialidad.DisplayMember = "nombre";
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
            btnIngresar.ForeColor = Color.ForestGreen;
            btnEliminar.Enabled = false;
            btnEliminar.ForeColor = Color.Silver;
            btnModificar.Enabled = false;
            btnModificar.ForeColor = Color.Silver;
            btnIngresar.Enabled = true;
        }

        private void formatoModificarEliminar()
        {
            mskCedula.Enabled = false;
            btnIngresar.ForeColor = Color.Silver;
            btnEliminar.Enabled = true;
            btnEliminar.ForeColor = Color.ForestGreen;
            btnModificar.Enabled = true;
            btnModificar.ForeColor = Color.ForestGreen;
            btnIngresar.Enabled = false;
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
                    MessageBox.Show("" + ex.Message, "Er025",
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
                          MessageBoxButtons.OK, MessageBoxIcon.Information); limpiar();
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
            mskCedula.Text= (string)dgvDoctores.CurrentRow.Cells["cedulaDoc"].Value;
            txtNombre.Text= (string)dgvDoctores.CurrentRow.Cells["nombreDoc"].Value;
            txtApellido.Text= (string)dgvDoctores.CurrentRow.Cells["apellidoDoc"].Value;
            DateTime fecha = (DateTime) dgvDoctores.CurrentRow.Cells["fechaN_Doc"].Value;
            dtpfechaNa.Value = fecha.Date;
            int genero = (int)dgvDoctores.CurrentRow.Cells["generoDoc"].Value;
            txtCelular.Text= (string)dgvDoctores.CurrentRow.Cells["celDoc"].Value;
            int idHospital = (int)dgvDoctores.CurrentRow.Cells["idHospital"].Value;
            int idEspecialidad = (int)dgvDoctores.CurrentRow.Cells["idEspecialidad"].Value;
            cmbGenero.SelectedValue = genero;
            cmbHospital.SelectedValue = idHospital;
            cmbEspecialidad.SelectedValue = idEspecialidad;
        }
    }    
}
