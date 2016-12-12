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
            txtId.Enabled = false;
            txtNombre.MaxLength = 20;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            mskCosto.Clear();
            mskDescuento.Clear();
        }
        private void cargarDgv()
        {
            try
            {
                ds = N_Especialidad.consultaEspecialidad();
                dgvEspecialidad.DataSource = ds;
                dgvEspecialidad.DataMember = "TblEspecialidad";
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

        private void mskDescuento_TextChanged(object sender, EventArgs e)
        {
            int descuento = 0;
            try
            {
                 descuento= int.Parse(mskDescuento.Text);
            }
            catch(System.FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (descuento > 100)
            {
                MessageBox.Show("Descuento no puede ser mayor a 100", "Er015",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskDescuento.Clear();
            }
            else
            {

            }
        }

        private bool comprobar()
        {
            if (txtNombre.Text != "" && mskCosto.Text != "")
            {
                int descuento = int.Parse(mskDescuento.Text);
                if (descuento <= 100)                
                    return true;                
                else
                {
                    MessageBox.Show("Descuento no puede ser mayor a 100", "Er015",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskDescuento.Clear();
                    return false;
                }
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
                int descuento = int.Parse(mskDescuento.Text);
                try
                {
                    if (N_Especialidad.agregarEspecialidad(id, nombre, costo, descuento))
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

        private void dgvEspecialidad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formatoModificarEliminar();
            cargarDatos();
        }
        
        private void cargarDatos()
        {
            txtId.Text = dgvEspecialidad.CurrentRow.Cells["id"].Value.ToString();
            txtNombre.Text = (string)dgvEspecialidad.CurrentRow.Cells["nombre"].Value;
            mskCosto.Text = dgvEspecialidad.CurrentRow.Cells["costo"].Value.ToString();
            mskDescuento.Text = dgvEspecialidad.CurrentRow.Cells["descuento"].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(comprobar())
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                float costo = float.Parse(mskCosto.Text);
                int descuento = int.Parse(mskDescuento.Text);
                try
                {
                    if (N_Especialidad.modificarEspecialidad(id, nombre, costo, descuento))
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
    }
}
