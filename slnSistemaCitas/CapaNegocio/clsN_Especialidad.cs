using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Especialidad
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public float costo { get; set; }

        clsD_Especialidad D_Especialidad = new clsD_Especialidad();
        
        public DataSet consultaId()
        {
            return D_Especialidad.consultaId();
        }

        public bool agregarEspecialidad(int id, string nombre, float costo)
        {
            this.id = id;
            this.nombre = nombre;
            this.costo = costo;
            return (D_Especialidad.agregarEspecialidad(this.id, this.nombre, this.costo));
        }

        public DataSet consultaEspecialidad()
        {
            return (D_Especialidad.consultarEspecialidad());
        }

        public bool modificarEspecialidad(int id, string nombre, float costo)
        {
            this.id = id;
            this.nombre = nombre;
            this.costo = costo;
            return (D_Especialidad.modificarEspecialidad(this.id, this.nombre, this.costo));
        }

        public bool eliminarEspecialidad(int id)
        {
            this.id = id;
            return (D_Especialidad.eliminarEspecialidad(this.id));
        }
    }
}
