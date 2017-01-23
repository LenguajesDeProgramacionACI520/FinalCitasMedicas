using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Hora
    {
        public int idHora { get; set; }
        public string hora { get; set; }
        public string estHora { get; set; }
        clsD_Hora objD_Hora = new clsD_Hora();
        public DataSet consultaHoraAc()
        {
            return (objD_Hora.consultaHoraAc());
        }

        public DataSet consultaHora(int idHora)
        {
            this.idHora = idHora;
            return (objD_Hora.consultaHora(this.idHora));
        }
    }
}
