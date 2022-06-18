using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica_Del_Negocio;

namespace Capa_de_presentacion
{
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }
        public int indice;
        private void Almacen_Load(object sender, EventArgs e)
        {
            panelsearcgh.Size = new Size(92, 35);
            indice = 0;
        }
        public void CargarListado()
        {
            Articulos V = new Articulos();
            DataTable dt = V.Listar_ArticulosA();


            //MemoryStream ms1 = new MemoryStream(imagen);
            //Bitmap bm = new Bitmap(ms1);
            try
            {
                grid.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    grid.Rows.Add(imageList2.Images[1]);
                    grid.Rows[i].Cells[1].Value = dt.Rows[i][0].ToString();
                    grid.Rows[i].Cells[2].Value = dt.Rows[i][1].ToString();
                    grid.Rows[i].Cells[3].Value = dt.Rows[i][2].ToString();
                    grid.Rows[i].Cells[4].Value = dt.Rows[i][3].ToString();
                    grid.Rows[i].Cells[5].Value = dt.Rows[i][4].ToString();
                    grid.Rows[i].Cells[6].Value = dt.Rows[i][5].ToString();
                    grid.Rows[i].Cells[7].Value = (imageList2.Images[0]);
                    grid.Rows[i].Cells[8].Value = dt.Rows[i][7].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            grid.ClearSelection();
        }

        private void opcionesbuscar_Click(object sender, EventArgs e)
        {

        }

        private void opcionesbuscar_MouseHover(object sender, EventArgs e)
        {

            if (panelsearcgh.Size == new Size(285, 35))
            {
                panelsearcgh.Size = new Size(92, 35);
            }
            else
            {

                panelsearcgh.Size = new Size(285, 35);
                buscar1.Visible = true;
                buscar1.Location = new Point(9, 4);
                buscar2.Location = new Point(105, 3);
                buscar3.Location = new Point(200, 3);
            }

        }

        private void buscar1_Click(object sender, EventArgs e)
        {
            indice = 0;
            panelsearcgh.Size = new Size(92, 35);
            txbxbuscarproducto.PlaceholderText = "Buscar producto por el nombre...";
        }

        private void buscar2_Click(object sender, EventArgs e)
        {

            buscar2.Location = new Point(9, 4);
            buscar1.Visible = false;
            panelsearcgh.Size = new Size(92, 35);
            txbxbuscarproducto.PlaceholderText = "Buscar producto por la marca...";

            indice = 1;
        }

        private void buscar3_Click(object sender, EventArgs e)
        {

            indice = 2;
            buscar3.Location = new Point(9, 4);
            buscar1.Visible = false;
            panelsearcgh.Size = new Size(92, 35);
            txbxbuscarproducto.PlaceholderText = "Buscar producto por la categoria...";
        }

        private void txbxbuscarproducto_TextChange(object sender, EventArgs e)
        {
            Articulos V = new Articulos();

            if (indice >= 0)
            {
                DataTable table = new DataTable();
                string dato;
                dato = txbxbuscarproducto.Text;
                table = V.BuscarArticuloAlmacen(dato, indice);
                grid.Rows.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    grid.Rows.Add(imageList2.Images[1]);
                    grid.Rows[i].Cells[1].Value = table.Rows[i][0].ToString();
                    grid.Rows[i].Cells[2].Value = table.Rows[i][1].ToString();
                    grid.Rows[i].Cells[3].Value = table.Rows[i][2].ToString();
                    grid.Rows[i].Cells[4].Value = table.Rows[i][3].ToString();
                    grid.Rows[i].Cells[5].Value = table.Rows[i][4].ToString();
                    grid.Rows[i].Cells[6].Value = table.Rows[i][5].ToString();
                    grid.Rows[i].Cells[7].Value = (imageList2.Images[0]);
                    grid.Rows[i].Cells[8].Value = table.Rows[i][7].ToString();
                }
            }
        }
    }
}
