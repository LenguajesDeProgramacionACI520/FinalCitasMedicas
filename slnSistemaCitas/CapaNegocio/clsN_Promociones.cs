using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    
    public class clsN_Promociones
    {
        public int idP { get; set; }
        public string nombreP { get; set; }
        public decimal descuentoP { get; set; }

        clsD_Promociones D_Promociones = new clsD_Promociones();

        public DataSet obtenerId()
        {
            return D_Promociones.obtenerId();
        }

        public DataSet consultaPromociones()
        {
            return D_Promociones.consultaPromociones();
        }

        public bool agregarPromocion(string nombre, decimal descuento)
        {
            nombreP = nombre;
            descuentoP = descuento;
            return (D_Promociones.agregarPromocion(nombreP, descuentoP));
        }

        public bool modificarPromocion(int id, string nombre, decimal descuento)
        {
            idP = id;
            nombreP = nombre;
            descuentoP = descuento;
            return (D_Promociones.modificarPromocion(idP, nombreP, descuentoP));
        }

        public bool eliminarPromocion(int id)
        {
            idP = id;
            return (D_Promociones.eliminarPromocion(idP));
        }
    }
}
