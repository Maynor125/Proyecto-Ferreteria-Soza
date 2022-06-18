using Capa_Logica_Del_Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capa_de_presentacion
{

    public partial class Ventas : Form
    {
        public List<ParametrosVenta> lista = new List<ParametrosVenta>();
        Venta V = new Venta();
        public Ventas()
        {
          
            InitializeComponent();
            LLenarControl();
         
        }
        private void GenerarIdVenta()
        {
            txtidventa.Text = V.GenerarIdVenta();
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
            MostrarPro V = new MostrarPro();
            V.pasarParametros();
            bunifuToolTip1.SetToolTip(bunifuImageButton1, "Imprimir");
            bunifuToolTip1.SetToolTip(bunifuImageButton2, "Seleccionar cliente");
            bunifuToolTip1.SetToolTip(bunifuImageButton3, "Guardar venta");
            bunifuToolTip1.SetToolTip(btnmas, "sumar uno");
            bunifuToolTip1.SetToolTip(btnmenos, "restar uno");
            bunifuToolTip1.SetToolTip(btnigual, "Cancelar venta");
           // Bunifu.Utils.ScrollbarBinder.BindPanel(Contenedordeproductos, bunifuVScrollBar2);
        }

        public void agregar(int id,string nombre,int cantidad,decimal PrecioV,int Cantidad)
        {
            ParametrosVenta V = new ParametrosVenta();
            Decimal Porcentaje;
            Decimal Subt;
            V.IdProducto = id;
            V.IdVenta = Convert.ToInt32( txtidventa.Text);
            V.Descripcion = nombre;
            V.Cantidad = cantidad;
            Porcentaje = (Convert.ToDecimal(tbxivg.Text) / 100) + 1;
            Subt = PrecioV * Cantidad / Porcentaje;
            V.Igv= Math.Round(Convert.ToDecimal(Subt) * (Convert.ToDecimal(tbxivg.Text) / (100)), 2);
            V.SubTotal = Math.Round(Subt, 2);
            lista.Add(V);
            LLenarDataGridView();

        }

        public void LLenarDataGridView()
        {
            Decimal SumaSubTotal = 0;
            Decimal SumaIgv = 0;
            Decimal SumaTotal = 0;
            for(int i=0;i<lista.Count;i++)
            {
                grid.Rows.Add();
                grid.Rows[i].Cells[0].Value = lista[i].Descripcion;
                grid.Rows[i].Cells[1].Value = lista[i].PrecioVenta;
                grid.Rows[i].Cells[2].Value = lista[i].Cantidad;
                grid.Rows[i].Cells[3].Value = lista[i].SubTotal;
                SumaSubTotal = Convert.ToDecimal(grid.Rows[i].Cells[3].Value);
                SumaIgv = Convert.ToDecimal(tbxivg.Text);
            }
            SumaTotal += SumaSubTotal + SumaIgv;
            label3.Text = Convert.ToString(SumaTotal);
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

        private void bunifuVScrollBar2_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
