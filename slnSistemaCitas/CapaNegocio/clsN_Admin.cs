using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Admin
    {
        string ci = "";
        string nombre = "";
        string apellido = "";
        int genero = 0;
        clsD_Admin D_Admin = new clsD_Admin();
        public bool verificarCi(string ci)
        {
            this.ci = ci;
            return (D_Admin.verificarCi(this.ci));
            
        }
    }
}
