using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class clsD_Admin
    {
        public bool verificarCi(string ci)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "SELECT count(*) FROM TblAdmin WHERE idAdmin = @idAdmin";
                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);

                comando.Parameters.Add("@idAdmin", SqlDbType.VarChar, 10, "idAdmin").Value = ci;
                Int32 count = (Int32)comando.ExecuteScalar();
                clsConexion.cerrarConexion();
                if (count == 0)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                clsConexion.cerrarConexion();
            }
        }

        
        public bool modificarAdmin(string ci, string nombre, string apellido, int genero)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblAdmin set nombre= " +
                    " @nombre, apellido=@apellido, genero=@genero where idAdmin=" + ci;

                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);

                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 20, "nombre").Value = nombre;
                comando.Parameters.Add("@apellido", SqlDbType.VarChar, 20, "apellido").Value = apellido;
                comando.Parameters.Add("@genero", SqlDbType.Int, 4, "genero").Value = genero;

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

        public bool agregarAdmin(string ci, string nombre, string apellido, int genero)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "INSERT INTO TblAdmin values(@ci,@nom,@ape,@genero)";
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);

                command.Parameters.Add("@ci", SqlDbType.VarChar, 10, "idAdmin").Value = ci;
                command.Parameters.Add("@nom", SqlDbType.VarChar, 20, "nombre").Value = nombre;
                command.Parameters.Add("@ape", SqlDbType.VarChar, 20, "apellido").Value = apellido;
                command.Parameters.Add("@genero", SqlDbType.Int, 4, "genero").Value = genero;

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

        public bool eliminarAdmin(string ci)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "DELETE FROM TblAdmin where idAdmin = " + ci;
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                clsConexion.cerrarConexion();
            }

        }

        public DataSet consultaAdmin()
        {
            try
            {
                clsConexion.abrirConexion();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter;

                string sql = "SELECT * FROM TblAdmin";
                adapter = new SqlDataAdapter(sql, clsConexion.conexion);
                adapter.Fill(ds, "TblAdmin");
                return ds;
            }
            catch(Exception ex)
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
