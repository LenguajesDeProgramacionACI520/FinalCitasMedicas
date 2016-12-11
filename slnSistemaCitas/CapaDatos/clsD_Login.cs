﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsD_Login
    {
        public bool D_ingreso(string ci, string pass)
        {
            try
            {
                clsConexion.abrirConexion();
                string sql = "SELECT count(*) FROM TblLogin1 WHERE usuario = @usuario AND pass = @pass";

                SqlCommand comando = new SqlCommand(sql , clsConexion.conexion);

                comando.Parameters.Add("@usuario", SqlDbType.VarChar, 10, "usuario").Value = ci;
                comando.Parameters.Add("@pass", SqlDbType.VarChar, 20, "pass").Value = pass;

                Int32 count = (Int32)comando.ExecuteScalar();
                Console.WriteLine(count);
                clsConexion.cerrarConexion();
                Console.WriteLine(count);
                if (count == 0)
                    return false;
                else
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

        public DataSet D_consulta(string usuario)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador;
            try
            {
                clsConexion.abrirConexion();
                string sql = "select * from TblLogin1 WHERE usuario= '" + usuario + "'";
                adaptador = new SqlDataAdapter(sql, clsConexion.conexion);
                adaptador.Fill(ds, "TblLogin1");
                return ds;
            }
            catch(Exception ex)
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
