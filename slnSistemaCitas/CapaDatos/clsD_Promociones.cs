using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Promociones
    {
        public DataSet obtenerId()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;

            try
            {
                clsConexion.abrirConexion();
                string sql = "select max(idPromocion) from TblPromocion";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblPromocion");
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

        public bool agregarPromocion( string nombreP, decimal descuentoP)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "insert into TblPromocion values (@nombre,@descuento)";
                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 20, "nomPromocion").Value = nombreP;

                SqlParameter param = new SqlParameter("@descuento", SqlDbType.Decimal);
                param.SourceColumn = "descuPromocion";
                param.Precision = 5;
                param.Scale = 2;
                comando.Parameters.Add(param).Value = descuentoP;
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

        public DataSet consultaPromociones()
        {
            try
            {
                clsConexion.abrirConexion();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter;
                string sql = "SELECT * FROM TblPromocion";
                adapter = new SqlDataAdapter(sql, clsConexion.conexion);
                adapter.Fill(ds, "TblPromocion");
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

        public bool eliminarPromocion(int idP)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "DELETE FROM TblPromocion where idPromocion = " + idP;
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

        public bool modificarPromocion(int idP, string nombreP, decimal descuentoP)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblPromocion set nomPromocion= " +
                    " @nombre, descuPromocion=@descuento where idPromocion=" + idP;

                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 20, "nomPromocion").Value = nombreP;
                SqlParameter param = new SqlParameter("@descuento", SqlDbType.Decimal);
                param.SourceColumn = "descuPromocion";
                param.Precision = 5;
                param.Scale = 2;
                comando.Parameters.Add(param).Value = descuentoP;
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
    }
}
