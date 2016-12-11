using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class clsD_Genero
    {
        public DataSet consultaGenero()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adaptador;

                clsConexion.abrirConexion();
                string sql = "SELECT * FROM TblGenero";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblGenero");
                clsConexion.cerrarConexion();
                return ds;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                clsConexion.cerrarConexion();
            }
        }
    }
}
