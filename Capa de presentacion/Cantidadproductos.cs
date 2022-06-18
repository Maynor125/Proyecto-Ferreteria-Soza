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
    public partial class Cantidadproductos : Form
    {
        public Cantidadproductos()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Program.Evento2 = 4;
            //Ventas v = new Ventas();
            //v.Show();
            this.Close();
        }
    }
}
