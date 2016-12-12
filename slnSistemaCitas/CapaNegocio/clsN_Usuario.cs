using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Usuario
    {
        public string ci { get; set; }
        public string nom1 { get; set; }
        public string nom2 { get; set; }
        public string ape1 { get; set; }
        public string ape2 { get; set; }
        public int genero { get; set; }
        public DateTime fechaN { get; set; }
        public string correo { get; set; }
        public string cel { get; set; }
        public int seguro { get; set; }
        public int sector { get; set; }
        clsD_Usuario D_Usuario = new clsD_Usuario();

        public bool verificarCi(string ci)
        {
            this.ci = ci;
            return (D_Usuario.verificarCi(this.ci));
        }

        public bool agregarUsuario(string idCedula, string nom1, string nom2, string ape1, string ape2, int genero, DateTime fechaN, string correo, string cel, int seguroMedico, int sector)
        {
            this.ci = idCedula;
            this.nom1 = nom1;
            this.nom2 = nom2;
            this.ape1 = ape1;
            this.ape2 = ape2;
            this.genero = genero;
            this.fechaN = fechaN;
            this.correo = correo;
            this.cel = cel;
            this.seguro = seguroMedico;
            this.sector = sector;
            return (D_Usuario.agregarUsuario(ci, this.nom1, this.nom2, this.ape1, this.ape2, this.genero, this.fechaN,
                this.correo, this.cel, this.seguro, this.sector));
        }
    }
}
