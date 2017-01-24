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
        clsN_Promociones N_Promociones = new clsN_Promociones();
        public frmEspecialidad()
        {
            InitializeComponent();
        }

        private void frmEspecialidad_Load(object sender, EventArgs e)
        {
            limpiar();
            cargarPromocion();
            cargarDgv();
            asignarId();
            formatoParaIngresar();
            dgvEspe.ReadOnly = true;
            txtId.Enabled = false;
            txtNombre.MaxLength = 20;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtDescripcion.MaxLength = 100;
            txtDescripcion.CharacterCasing = CharacterCasing.Upper;
        }

        public void cargarPromocion()
        {
            try
            {
                ds = N_Promociones.consultaPromociones();
                cmbPromocion.DataSource = ds.Tables["TblPromocion"];
                cmbPromocion.ValueMember = "idPromocion";
                cmbPromocion.DisplayMember = "nomPromocion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Promociones\n" + ex.Message +
                    "\nIntente Nuevamente", "Er071",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            mskCosto.Clear();
            cargarPromocion();
            txtDescripcion.Clear();
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
                int id = (int)ds.Tables[0].Rows[0][0];
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
                string nombre = txtNombre.Text;
                decimal costo = decimal.Parse(mskCosto.Text);
                string descripcion = txtDescripcion.Text;
                int promo = int.Parse(cmbPromocion.SelectedValue.ToString());
                Console.Write("Promocion: "+promo);
                try
                {
                    if (N_Especialidad.agregarEspecialidad(nombre,descripcion, costo, promo))
                    {
                        MessageBox.Show("Se ha ingresado correctamente la especialidad:" + txtNombre.Text + ""
                                     , "Nuevo Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        cargarPromocion();
                        cargarDgv();
                        asignarId();
                        formatoParaIngresar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar la especialidad" + ex.Message, "Er016",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        
        
        private void cargarDatos()
        {
            txtId.Text = dgvEspe.CurrentRow.Cells["idEspecialidad"].Value.ToString();
            txtNombre.Text = (string)dgvEspe.CurrentRow.Cells["nomEspecialidad"].Value;
            decimal costo = (decimal)dgvEspe.CurrentRow.Cells["costoEspecialidad"].Value;
            mskCosto.Text = costo.ToString();
            txtDescripcion.Text = (string)dgvEspe.CurrentRow.Cells["descEpecialidad"].Value;
            cmbPromocion.SelectedValue = (int)dgvEspe.CurrentRow.Cells["idPromocion"].Value;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(comprobar())
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                decimal costo = decimal.Parse(mskCosto.Text);
                string descripcion = txtDescripcion.Text;
                int promo = int.Parse(cmbPromocion.SelectedValue.ToString());
                try
                {
                    if (N_Especialidad.modificarEspecialidad(id, nombre,descripcion, costo, promo))
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
                    MessageBox.Show("Erro al modificar la especialidad\n"+ex.Message, "Er018",
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
                MessageBox.Show("Erro al eliminar la especialidad\n" + ex.Message, "Er053",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender,e);
        }

        private void dgvEspe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formatoModificarEliminar();
            cargarDatos();
        }
    }
}
