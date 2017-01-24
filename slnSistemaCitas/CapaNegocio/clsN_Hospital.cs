using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Hospital
    {
        public int idH { get; set; }
        public string nombreH { get; set; }
        public string direccionH { get; set; }
        public int ciudadH { get; set; }
        public int especialidad { get; set; }

        clsD_Hospital D_Hospitales = new clsD_Hospital();

        public DataSet consultaHospitales()
        {
            return D_Hospitales.consultaHospital();
        }

        public bool agregarHospital( string nombre, string direccion, int ciudad)
        {
            nombreH = nombre;
            direccionH = direccion;
            ciudadH = ciudad;
            return D_Hospitales.agregarHospital( nombreH, direccionH, ciudadH);
        }

        public bool modificarHospital(int id, string nombre, string direccion, int ciudad)
        {
            idH = id;
            nombreH = nombre;
            direccionH = direccion;
            ciudadH = ciudad;
            return D_Hospitales.modificarHospital(idH, nombreH, direccionH, ciudadH);
        }

        public bool eliminarHospital(int id)
        {
            idH = id;
            return D_Hospitales.eliminarHospital(idH);
        }

        public DataSet consultaId()
        {
            return D_Hospitales.consultarId();
        }

        public DataSet consultaHosCiuEsp(int idEspecialidad, int idCiudad)
        {
            this.ciudadH = idCiudad;
            this.especialidad = idEspecialidad;
            return (D_Hospitales.consultaHosCiuEsp(especialidad, ciudadH));
        }

        public DataSet consultaHospitales(int idHos)
        {
            idH = idHos;
            return (D_Hospitales.consultaHospital(idH));
        }

        public DataSet consultaHospitalesCiudad(int idCiudad)
        {
            ciudadH = idCiudad;
            return (D_Hospitales.consultaHospitalCiudad(ciudadH));
        }
    }

}
