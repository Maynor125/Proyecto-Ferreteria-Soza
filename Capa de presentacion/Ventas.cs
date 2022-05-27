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
    
    public partial class Ventas : Form
    {
        
        
        public Ventas()
        {
          
            InitializeComponent();
            LLenarControl();
        }

        private void LLenarControl()
        {
            MostrarCate C = new MostrarCate();
            MostrarPro M = new MostrarPro();
            M.LLenarCuadros(Contenedordeproductos);
            C.LLenar_cuadro(ContenedorC);
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            bunifuToolTip1.SetToolTip(bunifuImageButton1, "Imprimir");
            bunifuToolTip1.SetToolTip(bunifuImageButton2, "Seleccionar cliente");
            bunifuToolTip1.SetToolTip(bunifuImageButton3, "Guardar venta");
            bunifuToolTip1.SetToolTip(btnmas, "sumar uno");
            bunifuToolTip1.SetToolTip(btnmenos, "restar uno");
            bunifuToolTip1.SetToolTip(btnigual, "Cancelar venta");
        }

        private void bunifuVScrollBar3_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {

        }

        private void bunifuSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Contenedordeproductos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
