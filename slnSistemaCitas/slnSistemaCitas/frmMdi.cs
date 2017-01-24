using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnSistemaCitas
{
    public partial class frmMdi : Form
    {
        public int rol { get; set; }
        Form login;
        public string ci { get; set; }
        public frmMdi(string ci, int rol, Form inicio)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //Información del Usuario Logeado
            this.ci = ci;
            this.rol = rol;
            login= inicio;

            
            //Comprobacion del Nivel de Acceso
            if(identificacionUsuario())
            {
                adminToolStripMenuItem.Visible = true;
                usuarioToolStripMenuItem.Visible = false;
                adminUsuarioToolStripMenuItem.Visible = true;
            }
            else
            {
                adminToolStripMenuItem.Visible = false;
                usuarioToolStripMenuItem.Visible = true;
                adminUsuarioToolStripMenuItem.Visible = false;
            }
            
        }
        //Metodo para identificar el ROL
        public bool identificacionUsuario()
        {
            if (rol == 1)
               return true;
            else
               return false;
        }

        private void manejoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManejoUsuarios usuario = new frmManejoUsuarios();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
            
        }

        private void frmMdi_Load(object sender, EventArgs e)
        {

        }

        private void manejoDeAdministradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManejoAdmin manAdmin = new frmManejoAdmin(ci);
            manAdmin.MdiParent = this;
            manAdmin.Show();
        }

        private void manejoDeEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEspecialidad espcialidades = new frmEspecialidad();
            espcialidades.MdiParent = this;
            espcialidades.Show();
        }

        private void manejoDeDoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void manjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManejoHospital hospitales = new frmManejoHospital();
            hospitales.MdiParent = this;
            hospitales.Show();
        }

        private void promocionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPromociones promociones = new frmPromociones();
            promociones.MdiParent = this;
            promociones.Show();
        }

        private void segurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManejoSeguro seguro = new frmManejoSeguro();
            seguro.MdiParent = this;
            seguro.Show();
        }

        private void asignarPromocionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void solicitarCitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMedia citaMedica = new frmConsultaMedia(ci);
            citaMedica.MdiParent = this;
            citaMedica.Show();
        }

        private void vincularHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoctorHorario docHorario = new frmDoctorHorario();
            docHorario.MdiParent = this;
            docHorario.Show();
        }

        private void agregarDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManejoDoctores doctores = new frmManejoDoctores();
            doctores.MdiParent = this;
            doctores.Show();

        }
    }
}
