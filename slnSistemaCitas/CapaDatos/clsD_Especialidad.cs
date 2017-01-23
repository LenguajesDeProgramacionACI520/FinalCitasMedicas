using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Especialidad
    {
        public DataSet consultaId()
        {
            DataSet objDatosDataSet = new DataSet();
            SqlDataAdapter adaptador;

            try
            {
                clsConexion.abrirConexion();
                string sqlCOnsulta = "select max(idEspecialidad) from TblEspecialidad";
                adaptador = new SqlDataAdapter(sqlCOnsulta, clsConexion.conexion);
                adaptador.Fill(objDatosDataSet, "TblEspecialidad");
                return objDatosDataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                clsConexion.cerrarConexion();
            }
        }

        public bool agregarEspecialidad( string nombre, string desc ,decimal costo, int idProm)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "insert into TblEspecialidad values (@nombre,@desc,@costo,@idProm)";
                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nomEspecialidad").Value = nombre;
                comando.Parameters.Add("@desc", SqlDbType.VarChar, 500, "descEspecialidad").Value = desc;
                comando.Parameters.Add("@idProm", SqlDbType.Int, 4, "idPromocion").Value = idProm;
                //Agregar costo, Valor decimal
                SqlParameter param = new SqlParameter("@costo", SqlDbType.Decimal);
                param.SourceColumn = "costoEspecialidad";
                param.Precision = 10;
                param.Scale = 2;
                comando.Parameters.Add(param).Value = costo;

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

        public DataSet consultarEspecialidad(int id)
        {
            try
            {
                clsConexion.abrirConexion();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter;
                string sql = "SELECT * FROM TblEspecialidad WHERE idEspecialidad = "+id;
                adapter = new SqlDataAdapter(sql, clsConexion.conexion);
                adapter.Fill(ds, "TblEspecialidad");
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

        public bool modificarEspecialidad(int id, string nombre, string desc, decimal costo, int idProm)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblEspecialidad set nomEspecialidad= " +
                    " @nombre, descEpecialidad=@desc, costoEspecialidad=@costo, idPromocion=@idProm" +
                    "WHERE idEspecialidad =" + id;

                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 20, "nomEspecialidad").Value = nombre;
                comando.Parameters.Add("@desc", SqlDbType.VarChar, 500, "descEspecialidad").Value = desc;
                comando.Parameters.Add("@idProm", SqlDbType.Int, 4, "idPromocion").Value = idProm;
                //Agregar costo, Valor decimal
                SqlParameter param = new SqlParameter("@costo", SqlDbType.Decimal);
                param.SourceColumn = "costoEspecialidad";
                param.Precision = 10;
                param.Scale = 2;
                comando.Parameters.Add(param).Value=costo;

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

        public bool eliminarEspecialidad(int id)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "DELETE FROM TblEspecialidad where idEspecialidad = " + id;
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

        public DataSet consultarEspecialidad()
        {
            try
            {
                clsConexion.abrirConexion();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter;
                string sql = "SELECT * FROM TblEspecialidad";
                adapter = new SqlDataAdapter(sql, clsConexion.conexion);
                adapter.Fill(ds, "TblEspecialidad");
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
