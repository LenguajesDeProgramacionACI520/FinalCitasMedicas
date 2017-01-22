using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Doctores
    {
        public string cedulaDoc { get; set; }
        public string nombreDoc { get; set; }
        public string apellidoDoc { get; set; }
        public string generoDoc { get; set; }
        public DateTime fechaN_Doc { get; set; }
        public string celDoc { get; set; }
        public int idHospital { get; set; }
        public int idEspecialidad { get; set; }
        public DateTime fechaC { get; set; }
        public int idHora { get; set; }
        clsD_Doctores D_Doctores = new clsD_Doctores();

        public DataSet consultaDoctores()
        {
            return D_Doctores.consultaDoctores();
        }

        public bool agregarDocotor(string cedula, string nombre, string apellido, int genero, DateTime fechaN, string cel, int idHospital, int idEspecialidad)
        {
            cedulaDoc = cedula;
            nombreDoc = nombre;
            apellidoDoc = apellido;
            if (genero == 0)
                generoDoc = "F";
            if (genero == 1)
                generoDoc = "M";
            fechaN_Doc = fechaN;
            celDoc = cel;
            this.idHospital = idHospital;
            this.idEspecialidad = idEspecialidad;
            return (D_Doctores.agregarDoctor(cedulaDoc, nombreDoc, apellidoDoc, generoDoc, fechaN_Doc, celDoc, this.idHospital, this.idEspecialidad));

        }

        public bool eliminarDoctor(string ci)
        {
            cedulaDoc = ci;
            return D_Doctores.eliminarDoctor(cedulaDoc);
        }

        public bool modificarDocotor(string cedula, string nombre, string apellido, int genero, DateTime fechaN, string cel, int idHospital, int idEspecialidad)
        {
            cedulaDoc = cedula;
            nombreDoc = nombre;
            apellidoDoc = apellido;
            if (genero == 0)
                generoDoc = "F";
            if (genero == 1)
                generoDoc = "M";
            fechaN_Doc = fechaN;
            celDoc = cel;
            this.idHospital = idHospital;
            this.idEspecialidad = idEspecialidad;
            return (D_Doctores.modificarDoctor(cedulaDoc, nombreDoc, apellidoDoc, generoDoc, fechaN_Doc, celDoc, this.idHospital, this.idEspecialidad));
        }

        public bool activarDoctor(string ci)
        {
            cedulaDoc = ci;
            return (D_Doctores.activarDoctor(cedulaDoc));
        }

        public bool desactivarDoctor(string ci)
        {
            cedulaDoc = ci;
            return (D_Doctores.desactivarDoctor(cedulaDoc));
        }

        public DataSet consultaDocHora(int esp, int hosp, DateTime fecha, int hora)
        {
            this.idEspecialidad = esp;
            this.idHora = hora;
            this.idHospital = hosp;
            this.fechaC = fecha;
            return (D_Doctores.consultaDocHora(idEspecialidad, idHospital, fechaC, idHora));
        }

        public DataSet consultaDoctores(int idDoctor)
        {
            throw new NotImplementedException();
        }
    }
}
