using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using System.Windows.Forms;

namespace slnSistemaCitas
{
    public class clsValidaciones
    {
        public void soloNumero(object sender, KeyPressEventArgs e)
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

        public void soloLetras(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            else
            {
                e.Handled = true;
            }
        }

        public void soloLetrasEspacio(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Tab
                || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
