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
    public partial class frmManejoAdmin : Form
    {
        public string userLog { get; set; }
        DataSet ds = new DataSet();
        clsN_Admin N_Admin = new clsN_Admin();
        clsN_Login N_Login = new clsN_Login();
        clsN_Genero N_Genero = new clsN_Genero();
        clsN_Usuario N_Usuario = new clsN_Usuario();
        public frmManejoAdmin(string ci)
        {
            userLog = ci;
            InitializeComponent();
        }


        private void frmManejoAdmin_Load(object sender, EventArgs e)
        {
            inicio();
        }

        private void inicio()
        {
            
            restringirCampos();
            cargarDgv();
            dgvAdmin.ReadOnly = true;
            cargarGenero();
            cargar();
            limpiar();
            txtCi.Enabled = true;

        }

        private void limpiar()
        {
            txtCi.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtPass.Clear();
        }

        private void modificar()
        {
            btnAgregar.Enabled = false;
            btnAgregar.ForeColor = Color.Silver;
            btnEliminar.Enabled = true;
            btnEliminar.ForeColor = Color.CadetBlue;
            btnModificar.Enabled = true;
            btnModificar.ForeColor = Color.CadetBlue;
            txtCi.Enabled = false;
        }

        private void cargar()
        {
            btnAgregar.Enabled = true;
            btnAgregar.ForeColor = Color.CadetBlue;
            btnEliminar.Enabled = false;
            btnEliminar.ForeColor = Color.Silver;
            btnModificar.Enabled = false;
            btnModificar.ForeColor = Color.Silver;
        }

        private void cargarGenero()
        {
            try
            {
                ds = N_Genero.consultaGenero();
                cmbGenero.DataSource = ds.Tables["TblGenero"];
                cmbGenero.ValueMember = "id";
                cmbGenero.DisplayMember = "gen_nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al Cargar el Genero \n" +
                    "Cierre y vuelva a intentarlo", "Er002",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void restringirCampos()
        {
            txtCi.MaxLength = 10;
            txtPass.MaxLength = 20;
            txtNombre.MaxLength = 20;
            txtApellido.MaxLength = 20;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtApellido.CharacterCasing = CharacterCasing.Upper;
        }

        private void cargarDgv()
        {
            try
            {
                ds = N_Admin.consultaAdmin();
                dgvAdmin.DataSource = ds;
                dgvAdmin.DataMember = "TblAdmin";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al recuperar la informacion ADMIN", "Er008",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modificar();
            try
            {
                obtenerDatos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problemas al Cargar infomración Para Editar"+
                    "\nCierre y vuelva intentarlo", "Er009",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtCi.Text.Equals(userLog))
            {
                MessageBox.Show("No se puede modificar este usuario" +
                    "\nEs el usuario actual", "No se puede modificar su propia información",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cargar();
                limpiar();
            }else
            {
                try
                {
                    obtenerPass(txtCi.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas al Cargar infomración del Login" +
                        "\nCierre y vuelva intentarlo", "Er010",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void obtenerDatos()
        {
            string ci= (string)dgvAdmin.CurrentRow.Cells["idAdmin"].Value;
            txtCi.Text = ci;
            if (!(ci.Equals(userLog)))
            {
                txtNombre.Text = (string)dgvAdmin.CurrentRow.Cells["nombre"].Value;
                txtApellido.Text = (string)dgvAdmin.CurrentRow.Cells["apellido"].Value;
                int genero = (int)dgvAdmin.CurrentRow.Cells["genero"].Value;
                cmbGenero.SelectedValue = genero;
            }
        }

        private void obtenerPass(string ci)
        {
            ds = N_Login.N_consulta(ci);
            txtPass.Text = ds.Tables[0].Rows[0]["pass"].ToString();

        }

        private void verificarCi(string ci)
        {
            if (N_Usuario.verificarCi(ci))
            {
                if (N_Admin.verificarCi(ci))
                {

                }
                else
                {
                    MessageBox.Show("Este usuario ya es administrador\n Intente Nuevamente",
                        "Er004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Este usuario ya existen\n Intente Nuevamente",
                    "Er005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string ci = txtCi.Text;
            if (txtPass.Text.Length > 6)
            {
                try
                {
                    if (N_Admin.modificarAdmin(ci, txtNombre.Text, txtApellido.Text,
                        int.Parse(cmbGenero.SelectedValue.ToString())))
                        MessageBox.Show("Se ha modificado de manera correcta el administrador" +
                          "", "Modificación Exitosa",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas al modificar el Administrador" +
                        "\nCierre y vuelva intentarlo", "Er011",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                try
                {
                    if (N_Login.modificarPersona(ci, txtPass.Text))
                        Console.WriteLine("LoginActualizado");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas al modificar el login" +
                        "\nConsulta al administrador", "Er012",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                inicio();
            }
            else
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres", "Er012",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string ci = txtCi.Text;
                if (N_Admin.eliminarAdmin(ci))
                    if (N_Login.eliminarPersona(ci))
                    {
                        MessageBox.Show("Se ha eliminado de manera correcta el administrador:" + txtCi.Text + "'"
                          , "Modificación Exitosa",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        inicio();
                    }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Problemas al eliminar el usuario" +
                    "\nConsulta al administrador", "Er013",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtCi_TextChanged(object sender, EventArgs e)
        {
            if (txtCi.Text.Length ==10 && txtCi.Enabled==true)
            {
                verificarCi(txtCi.Text);
            }
            else if(txtCi.Enabled==true)
            {
                cargar();
            }
        }

        private void txtCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Tab)
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

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtPass.Text.Length > 6)
            {
                if(txtCi.Text.Length == 10)
                {
                    if (N_Admin.agregraAdmin(txtCi.Text, txtNombre.Text, txtApellido.Text, int.Parse(cmbGenero.SelectedValue.ToString())))
                        if (N_Login.agregarPersona(txtCi.Text, txtPass.Text, 1))
                        {
                            MessageBox.Show("Se ha ingresado de manera correcta el administrador:" + txtCi.Text + ""
                              , "Nuevo Administrador",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarDgv();
                            inicio();
                            limpiar();
                        }
                }
                else
                {
                    MessageBox.Show("la cedula debe tener 10 caracteres", "Er013",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCi.Clear();

                }
            }
            else
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres", "Er012",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
            }
            

        }
    }
}
