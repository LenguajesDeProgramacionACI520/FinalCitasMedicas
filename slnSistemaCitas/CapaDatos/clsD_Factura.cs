using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Factura
    {
        public DataSet consultarid()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;

            try
            {
                clsConexion.abrirConexion();
                string sqlCOnsulta = "select max(idFactura) from TblFactura";
                adaptador = new SqlDataAdapter(sqlCOnsulta, clsConexion.conexion);
                adaptador.Fill(ds, "TblFactura");
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

        public bool agregarFactura(DateTime fechaFactura, decimal costoCita, decimal descFactura, decimal subToFactura, decimal totalFactura, string estFactura, string idUsuario, int idCita)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "INSERT INTO TblFactura values(@fecha,@costo,@desc,@sub,@tot,@est,@user,@cita)";
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);

                command.Parameters.Add("@fecha", SqlDbType.DateTime, 5, "fechaCita").Value = fechaFactura;
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estFactura").Value = estFactura;
                command.Parameters.Add("@user", SqlDbType.Char, 10, "idUsuario").Value = idUsuario;
                command.Parameters.Add("@cita", SqlDbType.Int, 4, "idCita").Value = idCita;
                SqlParameter param = new SqlParameter("@costo", SqlDbType.Decimal);
                param.SourceColumn = "costoFactura";
                param.Precision = 10;
                param.Scale = 2;
                command.Parameters.Add(param).Value = costoCita;

                param = new SqlParameter("@desc", SqlDbType.Decimal);
                param.SourceColumn = "descFactura";
                param.Precision = 10;
                param.Scale = 2;
                command.Parameters.Add(param).Value = descFactura;

                param = new SqlParameter("@sub", SqlDbType.Decimal);
                param.SourceColumn = "subToFactura";
                param.Precision = 10;
                param.Scale = 2;
                command.Parameters.Add(param).Value = subToFactura;

                param = new SqlParameter("@tot", SqlDbType.Decimal);
                param.SourceColumn = "totalFactura";
                param.Precision = 10;
                param.Scale = 2;
                command.Parameters.Add(param).Value = totalFactura;

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

        public bool eliminarFactura(int idFactura)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "DELETE FROM TblFactura where idFactura = " + idFactura;
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

        public bool modificarCita(int idCita, string est)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblAdmin estCita=@est where idCita=" + idCita;
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estFactura").Value = est;

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
