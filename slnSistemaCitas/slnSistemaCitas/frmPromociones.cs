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
    public partial class frmPromociones : Form
    {
        DataSet ds = new DataSet();
        clsN_Promociones N_Promociones = new clsN_Promociones();
        clsValidaciones validar = new clsValidaciones();
        public frmPromociones()
        {
            InitializeComponent();
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
                ds = N_Promociones.consultaPromociones();
                dgvPro.DataSource = ds;
                dgvPro.DataMember = "TblPromocion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Promociones \n" + ex.Message +
                    "\nIntente Nuevamente", "Er032",
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
            cargarDgv();
        }

        private void cargarId()
        {
            try
            {
                ds = N_Promociones.obtenerId();
                int id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                id = id + 1;
                txtId.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror al obtener un nuevo id\n" + ex.Message, "Er014",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (decimal.Parse(mskDescuento.Text) <= 100)
                    return true;
                else
                {
                    MessageBox.Show("Descuento no puede ser mayor a 100", "Er032",
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
                string nombre = txtNombre.Text;
                int descuento = int.Parse(mskDescuento.Text);
                try
                {
                    if (N_Promociones.agregarPromocion(nombre, descuento))
                    {
                        MessageBox.Show("Se ha ingresado correctamente la prmoción: " + txtNombre.Text + ""
                                     , "Nuevo Promoción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errr al agregar una nueva promoción" + ex.Message, "Er033",
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
                int idSinP = (int)dgvPro.Rows[0].Cells[0].Value;
                if (id != idSinP)
                {
                    string nombre = txtNombre.Text;
                    int descuento = int.Parse(mskDescuento.Text);
                    try
                    {
                        if (N_Promociones.modificarPromocion(id, nombre, descuento))
                        {
                            MessageBox.Show("Se ha modificado correctamente la prmoción: " + txtNombre.Text + ""
                                         , "Promoción Modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errr al modificar la promoción seleccionada" + ex.Message, "Er034",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpiar();

                    }
                }
                else
                {
                    MessageBox.Show("No se puede modificar la promoción seleccionada", "Er076",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            int idSinP = (int)dgvPro.Rows[0].Cells[0].Value;
            if (id != idSinP)
            {
                try
                {
                    if (N_Promociones.eliminarPromocion(id))
                    {
                        MessageBox.Show("Se ha eliminado correctamente la prmoción: " + txtNombre.Text + ""
                                     , "Promoción Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errr al eliminar la promoción seleccionada" + ex.Message, "Er035",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();

                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar la promoción seleccionada","Er075",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }


        }

        private void frmPromociones_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void dgvHosp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarDatos();
            formatoModificarEliminar();
        }

        private void cargarDatos()
        {
            txtId.Text = dgvPro.CurrentRow.Cells["idPromocion"].Value.ToString();
            txtNombre.Text = (string)dgvPro.CurrentRow.Cells["nomPromocion"].Value;
            int prom = (int)dgvPro.CurrentRow.Cells["descuPromocion"].Value;
            mskDescuento.Text = prom.ToString();
        }
    }
}