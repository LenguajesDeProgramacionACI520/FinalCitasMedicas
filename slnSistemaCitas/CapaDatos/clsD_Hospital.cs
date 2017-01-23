using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Hospital
    {
        public DataSet consultaHospital()
        {

            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;
            try
            {
                clsConexion.abrirConexion();
                string sql = "select * from TblHospital ";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblHospital");
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
        public DataSet consultaHospital(int idH)
        {

            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;
            try
            {
                clsConexion.abrirConexion();
                string sql = "select * from TblHospital WHERE idHospital ="+idH;
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblHospital");
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

        public bool agregarHospital( string nombreH,string dirH, int ciudadH)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "insert into TblHospital values (@nombreH,@dirH,@ciudadH)";
                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@nombreH", SqlDbType.VarChar, 20, "nomHospital").Value = nombreH;
                comando.Parameters.Add("@dirH", SqlDbType.VarChar, 100, "dirHospital").Value = dirH;
                comando.Parameters.Add("@ciudadH", SqlDbType.Int, 4, "idCiudad").Value = ciudadH;
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

        public DataSet consultaHosCiuEsp(int especialidad, int ciudadH)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;
            try
            {
                clsConexion.abrirConexion();
                string sql = "SELECT idHospital, nomHospital FROM TblHospital h, TblEspecialidadHospital e " +
                    "WHERE h.idHospital = e.idHospital AND e.idCiudad =" + ciudadH +" AND e.idEspecialidad = "
                    + especialidad;
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblHospital , TblHospEsp");
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

        public DataSet consultarId()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;

            try
            {
                clsConexion.abrirConexion();
                string sqlCOnsulta = "select max(idHospital) from TblHospital";
                adaptador = new SqlDataAdapter(sqlCOnsulta, clsConexion.conexion);
                adaptador.Fill(ds, "TblHospital");
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
    
        public bool modificarHospital(int id, string nombreH, string dirH, int ciudadH)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblHospital set nomHospital= " +
                    " @nombreH, dirHospital=@dirH, idCiudad = @ciudadH where idHospital=" + id;

                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@nombreH", SqlDbType.VarChar, 20, "nomHospital").Value = nombreH;
                comando.Parameters.Add("@dirH", SqlDbType.VarChar, 100, "dirHospital").Value = dirH;
                comando.Parameters.Add("@ciudadH", SqlDbType.Int, 4, "idCiudad").Value = ciudadH;
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

        public bool eliminarHospital(int id)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "DELETE FROM TblHospital where idHospital = " + id;
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
