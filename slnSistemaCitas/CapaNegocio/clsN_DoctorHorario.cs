using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_DoctorHorario
    {
        public int idRelacion { get; set; }
        public int idHora { get; set; }
        public string idDoctor { get; set; }
        clsD_DoctorHorario objD_DoctorHorario = new clsD_DoctorHorario();
        public bool comprobarRelacion(int hora, string doctor)
        {
            idHora = hora;
            idDoctor = doctor;
            return (objD_DoctorHorario.comprobarRelacion(idHora, idDoctor));
        }

        public bool agregar(int hora, string doctor)
        {
            idHora = hora;
            idDoctor = doctor;
            return (objD_DoctorHorario.agregarRelacion(idHora, idDoctor));
        }

        public DataSet consultaId()
        {
            return (objD_DoctorHorario.consultaId());
        }

        public DataSet consultaRelacion()
        {
            return (objD_DoctorHorario.consultaRelacion());
        }

        public bool eliminar(int idHoraDoc)
        {
            idRelacion = idHoraDoc;
            return (objD_DoctorHorario.eliminarRelacion(idRelacion));
        }
    }
}
