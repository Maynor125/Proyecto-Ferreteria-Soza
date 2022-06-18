using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica_Del_Negocio;

namespace Capa_de_presentacion
{
 
    public partial class Productos_I : Form
    {
        Articulos V = new Articulos();
        Categoria C = new Categoria();
        public int indice;



        public byte[] imagen;
       
        public Productos_I()
        {
            InitializeComponent();
        }

       
        private void Datos2_Load(object sender, EventArgs e)
        {  
           
            panelsearcgh.Size = new Size(92, 35);

            CargarListado();
            CargarListadoCategoria();
            indice = 0;
            toolTip1.SetToolTip(bunifuImageButton1, "Agregar nuevo producto");
            toolTip1.SetToolTip(bunifuImageButton2, "Actualizar Producto");
            toolTip1.SetToolTip(bunifuImageButton3, "Eliminar producto");
            toolTip1.SetToolTip(bunifuImageButton4, "Eliminar categoria");
            toolTip1.SetToolTip(bunifuImageButton5, "Editar categoria");
            toolTip1.SetToolTip(bunifuImageButton6, "Agregar categoria");
            toolTip1.SetToolTip(opcionesbuscar, "Buscar por medio de....."); 
     
        }
        public void CargarListadoCategoria()
        {
            DataTable dt1 = C.Listar_Categoria();
            try
            {
                gridcategorias.Rows.Clear();
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    gridcategorias.Rows.Add(imageList1.Images[2]);
                    gridcategorias.Rows[i].Cells[1].Value = dt1.Rows[i][0].ToString();
                    gridcategorias.Rows[i].Cells[2].Value = dt1.Rows[i][1].ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            grid.ClearSelection();
        }
    
        public void CargarListado()
        {

            DataTable dt = V.Listar_Articulos();
            

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
                    grid.Rows[i].Cells[7].Value = (imageList2.Images[1]);
                    grid.Rows[i].Cells[8].Value = dt.Rows[i][6].ToString();
                    grid.Rows[i].Cells[9].Value = (imageList2.Images[0]);
                    grid.Rows[i].Cells[10].Value = dt.Rows[i][7].ToString();

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            grid.ClearSelection();
        }

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                bunifuVScrollBar1.Maximum = grid.RowCount - 1;
            }
            catch (Exception)
            {

            }
        }

        private void grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                bunifuVScrollBar1.Maximum = grid.RowCount - 1;
            }
            catch (Exception)
            {

            }
        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            try
            {
                grid.FirstDisplayedScrollingRowIndex = grid.Rows[e.Value].Index;
            }
            catch (Exception)
            {

            }
        }

        private void opcionesbuscar_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void opcionesbuscar_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void opcionesbuscar_MouseLeave(object sender, EventArgs e)
        {

            //panelsearcgh.Size = new Size(92, 35);
        }

        private void panelsearcgh_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panelsearcgh_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void panelsearcgh_MouseLeave(object sender, EventArgs e)
        {
            //panelsearcgh.Size = new Size(92, 35);
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

        private void buscar2_Click(object sender, EventArgs e)
        {
            indice = 1;
            buscar2.Location = new Point(9, 4);
            buscar1.Visible = false;
            panelsearcgh.Size = new Size(92, 35);
            txbxbuscarproducto.PlaceholderText = "Buscar producto por la marca...";
           
        }

        private void buscar3_Click(object sender, EventArgs e)
        {
            indice = 2;
            buscar3.Location = new Point(9, 4);
            buscar1.Visible = false;
            panelsearcgh.Size = new Size(92, 35);
            txbxbuscarproducto.PlaceholderText = "Buscar producto por la categoria...";
        }

        private void buscar1_Click(object sender, EventArgs e)
        {
            indice = 0;
            panelsearcgh.Size = new Size(92, 35);
            txbxbuscarproducto.PlaceholderText = "Buscar producto por el nombre...";
        }

        private void opcionesbuscar_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Producto a = new Producto();
            a.Show();
            Program.Evento = 0;

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                Producto P = new Producto();
                P.Show();
                P.cbxCategoria.Text = Convert.ToString(grid.CurrentRow.Cells[2].Value.ToString());
                P.txbproducto.Text = grid.CurrentRow.Cells[3].Value.ToString();
                P.txbxmarca.Text = grid.CurrentRow.Cells[4].Value.ToString();
                P.cbxUnidad.Text = grid.CurrentRow.Cells[5].Value.ToString();
                P.tbxcantidad.Text = grid.CurrentRow.Cells[6].Value.ToString();
                P.tbxpc.Text = grid.CurrentRow.Cells[8].Value.ToString();
                P.txbxpv.Text = grid.CurrentRow.Cells[10].Value.ToString();

                Program.Evento =1;
            }

            else
            {
                MessageBox.Show("Debe Seleccionar la Fila a Editar.", "\tSistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            string id_Prod;
            if (grid.SelectedRows.Count > 0)
            {
                DialogResult ORe;
                ORe = MessageBox.Show("Al eliminar este Articulos podria afectar otros datos\n\t\tEliminar aun asi", "\tAdvertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ORe == DialogResult.OK)
                {
                    id_Prod = (grid.CurrentRow.Cells[1].Value.ToString());
                    V.Id_Producto = Convert.ToInt32(id_Prod);
                    V.EliminarArticulos();
                    MessageBox.Show("Eliminado correctamente");
                    CargarListado();

                }
                else MessageBox.Show("Eliminacion cancelada");

            }
            else
                MessageBox.Show("Seleccione una fila de la list", "\tSistema de ventas", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Categoria a = new Categoria();
            string id_Prod;
            if (gridcategorias.SelectedRows.Count > 0)
            {
                DialogResult ORe;
                ORe = MessageBox.Show("Al eliminar esta categoria se eliminaran todos los articulos que pertenescan a ella \n\t\tEliminar aun asi", "\tAdvertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ORe == DialogResult.OK)
                {
                    id_Prod = (gridcategorias.CurrentRow.Cells[1].Value.ToString());
                    a.ID = Convert.ToInt32(id_Prod);
                    a.EliminarArticulos();
                    MessageBox.Show("Eliminado correctamente");
                    CargarListadoCategoria();

                }
                else MessageBox.Show("Eliminacion cancelada");

            }
            else
                MessageBox.Show("Seleccione una fila de la list", "\tSistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            if (gridcategorias.SelectedRows.Count > 0)
            {
                Program.Evento = 1;
                AgregarCategoria P = new AgregarCategoria();
                P.Show();
               
                P.guna2TextBox1.Text = grid.CurrentRow.Cells[2].Value.ToString();
            }

            else
            {
                MessageBox.Show("Debe Seleccionar la Fila a Editar.", "\tSistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Program.Evento = 0;
            AgregarCategoria a = new AgregarCategoria();
            a.Show();
        }

        private void txbxbuscarproducto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txbxbuscarproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbxbuscarproducto_TextChange(object sender, EventArgs e)
        {
            if(indice >=0 )
            {
                DataTable table = new DataTable();
                string dato;
                dato = txbxbuscarproducto.Text;
                table = V.BuscarArticulo(dato, indice);
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
                    grid.Rows[i].Cells[7].Value = (imageList2.Images[1]);
                    grid.Rows[i].Cells[8].Value = table.Rows[i][6].ToString();
                    grid.Rows[i].Cells[9].Value = (imageList2.Images[0]);
                    grid.Rows[i].Cells[10].Value = table.Rows[i][7].ToString();
                }

            }
        }
    }
   
}
