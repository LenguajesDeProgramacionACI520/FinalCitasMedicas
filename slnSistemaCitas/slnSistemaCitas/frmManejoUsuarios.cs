using CapaNegocio;
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
    public partial class frmManejoUsuarios : Form
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


        public frmManejoUsuarios()
        {
            InitializeComponent();

        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            inicio();
        }

        private void inicio()
        {
            cargarLenght();
            cargarImg();
            cargarCiudad();
            cargarGenero();
            cargarSeguro();
            cargarDgv();
            deshabilitarRegistro();
            paraAgregar();
            comprobarRegistro();
        }

        private void deshabilitarRegistro()
        {
            btnRegistrar.Enabled = false;
            btnRegistrar.BackColor = Color.Silver;
        }

        private void paraAgregar()
        {
            btnRegistrar.Enabled = true;
            btnRegistrar.BackColor = Color.Honeydew;
            btnEliminar.Enabled = false;
            btnEliminar.BackColor = Color.Silver;
            btnModificar.Enabled = false;
            btnModificar.BackColor = Color.Silver;
        }

        private void paraModificarEliminar()
        {
            txtCi.Enabled = false;
            btnRegistrar.Enabled = false;
            btnRegistrar.BackColor = Color.Silver;
            btnEliminar.Enabled = true;
            btnEliminar.BackColor = Color.Honeydew;
            btnModificar.Enabled = true;
            btnModificar.BackColor = Color.Honeydew;


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
            cmbGenero.SelectedIndex = 0;
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
                cmbSeguro.DisplayMember = "nomSeguro";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al Cargar el Seguro Médico \n" +
                    "Cierre y vuelva a intentarlo\n" + ex.Message, "Er003",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDgv()
        {
            try
            {
                ds = N_Usuario.consultaUsurio();
                dgvUsuarios.DataSource = ds;
                dgvUsuarios.DataMember = "TblUsuario";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Usuarios\n" + ex.Message +
                    "\nIntente Nuevamente", "Er037",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void verificarCi(string ci)
        {
            if (txtCi.Enabled == true)
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
            if (txtCel.Text.Length == 10)
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
            comprobarRegistro();

        }
        
        private void txtPass1_Enter(object sender, EventArgs e)
        {
            txtPass1.UseSystemPasswordChar = false;
        }

        private void txtPass1_Leave(object sender, EventArgs e)
        {
            txtPass1.UseSystemPasswordChar = true;
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
                        if (pcbPass.Image == check)
                        {
                            if (txtCi.Enabled == true)
                            {
                                btnRegistrar.Enabled = true;
                                btnRegistrar.BackColor = Color.Honeydew;
                            }else
                            {
                                btnModificar.Enabled = true;
                                btnModificar.BackColor = Color.Honeydew;
                            }
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
            int seguro = int.Parse(cmbSeguro.SelectedValue.ToString());
            int ciudad = int.Parse(cmbCiudad.SelectedValue.ToString());
            string pass = txtPass1.Text;
            if (N_Usuario.agregarUsuario(idCedula, nom1, nom2, ape1, ape2, genero, fechaN,
                correo, cel, seguro, ciudad))
            {
                if ((N_Login.agregarPersona(idCedula, pass, 0)))
                {
                    MessageBox.Show("Usuario: " + nom1 + " " + ape1 + " Registrado Satisfactoriamente" +
                        "\nYa puede Iniciar Sesión con su cedula y contraseña", "Nuevo Registro", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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
            limpiar();
            inicio();
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

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            inicio();
            paraModificarEliminar();
            cargarDatos();
            obtenerPass(txtCi.Text);
            comprobarRegistro();
        }
        private void obtenerPass(string ci)
        {
            ds = N_Login.N_consulta(ci);
            txtPass1.Text = ds.Tables[0].Rows[0]["passUsuario"].ToString();

        }

        private void cargarDatos()
        {
            txtCi.Text = (string)dgvUsuarios.CurrentRow.Cells["idCedula"].Value;
            txtNom1.Text = (string)dgvUsuarios.CurrentRow.Cells["nom_pUsuario"].Value;
            txtNom2.Text = (string)dgvUsuarios.CurrentRow.Cells["nom_sUsuario"].Value;
            txtApe1.Text = (string)dgvUsuarios.CurrentRow.Cells["ape_pUsuario"].Value;
            txtApe2.Text = (string)dgvUsuarios.CurrentRow.Cells["ape_sUsuario"].Value;
            string genero = (string)dgvUsuarios.CurrentRow.Cells["genUsuario"].Value;
            DateTime fecha = (DateTime)dgvUsuarios.CurrentRow.Cells["fechaNacUsuario"].Value;
            dtpFechaN.Value = fecha.Date;
            txtCorreo.Text = (string)dgvUsuarios.CurrentRow.Cells["corUsuario"].Value;
            txtCel.Text = (string)dgvUsuarios.CurrentRow.Cells["celUsuario"].Value;
            int seguroMedico = (int)dgvUsuarios.CurrentRow.Cells["idSeguro"].Value;
            int ciudad = (int)dgvUsuarios.CurrentRow.Cells["idCiudad"].Value;
            if (genero == "F")
                cmbGenero.SelectedIndex = 0;
            if (genero == "M")
                cmbGenero.SelectedIndex = 1;
            cmbSeguro.SelectedValue = seguroMedico;
            cmbCiudad.SelectedValue = ciudad;

        }

        private void btnModificar_Click(object sender, EventArgs e)
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
            int seguro = int.Parse(cmbSeguro.SelectedValue.ToString());
            int ciudad = int.Parse(cmbCiudad.SelectedValue.ToString());
            string pass = txtPass1.Text;
            if (N_Usuario.modificarUsuario(idCedula, nom1, nom2, ape1, ape2, genero, fechaN,
                correo, cel, seguro,ciudad))
            {
                if ((N_Login.modificarPersona(idCedula, pass)))
                {
                    MessageBox.Show("Usuario: " + nom1 + " " + ape1 + " Modificado Satisfactoriamente"
                        , "Usuario Modificado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el Login", "Er006",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se pudo modifcar el Usuario", "Er007",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
            inicio();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string ci = txtCi.Text;
                if (N_Usuario.eliminarUsuario(ci))
                    if (N_Login.eliminarPersona(ci))
                    {
                        MessageBox.Show("Se ha eliminado de manera correcta el usuario:" + txtCi.Text + "'"
                          , "Usuario Eliminado",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        inicio();
                    }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al eliminar el usuario" +
                    "\nConsulta al administrador", "Er013",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                inicio();

            }

        }

        private void limpiar()
        {
            txtCi.Clear();
            txtNom1.Clear();
            txtNom2.Clear();
            txtApe1.Clear();
            txtApe2.Clear();
            txtCel.Clear();
            txtCorreo.Clear();
            txtPass1.Clear();
            DateTime hoy = DateTime.Today;
            dtpFechaN.Value = hoy.Date;
            paraAgregar();

        }
    }
}

