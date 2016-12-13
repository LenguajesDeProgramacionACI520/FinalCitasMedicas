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
        public int idSeguro { get; set; }
        public string nombreSeguro { get; set; }
        public int descuentoSeguro { get; set; }
        clsD_Seguro D_seguro = new clsD_Seguro();

        public DataSet consultaSeguro()
        {
            return (D_seguro.consultaSeguro());
        }

        public DataSet obtenerId()
        {
            return (D_seguro.obtenerId());
        }

        public bool agregarSeguro(int id, string nombre, int descuento)
        {
            idSeguro = id;
            nombreSeguro = nombre;
            descuentoSeguro = descuento;
            return (D_seguro.agregarSeguro(idSeguro, nombreSeguro, descuentoSeguro));
        }

        public bool modificarSeguro(int id, string nombre, int descuento)
        {
            idSeguro = id;
            nombreSeguro = nombre;
            descuentoSeguro = descuento;
            return (D_seguro.modificarSeguro(idSeguro, nombreSeguro, descuentoSeguro));
        }

        public bool eliminarSeguro(int id)
        {
            idSeguro = id;
            return (D_seguro.eliminarSeguro(idSeguro));
        }
    }
}
