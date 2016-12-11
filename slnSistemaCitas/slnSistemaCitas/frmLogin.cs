using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace slnSistemaCitas
{
    public partial class frmLogin : Form
    {
        clsN_Usuario usuario = new clsN_Usuario();
        clsN_Login login = new clsN_Login();
        clsN_Admin admin = new clsN_Admin();
        DataSet ds = new DataSet();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void deshabilitar(Button bt)
        {
            bt.Enabled = false;
            bt.BackColor = Color.Silver;

        }

        private void habilitar(Button bt)
        {
            bt.Enabled = true;
            bt.BackColor = Color.Honeydew;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtCi.MaxLength = 10;
            txtPass.MaxLength = 20;
            pcbUsuario.Visible = false;
            deshabilitar(btnIngreso);

        }

        private void pcbPassVis_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar.Equals(true))
            {
                pcbPassVis.Image = Image.FromFile("207-eye.png");
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                pcbPassVis.Image = Image.FromFile("210-eye-blocked.png");
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnIngreso.PerformClick();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtCi.Text);
            Console.WriteLine(txtPass.Text);
            if(login.N_ingreso(txtCi.Text, txtPass.Text))
            {
                try
                {
                    ds = login.N_consulta(txtCi.Text);
                    string ci = ds.Tables[0].Rows[0]["usuario"].ToString();
                    int rol = int.Parse(ds.Tables[0].Rows[0]["rol"].ToString());
                    Console.WriteLine(ci);
                    limpiar();
                    frmMdi inicio = new frmMdi(ci, rol, this);
                    inicio.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    limpiar();
                    MessageBox.Show("No se encontró usuario en la base\n"+
                        "Comunicarse con el Administrador","Er001",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw ex;
                }
            }
            else
            {
                limpiar();
                MessageBox.Show("Usuario no existe \nVuelva a intentarlo", "Er000", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limpiar()
        {
            txtPass.Clear();
            txtCi.Clear();
            txtPass.UseSystemPasswordChar = true;
            pcbPassVis.Image = Image.FromFile("210-eye-blocked.png");
            pcbUsuario.Visible = false;
            txtCi.Focus();
        }

        private void txtCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || e.KeyChar==(char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = false;
            }
            else if(e.KeyChar == (char)Keys.Return)
            {
                e.Handled = false;
                SendKeys.Send("{TAB}");
            }
            else
            {
                e.Handled = true;
            }
            
        }
        
        private void txtCi_TextChanged(object sender, EventArgs e)
        {
            pcbUsuario.Visible = true;
            if (txtCi.Text.Length != 10)
            {
                pcbUsuario.Image = Image.FromFile("img/cross.png");
            }
            else
            {
                pcbUsuario.Image = Image.FromFile("img/check.png");
                camposCompletos();
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            camposCompletos();
        }

        private void camposCompletos()
        {
            if ((txtCi.Text.Length == 10 ) & (txtPass.Text.Length >= 6))
                habilitar(btnIngreso);
            else
                deshabilitar(btnIngreso);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario registro = new frmRegistrarUsuario();
            registro.ShowDialog();
        }
    }
}
