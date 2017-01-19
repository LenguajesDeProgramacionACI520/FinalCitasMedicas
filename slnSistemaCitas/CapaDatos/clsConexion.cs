using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class clsConexion
    {
        public static SqlConnection conexion = new SqlConnection(@"Data Source=JUANMAVIANA;Initial Catalog=dbSistemaCitas;Integrated Security=True");
        public static void abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
        }

        public static void cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }
    }
}
