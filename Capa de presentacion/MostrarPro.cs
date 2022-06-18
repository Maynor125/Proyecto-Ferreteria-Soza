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
using MySql.Data.MySqlClient;

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
        public MySqlConnection Conex = new MySqlConnection("server=127.0.0.1;database=ferreteria_s;Uid=root;pwd=kagasagua;Allow User Variables=True;");
        
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
        public void LLenarcuadroinicio(FlowLayoutPanel C)
        {
            Conectar();
            string transatSql1 = "select Id_Articulo,Nombre,Cantidad from Articulo where Cantidad<6";
            MySqlCommand C1 = new MySqlCommand(transatSql1, Conex);
            C1.CommandType = CommandType.Text;
            MySqlDataReader Leer1 = C1.ExecuteReader();
            while (Leer1.Read())
            {
                Id_Producto = Convert.ToInt32(Leer1[0]);
                Nombre_Producto = Leer1[1].ToString();
                Cantidad = Convert.ToInt32(Leer1[2]);


                Articulos_pocas_existencias A = new Articulos_pocas_existencias();
                A.NombreProducto.Text = Nombre_Producto;
                A.LabelCantidad.Text = Convert.ToString(Cantidad);

                C.Controls.Add(A);
            }
            Desconectar();
            Conex.Dispose();
        }
        public int I;

        //Metodo para cargar datos de la BD a los elementos del componente Productos mostrar.
        public void LLenarCuadros(FlowLayoutPanel Contenedordeproduct)
        {

            Conectar();
            string transatSql = "Select Id_Articulo,Nombre,PrecioVenta,Marca,Imagen,Cantidad from Articulo";
           
            MySqlCommand C = new MySqlCommand(transatSql, Conex);
            
            C.CommandType = CommandType.Text;
           
            MySqlDataReader Leer = C.ExecuteReader();
           
           
            while (Leer.Read())
            {
                Productos_mostrar Var = new Productos_mostrar();

                Id_Producto = Convert.ToInt32(Leer[0]);
                Nombre_Producto = Leer[1].ToString();
                Precio_Venta = Convert.ToDecimal(Leer[2]);
                Marca = Leer[3].ToString();
                Imagen = ((byte[])Leer[4]);
                Cantidad = Convert.ToInt32(Leer[5]);
                if(Cantidad<5)
                {
                    Var.bunifuPanel2.BackgroundColor = Color.Red;
                }
                if(Cantidad>9)
                {
                    Var.LabelCantidad.Location = new Point(3,5);
                }
              
               // Var.lblid.Text = Convert.ToString( Id_Producto);
                Var.P_Nombre.Text = Nombre_Producto;
                Var.P_Precio.Text = Convert.ToString(Precio_Venta+"$");
                Var.LabelCantidad.Text = Convert.ToString(Cantidad);
                MemoryStream ms1 = new MemoryStream(Imagen);
                Bitmap bm = new Bitmap(ms1);
                Var.P_Imagen.Image = bm;

                if (Program.Evento3 == 3)
                {
                    I = Id_Producto;
                }

                Contenedordeproduct.Controls.Add(Var);
            }

            //if (Program.Evento3 == 3)
            //{
            //    I = Id_Producto;
            //}

            //Program.Evento3 = 0;
            Desconectar();
            Conex.Dispose();
        }
        public void pasarParametros()
        {
             if (Program.Evento2 == 4)
            {
                Ventas V = new Ventas();
                Cantidadproductos C = new Cantidadproductos();
                Conectar();
                string jaj = "select Nombre,PrecioVenta,Cantidad from Articulo where Id_Articulo=2";
                MySqlCommand a = new MySqlCommand(jaj, Conex);             
                a.Parameters.Add("Id", MySqlDbType.Int32).Value = I;
                MySqlDataReader leer2 = a.ExecuteReader();
                if (leer2.HasRows)
                {
                    while (leer2.Read()) // == this is the Read() method was called
                    {
                        string nombre = Convert.ToString(leer2[0]);
                        decimal Precioventa = Convert.ToDecimal(leer2[1]);
                        int cantidad = Convert.ToInt32(leer2[2]);
                        Desconectar();

                        int Cant = Convert.ToInt32(Int32.Parse(C.guna2TextBox1.Text));
                        V.agregar(I, nombre, cantidad, Precioventa, Cant);
                    }
                }
            }
        }
    }

}
