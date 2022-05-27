using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Capa_de_presentacion
{
    class MostrarPro
    {

        //creacion de atributos.
        public int Id_Producto { get; set; }

        public int Categoria { get; set; }
        public string Nombre_Producto { get; set; }

        public string Marca { get; set; }
        public int Tipo { get; set; }
        public int Cantidad { get; set; }

        public Decimal Precio_Compra { get; set; }
        public Decimal Precio_Venta { get; set; }

        public byte[] Imagen { get; set; }


        //Conexion a la base de datos en una capa.........
        public SqlConnection Conex = new SqlConnection("Data Source=LAPTOP-RR455DM5\\SQLEXPRESS;Initial Catalog=Ferreteria;Integrated Security=True");
        public void Conectar()
        {
            if (Conex.State == ConnectionState.Closed)
                Conex.Open();
        }

        public void Desconectar()
        {
            if (Conex.State == ConnectionState.Open)
                Conex.Close();
        }

        //Metodo para cargar datos de la BD a los elementos del componente Productos mostrar.
        public void LLenarCuadros(FlowLayoutPanel Contenedordeproduct)
        {

            Conectar();
            string transatSql = "Select Id_Articulo,Nombre,PrecioVenta,Marca,Imagen from Articulo";
            SqlCommand C = new SqlCommand(transatSql, Conex);
            C.CommandType = CommandType.Text;
            SqlDataReader Leer = C.ExecuteReader();

            while (Leer.Read())
            {
               // Id_Producto = Convert.ToInt32(Leer[0]);
                Nombre_Producto = Leer[1].ToString();
                Precio_Venta = Convert.ToDecimal(Leer[2]);
                Marca = Leer[3].ToString();
                Imagen = ((byte[])Leer[4]);

                Productos_mostrar Var = new Productos_mostrar();
               // Var.P_ID.Text = Convert.ToString( Id_Producto);
                Var.P_Nombre.Text = Nombre_Producto;
                Var.P_Precio.Text = Convert.ToString(Precio_Venta+"$");
                MemoryStream ms1 = new MemoryStream(Imagen);
                Var.P_Imagen.Image = Image.FromStream(ms1);

                Contenedordeproduct.Controls.Add(Var);

            }
            Desconectar();
            Conex.Dispose();
        }
    }
}
