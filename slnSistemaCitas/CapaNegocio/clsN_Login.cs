using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Login
    {
        clsD_Login login = new clsD_Login();
        public string usuario { get; set; }
        public string password { get; set; }
        public int rol { get; set; }

        public bool N_ingreso(string ci, string pass)
        {
            usuario = ci;
            password = pass;
            Console.WriteLine(ci + "," + password);
            return (login.D_ingreso(usuario, password));
        }

        public DataSet N_consulta(string ci)
        {
            usuario = ci;
            return (login.D_consulta(usuario));
        }

        public bool agregarPersona(string idCedula, string pass, int v)
        {
            usuario = idCedula;
            password = pass;
            rol = v;
            return login.agregarPersona(usuario, password, rol);
        }

        public bool eliminarPersona(string ci)
        {
            this.usuario = ci;
            return (login.eliminarPersona(usuario));
        }

        public bool modificarPersona(string ci, string pass)
        {
            this.usuario = ci;
            this.password = pass;
            return(login.modificarPersona(usuario, password));
        }
    }
}
