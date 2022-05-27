using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Acceso_de_Datos;
using System.Data;

using System.Data.SqlClient;

namespace Capa_Logica_Del_Negocio
{
    public class Articulos
    {
        Conexion_de_datos CD = new Conexion_de_datos();
        public int Id_Producto { get; set; }

        public int Categoria { get; set; }
        public string Nombre_Producto { get; set; }

        public string Marca { get; set; }
        public int Tipo { get; set; }
        public int Cantidad { get; set; }

        public Decimal Precio_Compra { get; set; }
        public Decimal Precio_Venta { get; set; }

        public byte[] Imagen { get; set; }

        public DataTable Listar_Articulos()
        {
            return CD.Listado("ListarProductos", null);
        }


        public String RegistrarProductos()
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje;

            try
            {
                lst.Add(new Parametros("@Id_Categoria",Categoria));
                lst.Add(new Parametros("@Nombre", Nombre_Producto));
                lst.Add(new Parametros("@Marca", Marca));
                lst.Add(new Parametros("@Unidad", Tipo));
                lst.Add(new Parametros("@Cantidad", Cantidad));
                lst.Add(new Parametros("@PrecioCompra", Precio_Compra));
                lst.Add(new Parametros("@PrecioVenta",Precio_Venta));
                lst.Add(new Parametros("@Imagen", Imagen));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                CD.EjecutarProcedimientosalmacenados("RegistrarArticulo", ref lst);
                Mensaje = lst[7].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
        

    }
}
