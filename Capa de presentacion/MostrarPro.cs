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
using System.Collections;

namespace Capa_de_presentacion
{
    class MostrarPro
    {
        //Conexion a la base de datos en una capa.........
        public MySqlConnection Conex = new MySqlConnection("server=127.0.0.1;database=ferreteria_s;Uid=root;pwd=kagasagua;");
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

        //creacion de atributos.
        Productos_mostrar Var = new Productos_mostrar();
        public int Id_Producto { get; set; }

        public int Categoria { get; set; }
        public string Nombre_Producto { get; set; }

        public string Marca { get; set; }
        public int Tipo { get; set; }
        public int Cantidad { get; set; }

        public Decimal Precio_Compra { get; set; }
        public Decimal Precio_Venta { get; set; }

        public byte[] Imagen { get; set; }
        public ArrayList IDS;
      
        public int i;
        public int I;
        //Metodo para cargar datos de la BD a los elementos del componente Productos mostrar.
        public void LLenarCuadros(FlowLayoutPanel Contenedordeproduct)
        {
 
            string transatSql = "Select Id_Articulo,Nombre,PrecioVenta,Marca,Imagen,Cantidad from Articulo";
            MySqlCommand C = new MySqlCommand(transatSql, Conex);
            C.CommandType = CommandType.Text;
           
            MySqlDataReader Leer = C.ExecuteReader();
       

            while (Leer.Read())
            {
                
                 Id_Producto = Convert.ToInt32(Leer[0]);
                Nombre_Producto = Leer[1].ToString();
                Precio_Venta = Convert.ToDecimal(Leer[2]);
                Marca = Leer[3].ToString();
                Imagen = ((byte[])Leer[4]);
                Cantidad = Convert.ToInt32(Leer[5]);
             

                if (Cantidad < 5)
                {
                    Var.bunifuPanel2.BackgroundColor = Color.Red;
                }
                if (Cantidad > 9)
                {

                    Var.LabelCantidad.Location = new Point(3, 5);
                }
              
                 Var.lbid.Text = Convert.ToString( Id_Producto);
                Var.P_Nombre.Text = Nombre_Producto;
                Var.P_Precio.Text = Convert.ToString(Precio_Venta + "$");
                Var.LabelCantidad.Text = Convert.ToString(Cantidad);
                MemoryStream ms1 = new MemoryStream(Imagen);
                Bitmap bm = new Bitmap(ms1);
                Var.P_Imagen.Image = bm;

                Productos_mostrar p = new Productos_mostrar();
                if (p.btnprec == true)
                {
                    Id_Producto = I;
                }
                Contenedordeproduct.Controls.Add(Var);
                i = Convert.ToInt32(Var.lbid.Text);
                IDS.Add(i);

            }
            Desconectar();
           Conex.Dispose();
        }
        public void pasarParametros()
        { 

            Conectar();
            string jaj = "select Nombre,PrecioVenta,Cantidad where Id_Articulo=@Id";
            MySqlCommand a = new MySqlCommand(jaj, Conex);
            a.Parameters.Add("@Id", MySqlDbType.Int32).Value = I;
            MySqlDataReader leer2 = a.ExecuteReader();
            string nombre = Convert.ToString(leer2[0]);
            decimal Precioventa = Convert.ToDecimal(leer2[1]);
            int cantidad = Convert.ToInt32(leer2[2]);
        }
    }
}
