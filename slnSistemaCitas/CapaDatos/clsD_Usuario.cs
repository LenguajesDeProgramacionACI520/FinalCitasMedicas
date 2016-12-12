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

            }
            finally
            {
                clsConexion.cerrarConexion();
            }
        }

        public bool agregarUsuario(string ci, string nom1, string nom2, string ape1, string ape2, int genero, DateTime fechaN, string correo, string cel, int seguro, int sector)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "INSERT INTO TblUsuario values(@ci,@nom1,@nom2,@ape1,@ape2,@genero,@fechaN,"+
                    "@correo,@cel,@seguro,@sector)";
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);

                command.Parameters.Add("@ci", SqlDbType.VarChar,10, "idCedula").Value = ci;
                command.Parameters.Add("@nom1", SqlDbType.VarChar, 20, "nombre_p").Value = nom1;
                command.Parameters.Add("@nom2", SqlDbType.VarChar, 20, "nombre_s").Value = nom2;
                command.Parameters.Add("@ape1", SqlDbType.VarChar, 20, "apellido_p").Value = ape1;
                command.Parameters.Add("@ape2", SqlDbType.VarChar, 20, "apellido_s").Value = ape2;
                command.Parameters.Add("@genero", SqlDbType.Int, 4, "genero").Value = genero;
                command.Parameters.Add("@fechaN", SqlDbType.DateTime, 5, "Fecha_Nacimiento").Value = fechaN;
                command.Parameters.Add("@correo", SqlDbType.VarChar, 50, "correo").Value = correo;
                command.Parameters.Add("@cel", SqlDbType.VarChar, 12, "cel").Value = cel;
                command.Parameters.Add("@seguro", SqlDbType.Int, 4, "seguroMedico").Value = seguro;
                command.Parameters.Add("@sector", SqlDbType.Int, 4, "sector").Value = sector;

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
    }
}
