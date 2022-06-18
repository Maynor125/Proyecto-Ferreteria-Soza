using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Acceso_de_Datos;
using MySql.Data.MySqlClient;
namespace Capa_Logica_Del_Negocio
{
    public class Venta
    {
        Conexion_de_datos V = new Conexion_de_datos();
        public int Id { set; get; }
        public int IdEmpleado { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Total { get; set; }


        public String GenerarIdVenta()
        {
            List<Parametros> lst = new List<Parametros>();
            int objIdVenta;
            try
            {
                lst.Add(new Parametros("@IdVenta", "", MySqlDbType.Int32, ParameterDirection.Output, 4));
                V.EjecutarProcedimientosalmacenados("CrearIdVenta", ref lst);
                objIdVenta = Convert.ToInt32(lst[0].Valor.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToString(objIdVenta);
        }
    }
}
