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
    public partial class frmRegistrarUsuario : Form
    {
        int bandera = 0;
        DataSet ds = new DataSet();
        clsN_Seguro N_Seguro = new clsN_Seguro();
        clsN_Usuario N_Usuario = new clsN_Usuario();
        clsN_Admin N_Admin = new clsN_Admin();
        clsN_Login N_Login = new clsN_Login();
        clsN_Ciudad N_Ciudad = new clsN_Ciudad();
        clsValidaciones validar = new clsValidaciones();

        Image asterisoImportante = Image.FromFile("img/aIm.png");
        Image error = Image.FromFile("img/excl.png");
        Image check = Image.FromFile("img/check.png");


        public frmRegistrarUsuario()
        {
            InitializeComponent();

        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            cargarLenght();
            cargarImg();
            cargarCiudad();
            deshabilitarRegistro();
        }

        private void deshabilitarRegistro()
        {
            btnRegistrar.Enabled = false;
            btnRegistrar.BackColor = Color.Silver;
        }

        private void cargarLenght()
        {
            if (bandera == 0)
            {
                cargarSeguro();
                cargarGenero();
            }
            bandera = 1;
            txtCi.MaxLength = 10;
            txtNom1.MaxLength = 20;
            txtNom2.MaxLength = 20;
            txtApe1.MaxLength = 20;
            txtApe2.MaxLength = 20;
            DateTime hoy = DateTime.Today;
            dtpFechaN.MaxDate = new DateTime(hoy.Year, hoy.Month, hoy.Day);
            dtpFechaN.MinDate = new DateTime(hoy.Year - 120, 1, 1);
            txtCel.MaxLength = 10;
            txtCorreo.MaxLength = 50;
            txtNom1.CharacterCasing = CharacterCasing.Upper;
            txtNom2.CharacterCasing = CharacterCasing.Upper;
            txtApe1.CharacterCasing = CharacterCasing.Upper;
            txtApe2.CharacterCasing = CharacterCasing.Upper;
        }

        private void cargarImg()
        {
            Image asterisoImportante = Image.FromFile("img/aIm.png");
            pcbCedula.Image = asterisoImportante;
            pcbFechaN.Image = asterisoImportante;
            pcbGenero.Image = asterisoImportante;
            pcbPass.Image = asterisoImportante;
            pcbPassVer.Image = asterisoImportante;
            pcbP_Ape.Image = asterisoImportante;
            pcbP_nom.Image = asterisoImportante;
            pcbSeguro.Image = asterisoImportante;
            pcbCelular.Image = asterisoImportante;
            pcbSector.Image = asterisoImportante;

        }

        private void cargarGenero()
        {
            cmbGenero.Items.Add("FEMENINO");
            cmbGenero.Items.Add("MASCULINO");
        }

        private void cargarCiudad()
        {
            try
            {
                ds = N_Ciudad.consultaCiudad();
                cmbCiudad.DataSource = ds.Tables["TblCiudad"];
                cmbCiudad.ValueMember = "idCiudad";
                cmbCiudad.DisplayMember = "nomCiudad";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Problemas al Cargar las Ciudades \n" +ex.Message+
                    "\nCierre y vuelva a intentarlo", "Er008",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarSeguro()
        {
            try
            {
                ds = N_Seguro.consultaSeguro();
                cmbSeguro.DataSource = ds.Tables["TblSeguro"];
                cmbSeguro.ValueMember = "idSeguro";
                cmbSeguro.DisplayMember = "nombSeguro";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al Cargar el Seguro Médico \n"+
                    "Cierre y vuelva a intentarlo\n" + ex.Message, "Er003",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verificarCi(string ci)
        {
            if (N_Usuario.verificarCi(ci))
            {
                if (N_Admin.verificarCi(ci))
                {
                    pcbCedula.Image = check;
                    comprobarRegistro();

                }
                else
                {
                    MessageBox.Show("Este usuario ya es administrador\n Intente Nuevamente",
                        "Er004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pcbCedula.Image = error;
                    comprobarRegistro();
                }
            }
            else
            {
                MessageBox.Show("Este usuario ya existen\n Intente Nuevamente",
                    "Er005", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pcbCedula.Image = error;
                comprobarRegistro();
            }
        }

        private void soloNumero(object sender, KeyPressEventArgs e)
        {
            validar.soloNumero(sender, e);
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

        private void txtCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
        }

        private void txtCi_TextChanged(object sender, EventArgs e)
        {
            if (txtCi.Text.Length == 10)
                verificarCi(txtCi.Text);
            else
            {
                pcbCedula.Image = error;
                comprobarRegistro();
            }
        }

        private void txtNom1_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
            comprobarRegistro();
        }

        private void txtNom2_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtApe1_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
            comprobarRegistro();
        }

        private void txtApe2_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
        }

        private void txtCel_TextChanged(object sender, EventArgs e)
        {
            if (txtCel.Text.Length == 9)
            {
                pcbCelular.Image = check;
                comprobarRegistro();
            }
            else
            {
                pcbCelular.Image = error;
                comprobarRegistro();
            }
        }

        private void txtPass1_TextChanged(object sender, EventArgs e)
        {
            if (txtPass1.Text.Length < 6)
                pcbPass.Image = error;
            else
            {
                pcbPass.Image = check;
            }
            if (txtPass2.Text.Equals(txtPass1.Text))
            {
                pcbPassVer.Image = check;
            }
            else
            {
                pcbPassVer.Image = error;
            }
            comprobarRegistro();

        }

        private void txtPass2_TextChanged(object sender, EventArgs e)
        {
            if (txtPass2.Text.Length < 6)
                pcbPassVer.Image = error;
            else
            {
                if (txtPass2.Text.Equals(txtPass1.Text))
                {
                    pcbPassVer.Image = check;
                }
            }
            comprobarRegistro();
        }

        private void txtPass1_Enter(object sender, EventArgs e)
        {
            txtPass1.UseSystemPasswordChar = false;
        }

        private void txtPass1_Leave(object sender, EventArgs e)
        {
            txtPass1.UseSystemPasswordChar = true;
            txtPass2.Focus();
        }

        private void txtPass2_Enter(object sender, EventArgs e)
        {
            txtPass2.UseSystemPasswordChar = false;
        }

        private void txtPass2_Leave(object sender, EventArgs e)
        {
            txtPass2.UseSystemPasswordChar = true;
            if (btnRegistrar.Enabled == false)
                btnCancelar.Focus();
            else
                btnRegistrar.Focus();
        }

        private void comprobarRegistro()
        {
            if (pcbCedula.Image == check)
            {
                if (txtNom1.Text != "" && txtApe1.Text != "")
                {
                    if (pcbCelular.Image == check)
                    {
                        if (pcbPass.Image == check && pcbPassVer.Image == check)
                        {
                            btnRegistrar.Enabled = true;
                            btnRegistrar.BackColor = Color.Honeydew;
                        }
                        else
                            deshabilitarRegistro();
                    }
                    else
                        deshabilitarRegistro();
                }
                else
                    deshabilitarRegistro();
            }
            else
                deshabilitarRegistro();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string idCedula = txtCi.Text;
            string nom1 = txtNom1.Text;
            string nom2 = txtNom2.Text;
            string ape1 = txtApe1.Text;
            string ape2 = txtApe2.Text;
            int genero = int.Parse(cmbGenero.SelectedValue.ToString());
            DateTime fechaN = dtpFechaN.Value.Date;
            string correo = txtCorreo.Text;
            string cel = txtCel.Text;
            int seguroMedico = int.Parse(cmbSeguro.SelectedValue.ToString());
            int sector = int.Parse(cmbCiudad.SelectedValue.ToString());
            string pass = txtPass1.Text;
            if (N_Usuario.agregarUsuario(idCedula, nom1, nom2, ape1, ape2, genero, fechaN,
                correo, cel, seguroMedico, sector))
            {
                if ((N_Login.agregarPersona(idCedula, pass, 0)))
                {
                    MessageBox.Show("Usuario: " + nom1 + " " + ape1 + " Registrado Satisfactoriamente" +
                        "\nYa puede Iniciar Sesión con su cedula y contraseña", "Nuevo Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar al Login", "Er006",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se pudo agregar el Usuario", "Er007",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
