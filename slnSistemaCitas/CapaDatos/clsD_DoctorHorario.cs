using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_DoctorHorario
    {
        public bool comprobarRelacion(int idHora, string idDoctor)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "SELECT COUNT(*) FROM TblDoctorHora WHERE idHora = @idHora AND idDoctor = @idDoctor";
                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@idHora", SqlDbType.Int, 4, "idHora").Value = idHora;
                comando.Parameters.Add("@idDoctor", SqlDbType.Char, 10, "idDoctor").Value = idDoctor;

                Int32 count = (Int32)comando.ExecuteScalar();
                clsConexion.cerrarConexion();
                if (count == 0)
                    return true;
                else
                    return false;
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

        public bool eliminarRelacion(int idRelacion)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "DELETE FROM TblDoctorCita where idDoctorHora = " + idRelacion;
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

        public DataSet consultaRelacion()
        {
            DataSet objDatosDataSet = new DataSet();
            SqlDataAdapter adaptador;
            try
            {
                clsConexion.abrirConexion();
                string sqlConsulta = "select * from TblDoctorHora";
                adaptador = new SqlDataAdapter(sqlConsulta, clsConexion.conexion);
                adaptador.Fill(objDatosDataSet, "TblDoctorHora");
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

        public DataSet consultaId()
        {
            DataSet objDatosDataSet = new DataSet();
            SqlDataAdapter adaptador;
            try
            {
                clsConexion.abrirConexion();
                string sqlConsulta = "select max(idDoctorHora) from TblDoctorHora";
                adaptador = new SqlDataAdapter(sqlConsulta, clsConexion.conexion);
                adaptador.Fill(objDatosDataSet, "TblDoctorHora");
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

        public bool agregarRelacion(int idHora, string idDoctor)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "insert into TblDoctorHora values (@doctor,@hora)";
                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@doctor", SqlDbType.Char, 10, "idDoctor").Value = idDoctor;
                comando.Parameters.Add("@hora", SqlDbType.Int, 4, "idHora").Value = idHora;
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
