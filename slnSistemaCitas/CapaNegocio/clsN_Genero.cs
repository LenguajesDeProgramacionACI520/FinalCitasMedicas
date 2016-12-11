using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class clsN_Genero
    {
        int codigo = 0;
        clsD_Genero D_genero = new clsD_Genero();
        public DataSet consultaGenero()
        {
            return (D_genero.consultaGenero());
        }
    }
}
