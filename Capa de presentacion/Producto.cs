using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Capa_Logica_Del_Negocio;
using System.Drawing.Imaging;

namespace Capa_de_presentacion
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }
        Articulos Variable = new Articulos();
        Categoria Variable1 = new Categoria();
        UnidadMedida Variable2 = new UnidadMedida();

        private void Producto_Load(object sender, EventArgs e)
        {
            bunifuToolTip1.SetToolTip(pictureBox1, "Ingresar imagen de tipo PNG");
            bunifuToolTip1.SetToolTip(pictureBox2, "Cerrar Ventana");
            cbxCategoria.DataSource = Variable1.Listar_Categoria();
            cbxCategoria.ValueMember = "Id_Categoria";
            cbxCategoria.DisplayMember = "Descripcion";
            cbxCategoria.SelectedIndex = -1;


            cbxUnidad.DataSource = Variable2.Listar_Unidad();
            cbxUnidad.ValueMember = "Id_Unidad";
            cbxUnidad.DisplayMember = "Nombre";
            cbxUnidad.SelectedIndex = -1;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



      

        private void bunifuUserControl1_Click(object sender, EventArgs e)
        {

        }



        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MemoryStream MS = new MemoryStream();
            pictureBox1.Image.Save(MS, ImageFormat.Png);
            byte[] Bytes = MS.ToArray();
            if (cbxCategoria.Text.Length != 0)
            {
                if (cbxCategoria.Text.Length != 0)
                {
                    errorProvider1.SetError(cbxCategoria, "");
                }
                if (txbproducto.Text.Length != 0)
                {
                    if (txbproducto.Text.Length != 0)
                    {
                        errorProvider1.SetError(txbproducto, "");
                    }
                    if (cbxUnidad.Text.Length != 0)
                    {
                        if (cbxUnidad.Text.Length != 0)
                        {
                            errorProvider1.SetError(cbxUnidad, "");
                        }
                        if (tbxcantidad.Text.Length!=0)
                        {
                            if (tbxcantidad.Text.Length != 0)
                            {
                                errorProvider1.SetError(tbxcantidad, "");
                            }
                            if(tbxpc.Text.Length!=0)
                            {
                                if (tbxpc.Text.Length != 0)
                                {
                                    errorProvider1.SetError(tbxpc, "");
                                }
                                if(txbxpv.Text.Length!=0)
                                {
                                    if (txbxpv.Text.Length != 0)
                                    {
                                        errorProvider1.SetError(txbxpv, "");
                                    }
                                    if (Program.Evento == 0)
                                    {
                                        Variable.Categoria = Convert.ToInt32(cbxCategoria.SelectedValue.ToString());
                                        Variable.Nombre_Producto = txbproducto.Text;
                                        Variable.Marca = txbxmarca.Text;
                                        Variable.Tipo = Convert.ToInt32(cbxUnidad.SelectedValue.ToString());
                                        Variable.Cantidad = Convert.ToInt32(tbxcantidad.Text);
                                        Variable.Precio_Compra = Convert.ToDecimal(tbxpc.Text);
                                        Variable.Precio_Venta = Convert.ToDecimal(txbxpv.Text);
                                        Variable.Imagen = Bytes;
                                        Variable.RegistrarProductos();

                                        Productos_I D = new Productos_I();
                                        this.Visible = false;
                                        bunifuSnackbar1.Show(D, "Producto agregado exitosamente");

                                        D.CargarListado();
                                    }
                                    else if(Program.Evento==1)
                                    {
                                        Variable.Categoria = Convert.ToInt32(cbxCategoria.SelectedValue.ToString());
                                        Variable.Nombre_Producto = txbproducto.Text;
                                        Variable.Marca = txbxmarca.Text;
                                        Variable.Tipo = Convert.ToInt32(cbxUnidad.SelectedValue.ToString());
                                        Variable.Cantidad = Convert.ToInt32(tbxcantidad.Text);
                                        Variable.Precio_Compra = Convert.ToDecimal(tbxpc.Text);
                                        Variable.Precio_Venta = Convert.ToDecimal(txbxpv.Text);
                                        Variable.Imagen = Bytes;
                                        Variable.AtualizarProductos();

                                        Productos_I D = new Productos_I();
                                        this.Visible = false;
                                        bunifuSnackbar1.Show(D, "Producto Actualizado exitosamente");

                                        D.CargarListado();
                                    }
                                }
                                else
                                {
                                    errorProvider1.SetError(txbxpv, "No se Haceptan valores vacios");
                                }
                               
                            }
                            else
                            {
                                errorProvider1.SetError(tbxpc, "No se Haceptan valores vacios");
                            }
                          
                        }
                        else
                        {
                            errorProvider1.SetError(tbxcantidad, "No se Haceptan valores vacios");
                        }
                       
                    }
                    else
                    {
                        errorProvider1.SetError(cbxUnidad, "No se Haceptan valores vacios");
                    }

                }
                else
                {
                    errorProvider1.SetError(txbproducto, "No se Haceptan valores vacios");
                }
            }
            else
            {
                errorProvider1.SetError(cbxCategoria, "No se Haceptan valores vacios");
            } 
           
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { 
            
        }

        private void btnelegirimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdseleccionar = new OpenFileDialog();
            ofdseleccionar.Filter = "Imagenes|*.jpg; *png";
            ofdseleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            ofdseleccionar.Title = "Seleccionar imagen";

            if(ofdseleccionar.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofdseleccionar.FileName);
            }
        }
    }
}
