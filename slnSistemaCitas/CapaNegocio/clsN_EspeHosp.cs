using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_EspeHosp
    {
        public int idEspeHosp { get; set; }
        public int idEspecialidad { get; set; }
        public int idHospital { get; set; }
        clsD_EspeHosp objD_EspeHosp = new clsD_EspeHosp();
    }
}
