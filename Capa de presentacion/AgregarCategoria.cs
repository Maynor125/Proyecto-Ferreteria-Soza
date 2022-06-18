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
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void AgregarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Productos_I d = new Productos_I();
            Categoria Variable = new Categoria();
            if (guna2TextBox1.Text.Length != 0)
            {
                errorProvider1.SetError(guna2TextBox1, "");
                if (Program.Evento == 0)
                {
                    Variable.Nombre = guna2TextBox1.Text;
                    Variable.Registrarcategorias();

                    this.Visible = false;
                    bunifuSnackbar1.Show(d, "Categoria agregada exitosamente");

                }
                else if(Program.Evento==1)
                {
                    Variable.Nombre = guna2TextBox1.Text;
                    Variable.AtualizarCategoria();

                    this.Visible = false;
                    bunifuSnackbar1.Show(d, "Categoria Actualizada exitosamente");

                }
            }
            else
            {
                errorProvider1.SetError(guna2TextBox1, "No se Haceptan valores vacios");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
