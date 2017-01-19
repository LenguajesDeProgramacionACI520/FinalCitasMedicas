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
    public partial class frmManejoHospital : Form
    {
        int bandera = 0;
        DataSet ds = new DataSet();
        clsValidaciones validar = new clsValidaciones();
        clsN_Ciudad N_ciudad = new clsN_Ciudad();
        clsN_Hospital N_Hospital = new clsN_Hospital();
        public frmManejoHospital()
        {
            InitializeComponent();
        }

        private void frmManejoHospital_Load(object sender, EventArgs e)
        {
            if (bandera == 0)
            {
                cargarCiudad();
            }
            bandera = 1;
            cargarId();
            dgvHosp.ReadOnly = true;
            formatoParaAgregar();
            txtId.Enabled = false;
            txtNombre.MaxLength = 20;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtDireccion.MaxLength = 100;
            cargarDgv();

        }

        private void limpiar()
        {
            cargarId();
            txtNombre.Clear();
            cargarCiudad();
            formatoParaAgregar();
        }

        private void cargarCiudad()
        {
            try
            {
                ds = N_ciudad.consultaCiudad();
                cmbCiudad.DataSource = ds.Tables["TblCiudad"];
                cmbCiudad.ValueMember = "idCiudad";
                cmbCiudad.DisplayMember = "nomCiudad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Ciudades\n" + ex.Message +
                    "\nIntente Nuevamente", "Er028",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void cargarDgv()
        {
            try
            {
                ds = N_Hospital.consultaHospitales();
                dgvHosp.DataSource = ds;
                dgvHosp.DataMember = "TblHospital";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Hospitales \n" + ex.Message +
                    "\nIntente Nuevamente", "Er027",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void cargarId()
        {
            try
            {
                ds = N_Hospital.consultaId();
                int id = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                id = id + 1;
                txtId.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror al obtener un nuevo id\n" + ex.Message, "Er014",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void formatoParaAgregar()
        {
            btnAgregar.Enabled = true;
            btnAgregar.ForeColor = Color.ForestGreen;
            btnEliminar.Enabled = false;
            btnEliminar.ForeColor = Color.Silver;
            btnModificar.Enabled = false;
            btnModificar.ForeColor = Color.Silver;
        }

        private void formatoModificarEliminar()
        {
            btnAgregar.Enabled = false;
            btnAgregar.ForeColor = Color.Silver;
            btnEliminar.Enabled = true;
            btnEliminar.ForeColor = Color.ForestGreen;
            btnModificar.Enabled = true;
            btnModificar.ForeColor = Color.ForestGreen;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetrasEspacio(sender, e);
        }

        private void obtenerDatos()
        {
            txtId.Text = dgvHosp.CurrentRow.Cells["idHospital"].Value.ToString();
            txtNombre.Text = dgvHosp.CurrentRow.Cells["nomHospital"].Value.ToString();
            txtDireccion.Text = dgvHosp.CurrentRow.Cells["dirHospital"].Value.ToString();
            int ciudad = (int)dgvHosp.CurrentRow.Cells["idCiudad"].Value;
            cmbCiudad.SelectedValue = ciudad;
        }

        private void dgvHosp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formatoModificarEliminar();
            obtenerDatos();
        }

        private bool comprobar()
        {
            if (txtNombre.Text != "" && txtDireccion.Text != "")
                return true;
            else
            {
                MessageBox.Show("Completa los campos vacíos", "Er017",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (comprobar())
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                string dir = txtDireccion.Text;
                int ciudad = int.Parse(cmbCiudad.SelectedValue.ToString());
                try
                {
                    if (N_Hospital.agregarHospital(id, nombre,dir, ciudad))
                    {
                        MessageBox.Show("Se ha ingresado correctamente el hospital:" + txtNombre.Text + ""
                                     , "Nuevo Hospital", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        cargarDgv();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar un nuevo hospital\n" + ex.Message, "Er028",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();

                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (comprobar())
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                string dir = txtDireccion.Text;
                int ciudad = int.Parse(cmbCiudad.SelectedValue.ToString());
                try
                {
                    if (N_Hospital.modificarHospital(id, nombre,dir, ciudad))
                    {
                        MessageBox.Show("Se ha modificado correctamente el hospital:" + txtNombre.Text + ""
                                     , "Hospital Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        cargarDgv();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el hospital seleccionado\n" + ex.Message, "Er029",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();

                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            try
            {
                if (N_Hospital.eliminarHospital(id))
                {
                    MessageBox.Show("Se ha eliminado correctamente el hospital: " + txtNombre.Text + ""
                                 , "Hospital Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    cargarDgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el hospital seleccionado\n" + ex.Message, "Er030",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();

            }
        }
    }
}
