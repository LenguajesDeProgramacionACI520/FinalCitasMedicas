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
    public partial class frmEspecialidadPromocion : Form
    {
        int bandera = 0;
        DataSet ds = new DataSet();
        clsN_Especialidad N_Especialidad = new clsN_Especialidad();
        clsN_Promociones N_Promociones = new clsN_Promociones();
        clsN_EspecialidadPromocion N_EspeProm = new clsN_EspecialidadPromocion();
        public frmEspecialidadPromocion()
        {
            InitializeComponent();
        }
        
        private void frmEspecialidadPromocion_Load(object sender, EventArgs e)
        {
            if (bandera == 0)
            {
                cargarEspecialidad();
                cargarPromocion();
            }
            bandera = 1;

        }

        private void cargarEspecialidad()
        {
            try
            {
                ds = N_Especialidad.consultaEspecialidad();
                cmbEspecialidad.DataSource = ds.Tables["TblEspecialidad"];
                cmbEspecialidad.ValueMember = "id";
                cmbEspecialidad.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Promociones \n" + ex.Message +
                    "\nIntente Nuevamente", "Er032",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void cargarPromocion()
        {
            try
            {
                ds = N_Promociones.consultaPromociones();
                cmbPromocion.DataSource = ds.Tables["TblPromociones"];
                cmbPromocion.ValueMember = "id";
                cmbPromocion.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Promociones \n" + ex.Message +
                    "\nIntente Nuevamente", "Er032",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
    }
}
