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
    public partial class FormPrincipal2 : Form
    {
        Button Boton;
       private Bunifu.UI.WinForms.BunifuPanel PanelB;
        
        public FormPrincipal2()
        {
            InitializeComponent();
            PanelB = new Bunifu.UI.WinForms.BunifuPanel();
            PanelB.Size = new Size(144, 10);
            panel1.Controls.Add(PanelB);
            PanelB.BorderRadius = 5;
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            FormPrincipal2 F = new FormPrincipal2();
            var a=F.StartPosition;
            Form Fondo = new Form();
            using (usuario us = new usuario())
            {

                Fondo.StartPosition = a;
                Fondo.FormBorderStyle = FormBorderStyle.None;
                Fondo.Opacity = .70d;
                Fondo.BackColor = Color.Black;
                Fondo.Height = 684;
                Fondo.Width = 1180;
                //Fondo.WindowState = FormWindowState.Maximized;
                Fondo.TopMost = true;
                //Fondo.Location = this.Location;
                Fondo.ShowInTaskbar = false;
                Fondo.Show();

                us.Owner = Fondo;
                us.ShowDialog();

                Fondo.Dispose();
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
          //  barrra.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

    
        private void Activar_panel(object B,Color C)
        {
            if (B != null)
            {
                Boton = (Button)B;
                PanelB.BackgroundColor = C;
                PanelB.Location = new Point(Boton.Location.X,45);
                PanelB.Visible = true;
                PanelB.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Activar_panel(sender, Color.FromArgb(34, 78, 145));
            
           
        }

        private void FormPrincipal2_Load(object sender, EventArgs e)
        {
            Abrir_Form(new Fondo()); 
            toolTip1.SetToolTip(iconPictureBox1, "Cerrar");
            toolTip1.SetToolTip(iconPictureBox2, "Maximizar");
            toolTip1.SetToolTip(iconPictureBox3, "Minimizar");
            toolTip1.SetToolTip(pictureBox1, "Serrar Secion");
            toolTip1.SetToolTip(bunifuPictureBox1, "El roro ha iniciado Secion");

        }
        public void Abrir_Form(object FormEstad)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = FormEstad as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }
        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            bunifuPanel1.Visible = false;
            Activar_panel(sender, Color.FromArgb(34, 78, 145));
            Abrir_Form(new Articulos2());
         
        }
        string yo;
        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormPrincipal2 yo = new FormPrincipal2();
            bunifuSnackbar1.Show(yo,"Bienvenido al area de ventas",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,4000);
            Abrir_Form(new Fondo());
            bunifuPanel1.Visible = false;
            Activar_panel(sender, Color.FromArgb(242, 137, 105));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Abrir_Form(new Ventas());
            bunifuPanel1.Visible = false;
            Activar_panel(sender, Color.FromArgb(242, 137, 105));
            //Abrir_Form(new Datos2());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InicioSecion u = new InicioSecion();

            this.Visible = false;
            u.Visible = true;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Abrir_Form(new Almacen());
            bunifuPanel1.Visible = false;
            Activar_panel(sender, Color.FromArgb(242, 137, 105));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuPanel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
