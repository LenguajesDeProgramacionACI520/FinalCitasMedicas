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

        public bool agregarHospital(int id, string nombreH, int ciudadH)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "insert into TblHospital values (@idH,@nombreH,@ciudadH)";
                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@idH", SqlDbType.Int, 4, "idH").Value = id;
                comando.Parameters.Add("@nombreH", SqlDbType.VarChar, 20, "nombreH").Value = nombreH;
                comando.Parameters.Add("@ciudadH", SqlDbType.Int, 4, "ciudadH").Value = ciudadH;
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

        public DataSet consultarId()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;

            try
            {
                clsConexion.abrirConexion();
                string sqlCOnsulta = "select max(idH) from TblHospital";
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
    

        public bool modificarHospital(int id, string nombreH, int ciudadH)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblHospital set nombreH= " +
                    " @nombreH, ciudadH = @ciudadH where idH=" + id;

                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@nombreH", SqlDbType.VarChar, 20, "nombreH").Value = nombreH;
                comando.Parameters.Add("@ciudadH", SqlDbType.Int, 4, "ciudadH").Value = ciudadH;
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
                string sql = "DELETE FROM TblHospital where idH = " + id;
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
