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

        public DataSet obtenerId()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;

            try
            {
                clsConexion.abrirConexion();
                string sql = "select max(idSeguro) from TblSeguro";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblSeguro");
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

        public bool agregarSeguro(int idSeguro, string nombreSeguro, decimal descuentoSeguro, decimal valor)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "insert into TblSeguro values (@id,@nombre,@descuento,@costo)";
                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@id", SqlDbType.Int, 4, "idSeguro").Value = idSeguro;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 20, "nomSeguro").Value = nombreSeguro;

                SqlParameter param = new SqlParameter("@descuento", SqlDbType.Decimal);
                param.SourceColumn = "porcenSeguro";
                param.Precision = 5;
                param.Scale = 2;
                comando.Parameters.Add(param).Value = descuentoSeguro;

                param = new SqlParameter("@costo", SqlDbType.Decimal);
                param.SourceColumn = "valorSeguro";
                param.Precision = 10;
                param.Scale = 2;
                comando.Parameters.Add(param).Value = valor;

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;

            }
            finally
            {
                clsConexion.cerrarConexion();
            }
        }

        public bool modificarSeguro(int idSeguro, string nombreSeguro, decimal descuentoSeguro, decimal valor)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblSeguro set nomSeguro= " +
                    " @nombre, porcenSeguro=@descuento, valorSeguro=@costo where idSeguro=" + idSeguro;

                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 20, "nomSeguro").Value = nombreSeguro;

                SqlParameter param = new SqlParameter("@descuento", SqlDbType.Decimal);
                param.SourceColumn = "porcenSeguro";
                param.Precision = 5;
                param.Scale = 2;
                comando.Parameters.Add(param).Value = descuentoSeguro;

                param = new SqlParameter("@costo", SqlDbType.Decimal);
                param.SourceColumn = "valorSeguro";
                param.Precision = 10;
                param.Scale = 2;
                comando.Parameters.Add(param).Value = valor;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                clsConexion.cerrarConexion();
            }

        }

        public bool eliminarSeguro(int idSeguro)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "DELETE FROM TblSeguro where idSeguro = " + idSeguro;
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                clsConexion.cerrarConexion();
            }
        }
    }
}
