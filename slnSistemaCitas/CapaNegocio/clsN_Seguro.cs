using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsN_Seguro
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int descuento { get; set; }
        clsD_Seguro D_seguro = new clsD_Seguro();

        public DataSet consultaSeguro()
        {
            return (D_seguro.consultaSeguro());
        }
    }
}
