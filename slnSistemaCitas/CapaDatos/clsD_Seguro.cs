﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Seguro
    {
        public DataSet consultaSeguro()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adaptador;
                clsConexion.abrirConexion();

                string sql = "SELECT * FROM TblSeguro";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblSeguro");

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

        public DataSet obtenerId()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;

            try
            {
                clsConexion.abrirConexion();
                string sql = "select max(idSeguro) from TblSeguro";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblSeguro");
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

        public bool agregarSeguro(int idSeguro, string nombreSeguro, int descuentoSeguro)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "insert into TblSeguro values (@id,@nombre,@descuento)";
                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@id", SqlDbType.Int, 4, "idSeguro").Value = idSeguro;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 20, "nombreSeguro").Value = nombreSeguro;
                comando.Parameters.Add("@descuento", SqlDbType.Int, 4, "descuentoSeguro").Value = descuentoSeguro;
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

        public bool modificarSeguro(int idSeguro, string nombreSeguro, int descuentoSeguro)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "update TblSeguro set nombreSeguro= " +
                    " @nombre, descuentoSeguro=@descuento where idSeguro=" + idSeguro;

                SqlCommand comando = new SqlCommand(sql, clsConexion.conexion);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 20, "nombreSeguro").Value = nombreSeguro;
                comando.Parameters.Add("@descuento", SqlDbType.Int, 4, "descuentoSeguro").Value = descuentoSeguro;
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

        public bool eliminarSeguro(int idSeguro)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "DELETE FROM TblSeguro where idSeguro = " + idSeguro;
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
