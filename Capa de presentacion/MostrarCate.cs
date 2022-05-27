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
    class MostrarCate
    {
        public string Nombre { get; set; }

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

        public void LLenar_cuadro(FlowLayoutPanel C)
        {
            Conectar();
            string transatSql = "Select Descripcion from Categoria";
            SqlCommand c = new SqlCommand(transatSql, Conex);
            c.CommandType = CommandType.Text;
            SqlDataReader Leer = c.ExecuteReader();

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
