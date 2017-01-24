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
    public partial class frmActivarHora : Form
    {
        clsN_Hora objN_Hora = new clsN_Hora();
        DataSet ds = new DataSet();
        public frmActivarHora()
        {
            InitializeComponent();
            btnAC.Enabled = false;
        }

        private void frmActivarHora_Load(object sender, EventArgs e)
        {
            inicio();
        }

        private void inicio()
        {
            cargarHora();
        }

        private void cargarHora()
        {
            ds = objN_Hora.consultaHora();
            dgvHora.DataSource = ds;
            dgvHora.DataMember = "TblHora";

        }

        public void obtenterHora(int idHora)
        {
            ds = objN_Hora.consultaHora(idHora);
            cmbHora.DataSource = ds.Tables["TblHora"];
            cmbHora.ValueMember = "idHora";
            cmbHora.DisplayMember = "hora";
        }


        private void cargarEstado()
        {
            cmbEstado.Items.Insert(0, "ACTIVADO");
            cmbEstado.Items.Insert(1, "DESCATIVADO");
            cmbEstado.Enabled = false;
            cmbEstado.SelectedIndex = 0;
        }

        private void dgvHora_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvHora.CurrentRow.Cells["idHora"].Value;
            obtenterHora(id);
            cargarEstado();
            string ac = (string)dgvHora.CurrentRow.Cells["estHora"].Value;
            if (ac == "AC")
            {
                cmbEstado.SelectedIndex = 0;
                btnAC.Text = "Descativar Hora";

            }
            if (ac == "DC")
            {
                cmbEstado.SelectedIndex = 1;
                btnAC.Text = "Activar Hora";
            }
            btnAC.Enabled = true;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {

            if (btnAC.Text.Equals("Descativar Hora"))
            {
                try
                {
                    if (objN_Hora.desactivarHora(int.Parse(cmbHora.SelectedValue.ToString())))
                        MessageBox.Show("Se ha desactivado de manera correcta la hora"
                              , "Hora Descativada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inicio();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas al desactivar la hora" +
                        "\n" + ex.Message, "Er080",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inicio();
                }

            }
            if (btnAC.Text.Equals("Activar Hora"))
            {
                try
                {
                    if (objN_Hora.activarHora(int.Parse(cmbHora.SelectedValue.ToString())))
                        MessageBox.Show("Se ha activado de manera correcta la hora" 
                              , "Hora Activada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inicio();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas al activar el Administrador" +
                        "\n" + ex.Message, "Er051",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inicio();
                }

            }
            btnAC.Enabled = false;
        }
    }
}
