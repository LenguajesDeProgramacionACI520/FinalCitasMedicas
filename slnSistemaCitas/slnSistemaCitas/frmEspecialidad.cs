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
    public partial class frmEspecialidad : Form
    {
        DataSet ds = new DataSet();
        clsN_Especialidad N_Especialidad = new clsN_Especialidad();
        public frmEspecialidad()
        {
            InitializeComponent();
        }

        private void frmEspecialidad_Load(object sender, EventArgs e)
        {
            limpiar();
            cargarDgv();
            asignarId();
            formatoParaIngresar();
            dgvEspe.ReadOnly = true;
            txtId.Enabled = false;
            txtNombre.MaxLength = 20;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            mskCosto.Clear();
        }
        private void cargarDgv()
        {
            try
            {
                ds = N_Especialidad.consultaEspecialidad();
                dgvEspe.DataSource = ds;
                dgvEspe.DataMember = "TblEspecialidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al recuperar la informacion Especialidad"+ex.Message, "Er016",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formatoParaIngresar()
        {
            btnAgregar.Enabled = true;
            btnAgregar.ForeColor = Color.Firebrick;
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
            btnEliminar.ForeColor = Color.Firebrick;
            btnModificar.Enabled = true;
            btnModificar.ForeColor = Color.Firebrick;
        }

        private void asignarId()
        {
            try
            {
                ds = N_Especialidad.consultaId();
                int id = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                id = id + 1;
                txtId.Text = id.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Eror al obtener un nuevo id\n"+ex.Message, "Er014",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        private bool comprobar()
        {
            if (txtNombre.Text != "" && mskCosto.Text != "")
            {              
                    return true;     
            }
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
                float costo = float.Parse(mskCosto.Text);
                try
                {
                    if (N_Especialidad.agregarEspecialidad(id, nombre, costo))
                    {
                        MessageBox.Show("Se ha ingresado correctamente la especialidad:" + txtNombre.Text + ""
                                     , "Nuevo Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        cargarDgv();
                        asignarId();
                        formatoParaIngresar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message, "Er016",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        
        
        private void cargarDatos()
        {
            txtId.Text = dgvEspe.CurrentRow.Cells["id"].Value.ToString();
            txtNombre.Text = (string)dgvEspe.CurrentRow.Cells["nombre"].Value;
            mskCosto.Text = dgvEspe.CurrentRow.Cells["costo"].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(comprobar())
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                float costo = float.Parse(mskCosto.Text);
                try
                {
                    if (N_Especialidad.modificarEspecialidad(id, nombre, costo))
                    {
                        MessageBox.Show("Se ha modificado correctamente la especialidad: " + txtNombre.Text + ""
                                 , "Especialidad Modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        cargarDgv();
                        asignarId();
                        formatoParaIngresar();
                    }
                        
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro al modificar la especialidad"+ex.Message, "Er018",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            try
            {
                if (N_Especialidad.eliminarEspecialidad(id))
                {
                    MessageBox.Show("Se ha eliminado correctamente la especialidad: " + txtNombre.Text + ""
                             , "Especialidad Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    cargarDgv();
                    asignarId();
                    formatoParaIngresar();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void dgvEspe_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            formatoModificarEliminar();
            cargarDatos();

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender,e);
        }
    }
}
