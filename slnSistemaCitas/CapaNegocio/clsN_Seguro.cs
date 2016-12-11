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
        int codigo = 0;
        string nombre = "";
        int descuento = 0;
        clsD_Seguro D_seguro = new clsD_Seguro();

        public DataSet consultaSeguro()
        {
            return (D_seguro.consultaSeguro());
        }
    }
}
