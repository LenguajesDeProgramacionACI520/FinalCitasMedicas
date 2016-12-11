using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Seguro
    {
        public DataSet consultaSeguro()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adaptador;
                clsConexion.abrirConexion();

                string sql = "SELECT * FROM TblSeguro";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblSeguro");

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
