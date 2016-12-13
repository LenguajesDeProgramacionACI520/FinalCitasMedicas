using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Doctores
    {
        public DataSet consultaDoctores()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;
            try
            {
                clsConexion.abrirConexion();
                string sql = "select * from TblDoctores ";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblDoctores");
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

        public bool agregarDoctor(string cedulaDoc1, string nombreDoc, string apellidoDoc, int generoDoc, DateTime fechaN_Doc, string celDoc, int idHospital, int idEspecialidad)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "INSERT INTO TblDoctores values(@ci,@nom,@ape,@genero,@fechaN," +
                    "@cel,@idH,@idE)";
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);

                command.Parameters.Add("@ci", SqlDbType.VarChar, 10, "cedulaDoc").Value = cedulaDoc1;
                command.Parameters.Add("@nom", SqlDbType.VarChar, 20, "nombreDoc").Value = nombreDoc;
                command.Parameters.Add("@ape", SqlDbType.VarChar, 20, "apellidoDoc").Value = apellidoDoc;
                command.Parameters.Add("@genero", SqlDbType.Int, 4, "generoDoc").Value = generoDoc;
                command.Parameters.Add("@fechaN", SqlDbType.DateTime, 5, "fechaN_Doc").Value = fechaN_Doc;
                command.Parameters.Add("@cel", SqlDbType.VarChar, 9, "cel").Value = celDoc;
                command.Parameters.Add("@idH", SqlDbType.Int, 4, "seguroMedico").Value = idHospital;
                command.Parameters.Add("@idE", SqlDbType.Int, 4, "sector").Value = idEspecialidad;

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

        public bool eliminarDoctor(string cedulaDoc)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "DELETE FROM TblDoctores where  cedulaDoc =" + cedulaDoc;
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

        public bool modificarDoctor(string cedulaDoc, string nombreDoc, string apellidoDoc, int generoDoc, DateTime fechaN_Doc, string celDoc, int idHospital, int idEspecialidad)
        {

            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblDoctores set nombreDoc= " +
                    " @nom, apellidoDoc =@ape, generoDoc=@genero, fechaN_Doc=@fechaN, celDoc=@cel,"+
                    "idHospital=@idH, idEspecialidad=@idE where cedulaDoc=" + cedulaDoc;

                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.Parameters.Add("@nom", SqlDbType.VarChar, 20, "nombreDoc").Value = nombreDoc;
                command.Parameters.Add("@ape", SqlDbType.VarChar, 20, "apellidoDoc").Value = apellidoDoc;
                command.Parameters.Add("@genero", SqlDbType.Int, 4, "generoDoc").Value = generoDoc;
                command.Parameters.Add("@fechaN", SqlDbType.DateTime, 5, "fechaN_Doc").Value = fechaN_Doc;
                command.Parameters.Add("@cel", SqlDbType.VarChar, 9, "cel").Value = celDoc;
                command.Parameters.Add("@idH", SqlDbType.Int, 4, "seguroMedico").Value = idHospital;
                command.Parameters.Add("@idE", SqlDbType.Int, 4, "sector").Value = idEspecialidad;

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
    }
}
