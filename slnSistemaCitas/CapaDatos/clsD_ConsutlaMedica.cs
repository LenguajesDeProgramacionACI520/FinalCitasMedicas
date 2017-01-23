using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_ConsutlaMedica
    {
        public DataSet consultarid()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;
            try
            {
                clsConexion.abrirConexion();
                string sqlCOnsulta = "select max(idCita) from TblCita";
                adaptador = new SqlDataAdapter(sqlCOnsulta, clsConexion.conexion);
                adaptador.Fill(ds, "TblCita");
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
        public bool agregarCita(string idUsaruio, string idDoctor, DateTime fechaCita, int idHora, string estCita)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "INSERT INTO TblCita values(@fecha,@est,@hora,@user,@doc)";
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);

                command.Parameters.Add("@fecha", SqlDbType.DateTime, 5, "fechaCita").Value = fechaCita;
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estCita").Value = estCita;
                command.Parameters.Add("@hora", SqlDbType.Int, 4, "idHora").Value = idHora;
                command.Parameters.Add("@user", SqlDbType.Char, 10, "idUsuario").Value = idUsaruio;
                command.Parameters.Add("@doc", SqlDbType.Char, 10, "idDoctor").Value = idDoctor;

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

        public bool eliminarCita(int idCita)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "DELETE FROM TblCita where idCita = " + idCita;
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

        public bool modificarCita(int idCita, string idUsaruio, string idDoctor, DateTime fechaCita, int idHora, string estCita)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblAdmin set fechaCita= " +
                    " @fecha, estCita=@est, idHora=@hora, idUsuario=@user, idDcotor=@doc where idCita=" + idCita;

                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                
                command.Parameters.Add("@fecha", SqlDbType.DateTime, 5, "fechaCita").Value = fechaCita;
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estCita").Value = estCita;
                command.Parameters.Add("@hora", SqlDbType.Int, 4, "idHora").Value = idHora;
                command.Parameters.Add("@user", SqlDbType.Char, 10, "idUsuario").Value = idUsaruio;
                command.Parameters.Add("@doc", SqlDbType.Char, 10, "idDoctor").Value = idDoctor;

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
        public bool desactivarCita(int idCita)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblCita set estAdmin=@est where idCita = " + idCita;
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estCita").Value = "DC";
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

        public bool activarCita(int idCita)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblCita set estAdmin=@est where idCita = " + idCita;
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estCita").Value = "AC";
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

        public DataSet consultaCita(int idCita)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adaptador;

                clsConexion.abrirConexion();
                string sql = "SELECT * FROM TblCita";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblCita");
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
