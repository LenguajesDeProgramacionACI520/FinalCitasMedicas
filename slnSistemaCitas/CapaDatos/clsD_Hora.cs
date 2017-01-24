using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Hora
    {
        public DataSet consultaHoraAc()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adaptador;
                clsConexion.abrirConexion();
                string sql = "SELECT * FROM TblHora where estHora='AC' ";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblHora");
                clsConexion.cerrarConexion();
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

        public bool descativarHora(int idHora, string estHora)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblHora set estHora=@est where idHora = " + idHora;
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estHora").Value = estHora;
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

        public DataSet consultaHora()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adaptador;
                clsConexion.abrirConexion();
                string sql = "SELECT * FROM TblHora";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblHora");
                clsConexion.cerrarConexion();
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

        public bool activarHora(int idHora, string estHora)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblHora set estHora=@est where idHora = " + idHora;
                SqlCommand command = new SqlCommand(sql, clsConexion.conexion);
                command.Parameters.Add("@est", SqlDbType.Char, 2, "estHora").Value = estHora;
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

        public DataSet consultaHora(int idHora)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adaptador;
                clsConexion.abrirConexion();
                string sql = "SELECT * FROM TblHora where idHora ="+idHora;
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblHora");
                clsConexion.cerrarConexion();
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
