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
        public int ciudadH { get; set; }

        clsD_Hospital D_Hospitales = new clsD_Hospital();

        public DataSet consultaHospitales()
        {
            return D_Hospitales.consultaHospital();
        }

        public bool agregarHospital(int id, string nombre, int ciudad)
        {
            idH = id;
            nombreH = nombre;
            ciudadH = ciudad;
            return D_Hospitales.agregarHospital(idH, nombreH, ciudadH);
        }

        public bool modificarHospital(int id, string nombre, int ciudad)
        {
            idH = id;
            nombreH = nombre;
            ciudadH = ciudad;
            return D_Hospitales.modificarHospital(idH, nombreH, ciudadH);
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
    }

}
