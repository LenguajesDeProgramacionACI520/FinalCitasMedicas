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
                string sqlCOnsulta = "select max(id) from TblEspecialidad";
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

        public bool agregarEspecialidad(int id, string nombre, float costo, int descuento)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "insert into TblEspecialidad values (@id,@nombre,@costo,@descuento)";
                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@id", SqlDbType.Int, 4, "id").Value = id;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre").Value = nombre;
                comando.Parameters.Add("@costo", SqlDbType.Float, 6, "costo").Value = costo;
                comando.Parameters.Add("@descuento", SqlDbType.Int, 4, "descuento").Value = descuento;
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

        public bool modificarEspecialidad(int id, string nombre, float costo, int descuento)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblEspecialidad set nombre= " +
                    " @nombre, costo=@costo, descuento=@descuento where id=" + id;

                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre").Value = nombre;
                comando.Parameters.Add("@costo", SqlDbType.Float, 6, "costo").Value = costo;
                comando.Parameters.Add("@descuento", SqlDbType.Int, 4, "descuento").Value = descuento;
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
                string sql = "DELETE FROM TblEspecialidad where id = " + id;
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
