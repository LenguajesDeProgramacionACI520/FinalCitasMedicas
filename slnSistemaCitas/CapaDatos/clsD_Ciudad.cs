using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Ciudad
    {
        public DataSet consultaCiudad()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adaptador;

                clsConexion.abrirConexion();
                string sql = "SELECT * FROM TblCiudad";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblCiudad");
                clsConexion.cerrarConexion();
                return ds;
            }
            catch(Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                clsConexion.cerrarConexion();
            }
        }

        public DataSet consultaCiudad(int idCiudad)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adaptador;

                clsConexion.abrirConexion();
                string sql = "SELECT * FROM TblCiudad WHERE idCiudad ="+idCiudad;
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblCiudad");
                clsConexion.cerrarConexion();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                clsConexion.cerrarConexion();
            }
        }
    }
}
