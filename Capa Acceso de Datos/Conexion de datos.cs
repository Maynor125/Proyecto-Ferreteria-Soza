using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Capa_Acceso_de_Datos
{
    public class Conexion_de_datos
    {
        //Conexion a mysql....
        public MySqlConnection ObtenerConexion = new MySqlConnection("server=127.0.0.1;database=ferreteria_s;Uid=root;pwd=Madara125;");

        public void Conectarmy()
        {
            if (ObtenerConexion.State == ConnectionState.Closed)
                ObtenerConexion.Open();
        }
        public void Desconectarmy()
        {
            if (ObtenerConexion.State == ConnectionState.Open)
                ObtenerConexion.Close();
        }

       
        public DataTable Listado(String NombreSP, List<Parametros> lst)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da;
            try
            {
                Conectarmy();
                da = new MySqlDataAdapter(NombreSP, ObtenerConexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectarmy();
            return dt;
        }
        public void EjecutarProcedimientosalmacenados(String NombreSP, ref List<Parametros> lst)
        {
            MySqlCommand cmd;
            try
            {
                Conectarmy();
                cmd = new MySqlCommand(NombreSP, ObtenerConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        if (lst[i].Direccion == ParameterDirection.Output)
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                    }
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectarmy();
        }
    }
}
