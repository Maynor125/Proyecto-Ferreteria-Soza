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
    public partial class InicioSecion : Form
    {
        public InicioSecion()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            FormPrincipal2 F2 = new FormPrincipal2();
            F2.Show();

            this.Visible = false;
            //this.Close();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void InicioSecion_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(iconPictureBox1, "Salir");
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string user1 = "Administrador";
            var user2 = "Trabajador";
            var pass1 = "12345678";
            var pass2 = "123456";
            var U1 = tbxuser.Text.ToString();
            var U2 = txbpsw.Text.ToString();

            FormPrincipal2 F2 = new FormPrincipal2();
            FormPricipal1 F1 = new FormPricipal1();

            if (user1 == U1 && pass1 == U2)
            {
                F1.Show();
                this.Visible = false;
            }
            else if (user2 == U1 && pass2 == U2)
            {
                F2.Show();
                this.Visible = false;
            }
            else
            {
                InicioSecion yo = new InicioSecion();
                bunifuSnackbar1.Show(yo, "Datos incorrectos",
          Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 3000);
            }



            //this.Close();
        }
    }
}
