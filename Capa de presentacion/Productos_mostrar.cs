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
    public partial class Productos_mostrar : UserControl
    {
        public Productos_mostrar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Productos_mostrar_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
       
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           
            Cantidadproductos C = new Cantidadproductos();
            Program.Evento3 = 3; 
            C.Show();
        }
    }
}
