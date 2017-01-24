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
        MER_CitasMedicasDataContext db = new MER_CitasMedicasDataContext();
        public DataSet consultaDoctores()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;
            try
            {
                clsConexion.abrirConexion();
                string sql = "select * from TblDoctor ";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblDoctor");
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

        public bool agregarDoctor(string cedulaDoc1, string nombreDoc, string apellidoDoc, string generoDoc, DateTime fechaN_Doc, string celDoc, int idHospital, int idEspecialidad)
        {
            string ac = "AC";
            try
            {
                clsConexion.abrirConexion();
                string sql = "INSERT INTO TblDoctor values(@ci,@nom,@ape,@genero,@fechaN," +
                    "@cel,@est,@idH,@idE)";
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);

                command.Parameters.Add("@ci", SqlDbType.Char, 10, "idCedula").Value = cedulaDoc1;
                command.Parameters.Add("@nom", SqlDbType.VarChar, 20, "nomDoctor").Value = nombreDoc;
                command.Parameters.Add("@ape", SqlDbType.VarChar, 20, "apeDoctor").Value = apellidoDoc;
                command.Parameters.Add("@genero", SqlDbType.Char, 1, "genDoctor").Value = generoDoc;
                command.Parameters.Add("@fechaN", SqlDbType.DateTime, 5, "fechaN_Doctor").Value = fechaN_Doc;
                command.Parameters.Add("@cel", SqlDbType.Char, 10, "celDoctor").Value = celDoc;
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estDoctor").Value = ac;
                command.Parameters.Add("@idH", SqlDbType.Int, 4, "idHospital").Value = idHospital;
                command.Parameters.Add("@idE", SqlDbType.Int, 4, "idEspecialidadd").Value = idEspecialidad;

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

        public DataSet consultaDoctores(string cedulaDoc)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;
            try
            {
                clsConexion.abrirConexion();
                string sql = "select * from TblDoctor WHERE idCedula =" +cedulaDoc;
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblDoctor");
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

        public bool eliminarDoctor(string cedulaDoc)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "DELETE FROM TblDoctor where idCedula =" + cedulaDoc;
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

        public object consultaDocHora(int idEspecialidad, int idHospital, DateTime fechaC, int idHora)
        {
            try
            {
                var doc = from d in db.TblDoctor
                          from h in db.TblHora
                          from dh in db.TblDoctorHora
                          where dh.idDoctor == d.idCedula && d.idCedula ==dh.idDoctor && dh.idHora == idHora 
                            && h.estHora == "AC" && d.estDoctor == "AC" && d.idEspecialidad == idEspecialidad
                            && d.idHospital == idHospital 
                          select new { Cedula = d.idCedula, nombre = d.nomDoctor, apellido = d.apeDoctor };
                var docO = from d in db.TblDoctor
                            from c in db.TblCita
                            where d.idCedula == c.idDoctor && c.fechaCita == fechaC 
                             && c.idHora == idHora
                            select new { Cedula = d.idCedula, nombre = d.nomDoctor, apellido = d.apeDoctor };
                var resultado = doc.Except(docO);
                return resultado.ToList();
            }
            catch(Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public bool modificarDoctor(string cedulaDoc, string nombreDoc, string apellidoDoc, string generoDoc, DateTime fechaN_Doc, string celDoc, int idHospital, int idEspecialidad)
        {

            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblDoctor set nomDoctor= " +
                    " @nom, apeDoctor=@ape, genDoctor=@genero, fechaN_Doctor=@fechaN, celDoctor=@cel,"+
                    "idHospital=@idH, idEspecialidad=@idE where idCedula=" + cedulaDoc;

                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.Parameters.Add("@nom", SqlDbType.VarChar, 20, "nomDoctor").Value = nombreDoc;
                command.Parameters.Add("@ape", SqlDbType.VarChar, 20, "apeDoctor").Value = apellidoDoc;
                command.Parameters.Add("@genero", SqlDbType.Char, 1, "genDoctor").Value = generoDoc;
                command.Parameters.Add("@fechaN", SqlDbType.DateTime, 5, "fechaN_Doc").Value = fechaN_Doc;
                command.Parameters.Add("@cel", SqlDbType.VarChar, 9, "celDoctor").Value = celDoc;
                command.Parameters.Add("@idH", SqlDbType.Int, 4, "idHospital").Value = idHospital;
                command.Parameters.Add("@idE", SqlDbType.Int, 4, "idEspecialidad").Value = idEspecialidad;

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

        public bool desactivarDoctor(string ci)
        {
            string dc = "DC";
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblDoctor set estDoctor=@est where idCedula = " + ci;
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estDoctor").Value = dc;
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
        public bool activarDoctor(string ci)
        {
            string ac = "AC";
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblDoctor set estDoctor=@est where idCedula = " + ci;
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estDoctor").Value = ac;
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
