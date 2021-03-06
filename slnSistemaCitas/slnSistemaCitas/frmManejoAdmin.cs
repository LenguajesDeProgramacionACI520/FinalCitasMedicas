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
    public partial class frmManejoAdmin : Form
    {
        public string userLog { get; set; }
        DataSet ds = new DataSet();
        clsN_Admin N_Admin = new clsN_Admin();
        clsN_Login N_Login = new clsN_Login();
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
            cargarGenero();
            restringirCampos();
            cargarDgv();
            dgvAdmin.ReadOnly = true;
            agregar();
            limpiar();

        }

        private void limpiar()
        {
            txtCi.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtPass.Clear();
            txtDireccion.Clear();
        }

        private void modificar()
        {
            btnAgregar.Enabled = false;
            btnAgregar.ForeColor = Color.Silver;
            btnEliminar.Enabled = true;
            btnEliminar.ForeColor = Color.CadetBlue;
            btnModificar.Enabled = true;
            btnModificar.ForeColor = Color.CadetBlue;
            btnAC_DC.Enabled = true;
            btnAC_DC.ForeColor = Color.CadetBlue;
            txtCi.Enabled = false;
        }

        private void agregar()
        {
            btnAgregar.Enabled = true;
            btnAgregar.ForeColor = Color.CadetBlue;
            btnEliminar.Enabled = false;
            btnEliminar.ForeColor = Color.Silver;
            btnModificar.Enabled = false;
            btnModificar.ForeColor = Color.Silver;
            btnAC_DC.Enabled = false;
            btnAC_DC.ForeColor = Color.Silver;
            txtCi.Enabled = true;
        }

        private void cargarGenero()
        {
            cmbGenero.Items.Insert(0, "FEMENINO");
            cmbGenero.Items.Insert(0, "MASCULINO");
            cmbGenero.SelectedIndex = 0;
        }

        private void restringirCampos()
        {
            txtCi.MaxLength = 10;
            txtPass.MaxLength = 20;
            txtNombre.MaxLength = 20;
            txtApellido.MaxLength = 20;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtDireccion.MaxLength = 100;
            txtDireccion.CharacterCasing = CharacterCasing.Upper;
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
                MessageBox.Show("Erro al recuperar la informacion ADMIN\n"+ex.Message, "Er008",
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
                MessageBox.Show("Problemas al Cargar infomración Para Editar\n"+ex.Message+
                    "\nCierre y vuelva intentarlo", "Er009",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtCi.Text.Equals(userLog))
            {
                MessageBox.Show("No se puede modificar este usuario" +
                    "\nEs el usuario actual", "No se puede modificar su propia información",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                agregar();
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
                        "\nCierre y vuelva intentarlo\n"+ex.Message, "Er010",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void obtenerDatos()
        {
            string ci= (string)dgvAdmin.CurrentRow.Cells["idCedula"].Value;
            txtCi.Text = ci;
            if (!(ci.Equals(userLog)))
            {
                txtNombre.Text = (string)dgvAdmin.CurrentRow.Cells["nomAdmin"].Value;
                txtApellido.Text = (string)dgvAdmin.CurrentRow.Cells["apeAdmin"].Value;
                txtDireccion.Text = (string)dgvAdmin.CurrentRow.Cells["dirAdmin"].Value;
                string gen = (string)dgvAdmin.CurrentRow.Cells["genAdmin"].Value;
                if (gen == "F")
                    cmbGenero.SelectedIndex = 0;
                if (gen == "M")
                    cmbGenero.SelectedIndex = 1;
                string ac = (string)dgvAdmin.CurrentRow.Cells["estAdmin"].Value;
                if (ac == "AC")
                    btnAC_DC.Text = "Descativar Administrador";
                if (ac == "DC")
                    btnAC_DC.Text = "Activar Administrador";
            }
        }

        private void obtenerPass(string ci)
        {
            ds = N_Login.N_consulta(ci);
            txtPass.Text = ds.Tables[0].Rows[0]["passUsuario"].ToString();

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
                MessageBox.Show("Este usuario ya existe\n Intente Nuevamente",
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
                        int.Parse(cmbGenero.SelectedIndex.ToString()), txtDireccion.Text))
                        MessageBox.Show("Se ha modificado de manera correcta el administrador" +
                          "", "Modificación Exitosa",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas al modificar el Administrador" +
                        "\nCierre y vuelva intentarlo\n" + ex.Message, "Er011",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();

                }
                try
                {
                    if (N_Login.modificarPersona(ci, txtPass.Text))
                        Console.WriteLine("LoginActualizado");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas al modificar el login" +
                        "\nConsulta al administrador\n" + ex.Message, "Er012",
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
                          , "Administrador Eliminado",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        inicio();
                    }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Problemas al eliminar el usuario" +
                    "\nConsulta al administrador\n" + ex.Message, "Er013",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();

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
                agregar();
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
            if(txtPass.Text.Length >=6)
            {
                if(txtCi.Text.Length == 10)
                {
                    if (N_Admin.agregraAdmin(txtCi.Text, txtNombre.Text, txtApellido.Text, int.Parse(cmbGenero.SelectedIndex.ToString()),txtDireccion.Text))
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void soloNumero(object sender, KeyPressEventArgs e)
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

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender,e);
        }

        private void btnAC_DC_Click(object sender, EventArgs e)
        {
            if(btnAC_DC.Text.Equals("Descativar Administrador"))
            {
                try
                {
                    if (N_Admin.desactivarAdmin(txtCi.Text))
                        MessageBox.Show("Se ha descativado de manera correcta el Administrador" + txtCi.Text + ""
                              , "Administrador Descativado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inicio();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas al desactivar el Administrador" +
                        "\n"+ex.Message, "Er050",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inicio();
                }

            }
            if (btnAC_DC.Text.Equals("Activar Administrador"))
            {
                try
                {
                    if (N_Admin.activarAdmin(txtCi.Text))
                        MessageBox.Show("Se ha activado de manera correcta el Administrador" + txtCi.Text + ""
                              , "Administrador Activado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
