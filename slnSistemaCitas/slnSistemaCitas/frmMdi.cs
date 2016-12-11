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
        int rol=0;
        Form login;
        string ci = "";
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

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
            
        }

        private void frmMdi_Load(object sender, EventArgs e)
        {

        }
    }
}
