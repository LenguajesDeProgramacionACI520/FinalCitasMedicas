using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class clsN_ConsultaMedica
    {
        clsD_ConsutlaMedica objD_ConsultaMedica = new clsD_ConsutlaMedica();
        public int idCita { get; set; }
        public int idUsaruio { get; set; }
        public int idDoctor { get; set; }
        public DateTime fechaCita { get; set; }
        public int idHora { get; set; }
        public string estCita { get; set; }
        public bool agregarCita(int idUser, int idDoctor, DateTime fechaCita, int idHora, string estCita)
        {
            idUsaruio = idUser;
            this.idDoctor = idDoctor;
            this.idHora = idHora;
            this.fechaCita = fechaCita;
            this.estCita = estCita;
            return (objD_ConsultaMedica.agregarCita(idUsaruio, this.idDoctor, this.fechaCita, this.idHora, this.estCita));
        }

        public DataSet consultaId()
        {
            return (objD_ConsultaMedica.consultarid());
        }

        public void eliminarCita(int idCita)
        {
            throw new NotImplementedException();
        }

        public DataSet consultaCita(int idCita)
        {
            throw new NotImplementedException();
        }
    }
}
