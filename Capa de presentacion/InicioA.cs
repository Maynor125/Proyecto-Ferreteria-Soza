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
    public partial class InicioA : Form
    {
        public InicioA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InicioA_Load(object sender, EventArgs e)
        {
            MostrarPro Vari = new MostrarPro();
            Vari.LLenarcuadroinicio(flowLayoutPanel1);
        }
    }
}
