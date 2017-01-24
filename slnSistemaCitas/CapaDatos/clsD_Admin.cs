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
                string sql = "SELECT count(*) FROM TblAdmin WHERE idCedula = @idCedula";
                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);

                comando.Parameters.Add("@idCedula", SqlDbType.Char, 10, "idCedula").Value = ci;
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

        
        public bool modificarAdmin(string ci, string nombre, string apellido, string genero, string direccion)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblAdmin set nomAdmin= " +
                    " @nombre, apeAdmin=@apellido, genAdmin=@genero, dirAdmin=@direccion where idCedula=" + ci;

                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);

                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 20, "nomAdmin").Value = nombre;
                comando.Parameters.Add("@apellido", SqlDbType.VarChar, 20, "apeAdmin").Value = apellido;
                comando.Parameters.Add("@genero", SqlDbType.Char, 1, "genAdmin").Value = genero;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar, 100, "dirAdmin").Value = direccion;
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

        public bool agregarAdmin(string ci, string nombre, string apellido, string genero, string direccion)
        {
            string ac = "AC";
            try
            {
                clsConexion.abrirConexion();
                string sql = "INSERT INTO TblAdmin values(@ci,@nom,@ape,@gen,@dir,@est)";
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);

                command.Parameters.Add("@ci", SqlDbType.Char, 10, "idCedula").Value = ci;
                command.Parameters.Add("@nom", SqlDbType.VarChar, 20, "nomAdmin").Value = nombre;
                command.Parameters.Add("@ape", SqlDbType.VarChar, 20, "apeAdmin").Value = apellido;
                command.Parameters.Add("@gen", SqlDbType.Char, 1, "genAdmin").Value = genero;
                command.Parameters.Add("@dir", SqlDbType.VarChar, 100, "dirAdmin").Value = direccion;
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estAdmin").Value = ac;

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
                string sql = "DELETE FROM TblAdmin where idCedula = " + ci;
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

        public bool desactivarAdmin(string ci)
        {
            string dc = "DC";
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblAdmin set estAdmin=@est where idCedula = " + ci;
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estAdmin").Value = dc;
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
        public bool activarAdmin(string ci)
        {
            string ac = "AC";
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblAdmin set estAdmin=@est where idCedula = " + ci;
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estAdmin").Value = ac;
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
