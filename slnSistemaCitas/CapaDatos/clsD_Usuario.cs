using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class clsD_Usuario
    {
        public bool verificarCi(string ci)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "SELECT COUNT(*) FROM TblUsuario WHERE idCedula = @idCedula";
                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);

                comando.Parameters.Add("@idCedula", SqlDbType.VarChar, 10, "idCedula").Value = ci;

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
                throw ex;

            }
            finally
            {
                clsConexion.cerrarConexion();
            }
        }

        public bool agregarUsuario(string ci, string nom1, string nom2, string ape1, string ape2, string genero, DateTime fechaN, string correo, string cel, int seguro, int ciudad)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "INSERT INTO TblUsuario values(@ci,@nom1,@nom2,@ape1,@ape2,@genero,@fechaN,"+
                    "@correo,@cel,@seguro,@ciudad)";
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);

                command.Parameters.Add("@ci", SqlDbType.Char,10, "idCedula").Value = ci;
                command.Parameters.Add("@nom1", SqlDbType.VarChar, 20, "nom_pUsuario").Value = nom1;
                command.Parameters.Add("@nom2", SqlDbType.VarChar, 20, "nom_sUsuario").Value = nom2;
                command.Parameters.Add("@ape1", SqlDbType.VarChar, 20, "ape_pUsuario").Value = ape1;
                command.Parameters.Add("@ape2", SqlDbType.VarChar, 20, "ape_Usuario").Value = ape2;
                command.Parameters.Add("@genero", SqlDbType.Char, 1, "genUsuario").Value = genero;
                command.Parameters.Add("@fechaN", SqlDbType.DateTime, 5, "fechaNacUsuario").Value = fechaN;
                command.Parameters.Add("@correo", SqlDbType.VarChar, 50, "corUsuario").Value = correo;
                command.Parameters.Add("@cel", SqlDbType.Char, 10, "celUsuario").Value = cel;
                command.Parameters.Add("@seguro", SqlDbType.Int, 4, "idSeguro").Value = seguro;
                command.Parameters.Add("@ciudad", SqlDbType.Int, 4, "idCiudad").Value = ciudad;

                command.ExecuteNonQuery();
                return true;

            }
            catch(Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                clsConexion.cerrarConexion();
            }
        }

        public bool cambiarSeguro(int id)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblUsuario set idSeguro = @seguro where seguroMedico=" + id;
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.Parameters.Add("@seguro", SqlDbType.Int, 4, "idSeguro").Value = 1;
                command.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                clsConexion.cerrarConexion();
            }

        }

        public bool eliminarUsuario(string ci)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "DELETE FROM TblUsuario where idCedula = " + ci;
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.ExecuteNonQuery();
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

        public bool modificarUsuario(string ci, string nom1, string nom2, string ape1, string ape2, string genero, DateTime fechaN, string correo, string cel, int seguro, int ciudad)
        {

            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblUsuario set nom_pUsuario= " +
                    " @nom1, nom_sUsuario=@nom2, ape_pUsuario=@ape1, ape_sUsuario=@ape2,"+
                    "genUsuario=@genero, fechaNacUsuario=@fechaN, corUsuario=@correo, cel=@cel,"+
                    "idSeguro= @seguro, idCiudad=@ciudad where idCedula=" + ci;

                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);

                command.Parameters.Add("@nom1", SqlDbType.VarChar, 20, "nom_pUsuario").Value = nom1;
                command.Parameters.Add("@nom2", SqlDbType.VarChar, 20, "nom_sUsuario").Value = nom2;
                command.Parameters.Add("@ape1", SqlDbType.VarChar, 20, "ape_pUsuario").Value = ape1;
                command.Parameters.Add("@ape2", SqlDbType.VarChar, 20, "ape_Usuario").Value = ape2;
                command.Parameters.Add("@genero", SqlDbType.Char, 1, "genUsuario").Value = genero;
                command.Parameters.Add("@fechaN", SqlDbType.DateTime, 5, "fechaNacUsuario").Value = fechaN;
                command.Parameters.Add("@correo", SqlDbType.VarChar, 50, "corUsuario").Value = correo;
                command.Parameters.Add("@cel", SqlDbType.Char, 10, "celUsuario").Value = cel;
                command.Parameters.Add("@seguro", SqlDbType.Int, 4, "idSeguro").Value = seguro;
                command.Parameters.Add("@ciudad", SqlDbType.Int, 4, "idCiudad").Value = ciudad;
                command.ExecuteNonQuery();
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

        public DataSet consultaUsuarios()
        {
            try
            {
                clsConexion.abrirConexion();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter;
                string sql = "SELECT * FROM TblUsuario";
                adapter = new SqlDataAdapter(sql, clsConexion.conexion);
                adapter.Fill(ds, "TblUsuario");
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
        public DataSet consultaUsuarios(string idCedula)
        {
            try
            {
                clsConexion.abrirConexion();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter;
                string sql = "SELECT * FROM TblUsuario WHERE idCedula = "+idCedula;
                adapter = new SqlDataAdapter(sql, clsConexion.conexion);
                adapter.Fill(ds, "TblUsuario");
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
