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
        string usuario = "";
        string password = "";
        int rol = 0;

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
            Console.WriteLine("Consutla: " + usuario);
            return (login.D_consulta(usuario));
        }

        public bool agregarPersona(string idCedula, string pass, int v)
        {
            usuario = idCedula;
            password = pass;
            rol = v;
            return login.agregarPersona(usuario, password, rol);
        }
    }
}
