using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_de_presentacion
{
    public partial class Datos : Form
    {
        private Panel P = new Panel();
        private Label L1 = new Label();
        private Label L2 = new Label();
        private PictureBox img1 = new PictureBox();
        public Datos()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                P = new Panel();
                L1 = new Label();
                L2 = new Label();
                img1 = new PictureBox();
                P.Size = new Size(185, 135);
                P.BackColor = Color.FromArgb(0, 30, 38);
                L1.BackColor = Color.DarkRed;
                L1.Text = "Hola wapo";
                L2.Text = "Siuuuuuuuu";
                L2.BackColor = Color.DarkRed;
                img1.Size = new Size(109 ,101);
                P.Location = new Point(250, 15);
                panelcontenedordeproducto.Controls.Add(P);
                P.Controls.Add(img1);
                P.Controls.Add(L1);
                P.Controls.Add(L2);


                grid.Rows.Add(new object[]
                    {
                        imageList1.Images[0],
                        Faker.NumberFaker.Number(),
                        Faker.NameFaker.FirstName(),
                        Faker.NameFaker.LastName(),
                       Faker.NameFaker.MaleName(),
                         Faker.DateTimeFaker.DateTime(),
                       imageList2.Images[0],
                        Faker.NumberFaker.Number()


                    }
                    ) ;
            }
        }
     
        private void Datos_Load(object sender, EventArgs e)
        {
            P.Visible = true;
         
            L1.Visible = true;
           
            L2.Visible = true;
            L2.BringToFront();
            img1.Visible = true;
            img1.BringToFront();

        }

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                bunifuVScrollBar1.Maximum = grid.RowCount-1;
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
    }
}
