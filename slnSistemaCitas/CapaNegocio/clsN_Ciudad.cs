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
        public int idCiudad { get; set; }

        public DataSet consultaCiudad()
        {
            return (D_Ciudad.consultaCiudad());
        }

        public DataSet consultaCiuEsp()
        {
            throw new NotImplementedException();
        }

        public DataSet consultaCiudad(int idCiudad)
        {
            this.idCiudad = idCiudad;
            return (D_Ciudad.consultaCiudad(this.idCiudad));
        }
    }
}
