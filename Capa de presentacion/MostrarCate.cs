using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Capa_de_presentacion
{
    class MostrarCate
    {
        public string Nombre { get; set; }

        public MySqlConnection Conex = new MySqlConnection("server=127.0.0.1;database=ferreteria_s;Uid=root;pwd=Madara125;");
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

        public void LLenar_cuadro(FlowLayoutPanel C)
        {
            Conectar();
            string transatSql = "Select Descripcion from Categoria";
            MySqlCommand c = new MySqlCommand(transatSql, Conex);
            c.CommandType = CommandType.Text;
            MySqlDataReader Leer = c.ExecuteReader();

            while(Leer.Read())
            {
                Nombre = Leer[0].ToString();

                CategoriaMostrar vari = new CategoriaMostrar();
                vari.NombreCategoria.Text = Convert.ToString(Nombre);
                C.Controls.Add(vari);
            }
            Desconectar();
            Conex.Dispose();
        }
    }
}
