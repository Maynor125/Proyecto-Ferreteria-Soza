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
    public class OrdenDatos : Conexion_de_datos
    {
        MySqlCommand Co = new MySqlCommand();
        Conexion_de_datos C = new Conexion_de_datos();
       
        
        public DataTable Orden(DateTime Dato1,DateTime Dato2)
        {
            C.Conectarmy();

            Co.CommandText = "ReporteV";
            Co.Parameters.AddWithValue("@FechaInicio", Dato1);
            Co.Parameters.AddWithValue("@FechaFinal", Dato2);
                    Co.CommandType = CommandType.StoredProcedure;

                    var Leer = Co.ExecuteReader();
                    var tabla = new DataTable();
                    tabla.Load(Leer);
            C.Conectarmy();
                    return tabla;
                
            
        }
        public DataTable OrdenPM(DateTime Dato1, DateTime Dato2)
        {
            C.Conectarmy();

            Co.CommandText = "ReporteM";
            Co.Parameters.AddWithValue("@FechaInicio", Dato1);
            Co.Parameters.AddWithValue("@FechaFinal", Dato2);
            Co.CommandType = CommandType.StoredProcedure;

            var Leer = Co.ExecuteReader();
            var tabla = new DataTable();
            tabla.Load(Leer);
            C.Desconectarmy();
            return tabla;
        }
        public DataTable OrdenDPM(DateTime Dato1,int ID)
        {
            C.Conectarmy();

            Co.CommandText = "MostrarDMP";
            Co.Parameters.AddWithValue("@F", Dato1);
            Co.Parameters.AddWithValue("@M", ID);
            Co.CommandType = CommandType.StoredProcedure;

            var Leer = Co.ExecuteReader();
            var tabla = new DataTable();
            tabla.Load(Leer);
            C.Desconectarmy();
            return tabla;
        }

        //public bool VerificaciontexboxM(String u)
        //{
        //    var coman = new SqlCommand();
        //    SqlDataReader Leer;
        //    bool w = false;
        //    coman.Connection = C.AbrirConexion();
        //    coman.CommandText = "select* from Montador where NIF=@cli";
        //    coman.Parameters.Add("@cli", SqlDbType.Int).Value = u;

        //    Leer = coman.ExecuteReader();
        //    coman.Parameters.Clear();

        //    if (Leer.HasRows)
        //    {
        //        w = true;
        //    }
        //    coman.Connection = C.CerrarConexion();
        //    return w;
        //}
    }
}
