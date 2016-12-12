using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Ciudad
    {
        clsD_Ciudad D_Ciudad = new clsD_Ciudad();
        public DataSet consultaCiudad()
        {
            return (D_Ciudad.consultaCiudad());
        }
    }
}
