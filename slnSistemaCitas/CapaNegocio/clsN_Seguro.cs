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
        public decimal descuentoSeguro { get; set; }
        public decimal valorSeguro { get; set; }
        clsD_Seguro D_seguro = new clsD_Seguro();

        public DataSet consultaSeguro()
        {
            return (D_seguro.consultaSeguro());
        }

        public DataSet obtenerId()
        {
            return (D_seguro.obtenerId());
        }

        public bool agregarSeguro(int id, string nombre, decimal descuento,decimal valor)
        {
            idSeguro = id;
            nombreSeguro = nombre;
            descuentoSeguro = descuento;
            valorSeguro = valor;
            return (D_seguro.agregarSeguro(idSeguro, nombreSeguro, descuentoSeguro, valor));
        }

        public bool modificarSeguro(int id, string nombre, decimal descuento, decimal valor)
        {
            idSeguro = id;
            nombreSeguro = nombre;
            descuentoSeguro = descuento;
            valorSeguro = valor;
            return (D_seguro.modificarSeguro(idSeguro, nombreSeguro, descuentoSeguro, valor));
        }

        public bool eliminarSeguro(int id)
        {
            idSeguro = id;
            return (D_seguro.eliminarSeguro(idSeguro));
        }

        public DataSet consultaSeguro(int idSeguro)
        {
            throw new NotImplementedException();
        }
    }
}
