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
        public string genero { get; set; }
        public string direccion { get; set; }

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
        
        public bool modificarAdmin(string ci, string nom, string ape, int genero, string direc)
        {
            this.ci = ci;
            this.nombre = nom;
            apellido = ape;
            if (genero == 0)
                this.genero = "F";
            if (genero == 1)
                this.genero = "M";
            direccion = direc;
            return (D_Admin.modificarAdmin(this.ci, nombre, apellido, this.genero, direccion));
        }

        public bool eliminarAdmin(string ci)
        {
            this.ci = ci;
            return (D_Admin.eliminarAdmin(this.ci));
        }

        public bool agregraAdmin(string ci, string nombre ,string apellido, int genero,string direc)
        {
            this.ci = ci;
            this.nombre = nombre;
            this.apellido = apellido;
            if (genero == 0)
                this.genero = "F";
            if (genero == 1)
                this.genero = "M";
            direccion = direc;
            return (D_Admin.agregarAdmin(this.ci, this.nombre, this.apellido, this.genero, direccion));
        }

        public bool activarAdmin(string ci)
        {
            this.ci = ci;
            return(D_Admin.activarAdmin(this.ci));
        }
        public bool desactivarAdmin(string ci)
        {
            this.ci = ci;
            return (D_Admin.desactivarAdmin(this.ci));
        }
    }
}
