using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Admin
    {
        public string ci { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int genero { get; set; }

        clsD_Admin D_Admin = new clsD_Admin();

        public bool verificarCi(string ci)
        {
            this.ci = ci;
            return (D_Admin.verificarCi(this.ci));
            
        }

        public DataSet consultaAdmin()
        {
            return D_Admin.consultaAdmin();
        }
        
        public bool modificarAdmin(string ci, string nom, string ape, int genero)
        {
            this.ci = ci;
            this.nombre = nom;
            apellido = ape;
            this.genero = genero;
            return(D_Admin.modificarAdmin(this.ci, nombre, apellido, this.genero));
        }

        public bool eliminarAdmin(string ci)
        {
            this.ci = ci;
            return (D_Admin.eliminarAdmin(this.ci));
        }

        public bool agregraAdmin(string ci, string nombre ,string apellido, int v)
        {
            this.ci = ci;
            this.nombre = nombre;
            this.apellido = apellido;
            genero = v;
            return (D_Admin.agregarAdmin(this.ci, this.nombre, this.apellido, genero));
        }
    }
}
