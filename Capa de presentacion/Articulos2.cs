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
    public partial class Articulos2 : Form
    {
        Articulos V = new Articulos();
        public int indice = 0;
        public Articulos2()
        {
            InitializeComponent();
        }
      /*  public void Abrir_Form(object FormEstad)
        {
            if (this.Minicontenedor.Controls.Count > 0)
                this.Minicontenedor.Controls.RemoveAt(0);
            Form fh = FormEstad as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Minicontenedor.Controls.Add(fh);
            this.Minicontenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }*/
        private void Articulos2_Load(object sender, EventArgs e)
        {
            panelsearcgh.Size = new Size(92, 35);
            indice = 0;
            CargarListado();
        }
        public void CargarListado()
        {

            DataTable dt = V.Listar_ArticulosF();


            //MemoryStream ms1 = new MemoryStream(imagen);
            //Bitmap bm = new Bitmap(ms1);
            try
            {
                grid.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    grid.Rows.Add(imageList1.Images[1]);
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

        private void txbxbuscarproducto_TextChange(object sender, EventArgs e)
        {
            if (indice >= 0)
            {
                DataTable table = new DataTable();
                string dato;
                dato = txbxbuscarproducto.Text;
                table = V.BuscarArticuloFerreteria(dato, indice);
                grid.Rows.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    grid.Rows.Add(imageList1.Images[1]);
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

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
