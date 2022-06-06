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
    public partial class CategoriaMostrar : UserControl
    {
        public CategoriaMostrar()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void CategoriaMostrar_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {
            if(bunifuPanel1.BackgroundColor==Color.Gray)
            {
                bunifuPanel1.BackgroundColor = Color.LightGray;
            }
            else if(bunifuPanel1.BackgroundColor == Color.LightGray)
            {
                bunifuPanel1.BackgroundColor = Color.Gray;
            }
        }

        private void bunifuPanel1_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
