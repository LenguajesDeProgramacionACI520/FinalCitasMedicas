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
        public decimal costo { get; set; }
        public string descrip { get; set; }
        public int idProm { get; set; }

        clsD_Especialidad D_Especialidad = new clsD_Especialidad();
        
        public DataSet consultaId()
        {
            return D_Especialidad.consultaId();
        }

        public bool agregarEspecialidad( string nombre,string desc, decimal costo, int prom)
        {
            this.nombre = nombre;
            this.costo = costo;
            descrip = desc;
            idProm = prom;
            return (D_Especialidad.agregarEspecialidad( this.nombre,descrip, this.costo, idProm));
        }

        public DataSet consultaEspecialidad()
        {
            return (D_Especialidad.consultarEspecialidad());
        }
        public DataSet consultaEspecia(int idEsp)
        {
            id = idEsp;
            return (D_Especialidad.consultarEspecialidad(id));
        }

        public bool modificarEspecialidad(int id, string nombre, string desc, decimal costo, int prom)
        {
            this.id = id;
            this.nombre = nombre;
            this.costo = costo;
            descrip = desc;
            idProm = prom;
            return (D_Especialidad.modificarEspecialidad(this.id, this.nombre, descrip, this.costo, idProm));
        }

        public bool eliminarEspecialidad(int id)
        {
            this.id = id;
            return (D_Especialidad.eliminarEspecialidad(this.id));
        }

        public DataSet consultaEspecialidad(int idEsp)
        {
            id = idEsp;
            return (D_Especialidad.consultarEspecialidad(id));
        }
    }
}
