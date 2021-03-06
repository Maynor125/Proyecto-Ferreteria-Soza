using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using Capa_Acceso_de_Datos;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;


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
        public string Lugar { get; set; }

        public DataTable Listar_Articulos()
        {
            return CD.Listado("ListarProductos", null);
        }
        public DataTable Listar_ArticulosF()
        {
            return CD.Listado("MostrarProFerreteria", null);
        }
        public DataTable Listar_ArticulosA()
        {
            return CD.Listado("MostrarProAlmacen", null);
        }
        public DataTable BuscarArticulo(String Datos,int indice)
        {
            DataTable dt = new DataTable();
            List<Parametros> lst = new List<Parametros>();
            lst.Add(new Parametros("@Dato", Datos));
            lst.Add(new Parametros("@ind", indice));
            return dt = CD.Listado("Buscar_Articulo", lst);
        }
        public DataTable BuscarArticuloFerreteria(String Datos, int indice)
        {
            DataTable dt = new DataTable();
            List<Parametros> lst = new List<Parametros>();
            lst.Add(new Parametros("@Dato", Datos));
            lst.Add(new Parametros("@ind", indice));
            return dt = CD.Listado("Buscar_ArticuloF", lst);
        }
        public DataTable BuscarArticuloAlmacen(String Datos, int indice)
        {
            DataTable dt = new DataTable();
            List<Parametros> lst = new List<Parametros>();
            lst.Add(new Parametros("@Dato", Datos));
            lst.Add(new Parametros("@ind", indice));
            return dt = CD.Listado("Buscar_ArticuloA", lst);
        }
        public void RegistrarProductos()
        {

            List<Parametros> lst = new List<Parametros>();

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
                lst.Add(new Parametros("@lugar", Lugar));
                CD.EjecutarProcedimientosalmacenados("RegistrarArticulo", ref lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AtualizarProductos()
        {

            List<Parametros> lst = new List<Parametros>();

            try
            {
                lst.Add(new Parametros("@Id_Articulo", Id_Producto));
                lst.Add(new Parametros("@Id_Categoria", Categoria));
                lst.Add(new Parametros("@Nombre", Nombre_Producto));
                lst.Add(new Parametros("@Marca", Marca));
                lst.Add(new Parametros("@Unidad", Tipo));
                lst.Add(new Parametros("@Cantidad", Cantidad));
                lst.Add(new Parametros("@PrecioCompra", Precio_Compra));
                lst.Add(new Parametros("@PrecioVenta", Precio_Venta));
                lst.Add(new Parametros("@Imagen", Imagen));
                lst.Add(new Parametros("@lugar", Lugar));
                CD.EjecutarProcedimientosalmacenados("ActualizarArticulo", ref lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       public void EliminarArticulos()
        {

            List<Parametros> lst = new List<Parametros>();

            try
            {
                lst.Add(new Parametros("@Id_A", Id_Producto));
                CD.EjecutarProcedimientosalmacenados("EliminarArticulo", ref lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
