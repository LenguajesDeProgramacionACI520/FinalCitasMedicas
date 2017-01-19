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
    public partial class frmManejoSeguro : Form
    {
        DataSet ds = new DataSet();
        clsN_Usuario N_usuario = new clsN_Usuario();
        clsN_Seguro N_Seguro = new clsN_Seguro();
        clsValidaciones validar = new clsValidaciones();
        public frmManejoSeguro()
        {
            InitializeComponent();
        }

        private void frmManejoSeguro_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void iniciar()
        {
            txtId.Enabled = false;
            cargarDgv();
            cargarId();
            formatoParaAgregar();
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.MaxLength = 20;
        }

        private void cargarDgv()
        {
            try
            {
                ds = N_Seguro.consultaSeguro();
                dgvSeguro.DataSource = ds;
                dgvSeguro.DataMember = "TblSeguro";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Seguros \n" + ex.Message +
                    "\nIntente Nuevamente", "Er038",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void limpiar()
        {
            cargarId();
            txtNombre.Clear();
            mskDescuento.Clear();
            formatoParaAgregar();
            mskCosto.Clear();
            cargarDgv();
        }

        private void cargarId()
        {
            try
            {
                ds = N_Seguro.obtenerId();
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

        private bool comprobar()
        {
            if (txtNombre.Text != "")
                if (int.Parse(mskDescuento.Text) <= 100)
                    return true;
                else
                {
                    MessageBox.Show("Cobertura no puede ser mayor a 100", "Er032",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskDescuento.Clear();
                    return false;
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
                decimal descuento = decimal.Parse(mskDescuento.Text);
                decimal costo = decimal.Parse(mskDescuento.Text);
                try
                {
                    if (N_Seguro.agregarSeguro(id, nombre, descuento,costo))
                    {
                        MessageBox.Show("Se ha ingresado correctamente el seguro: " + txtNombre.Text + ""
                                     , "Nuevo Seguro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar un nuevo seguro\n" + ex.Message, "Er041",
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
                decimal descuento = decimal.Parse(mskDescuento.Text);
                decimal costo = decimal.Parse(mskDescuento.Text);
                try
                {
                    if (N_Seguro.modificarSeguro(id, nombre, descuento,costo))
                    {
                        MessageBox.Show("Se ha modificado correctamente el seguro: " + txtNombre.Text + ""
                                     , "Seguro Modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el seguro seleccionado\n" + ex.Message, "Er040",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();

                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            if (id != 0)
            {
                try
                {
                    if (N_Seguro.eliminarSeguro(id))
                    {
                        if (N_usuario.cambiarSeguro(id))
                        {
                            MessageBox.Show("Se ha eliminado correctamente el seguro \n " + txtNombre.Text + ""
                                         , "Seguro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el seguro seleccionado\n" + ex.Message, "Er039",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();

                }

            }else
            {
                MessageBox.Show("Este seguro no se puede borrar", "Er042",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();

            }


        }

        private void dgvSeguro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarDatos();
            formatoModificarEliminar();
        }

        private void cargarDatos()
        {
            int id = int.Parse(dgvSeguro.CurrentRow.Cells["idSeguro"].Value.ToString());
            if (id != 0)
            {
                txtId.Text = id.ToString();
                txtNombre.Text = (string)dgvSeguro.CurrentRow.Cells["nomSeguro"].Value;
                decimal descuento = (decimal)dgvSeguro.CurrentRow.Cells["porcenSeguro"].Value;
                decimal costo = (decimal)dgvSeguro.CurrentRow.Cells["valorSeguro"].Value;
                mskCosto.Text = costo.ToString();
                mskDescuento.Text = descuento.ToString();
            }
            else
            {
                MessageBox.Show("Este seguro no se puede borrar", "Er042",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }
    }
}

