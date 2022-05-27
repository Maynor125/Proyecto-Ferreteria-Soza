using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Capa_de_presentacion
{
    public partial class FormPricipal1 : Form
    {
        private IconButton btn1;
        public FormPricipal1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "inactivar botones");
            toolTip1.SetToolTip(iconPictureBox1, "Cerrar");
            toolTip1.SetToolTip(iconPictureBox2, "Maximizar");
            toolTip1.SetToolTip(iconPictureBox3, "Minimizar");
            toolTip1.SetToolTip(iconPictureBox4, "ir al area de ayuda");
            toolTip1.SetToolTip(iconomenu, "Desplazar Menu");
            toolTip1.SetToolTip(bunifuPictureBox1, "El roro ha iniciado Secion");
            panel2.Height = 39;
            panel2.Width = 185;
            panel3.Height = 39;
            panel3.Width = 185;
            panel4.Height = 39;
            panel4.Width = 185;
            panel5.Height = 39;
            panel5.Width = 185;
            panel6.Height = 39;
            panel6.Width = 185;
            panel7.Height = 39;
            panel7.Width = 185;
            panel8.Height = 39;
            panel8.Width = 185;
            //panel1.Width = 8;
            panel2.Location = new Point(17, 101);
            panel3.Location = new Point(17, 140);
            panel4.Location = new Point(17, 179);
            panel5.Location = new Point(17, 218);
            panel6.Location = new Point(17, 257);
            panel7.Location = new Point(17, 296);
            panel8.Location = new Point(17, 335);
            panel6.BackColor = Color.FromArgb(61, 99, 157);
            panel7.BackColor = Color.FromArgb(61, 99, 157);
            panel8.BackColor = Color.FromArgb(61, 99, 157);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
            iconButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
            iconButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
            iconButton14.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
            iconButton17.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
            iconButton22.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
        }
        private void activarbtn(object btn, Color color)
        {
            if (btn != null)
            {
                desactivarbtn();

                btn1 = (IconButton)btn;
                btn1.BackColor = Color.FromArgb(52, 67, 98);
                btn1.ForeColor = color;
                btn1.TextAlign = ContentAlignment.MiddleCenter;
                btn1.IconColor = color;
                btn1.TextImageRelation = TextImageRelation.TextBeforeImage;
                btn1.ImageAlign = ContentAlignment.MiddleRight;
                //--------------------------------------------------------------.
                iconoinicio.IconChar = btn1.IconChar;
                iconoinicio.IconColor = color;
                label2.Text = btn1.Text;
                label2.ForeColor = color;
            }
        }

        public void desactivarbtn()
        {
            if (btn1 != null)
            {
                btn1.BackColor = Color.Transparent;
                btn1.ForeColor = Color.White;
                btn1.TextAlign = ContentAlignment.MiddleLeft;
                btn1.IconColor = Color.FromArgb(232, 104, 56);
                btn1.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn1.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

       
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (panel2.Height == 114)
            {
                iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);

                panel3.Location = new Point(17, 140);
                panel4.Location = new Point(17, 179);
                panel5.Location = new Point(17, 218);
                panel6.Location = new Point(17, 257);
                panel7.Location = new Point(17, 296);
                panel8.Location = new Point(17, 335);
                panel6.BackColor = Color.FromArgb(61, 99, 157);
                panel7.BackColor = Color.FromArgb(61, 99, 157);
                panel8.BackColor = Color.FromArgb(61, 99, 157);
                panel2.BackColor = Color.FromArgb(61, 99, 157);
                panel2.Height = 39;

            }
            else
            {
                if (panel2.Height == 39)

                    iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 67, 98);
                iconButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton14.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton17.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton22.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                panel2.BackColor = Color.FromArgb(52, 67, 98);
                panel2.Height = 114;
                panel3.Height = 39;
                panel3.BackColor = Color.FromArgb(61, 99, 157);
                panel4.Height = 39;
                panel5.Height = 39;
                panel5.BackColor = Color.FromArgb(61, 99, 157);
                panel6.Height = 39;
                panel6.BackColor = Color.FromArgb(61, 99, 157);
                panel4.BackColor = Color.FromArgb(61, 99, 157);
                panel8.Height = 39;
                panel8.BackColor = Color.FromArgb(61, 99, 157);
                panel3.Location = new Point(17, 216);
                panel4.Location = new Point(17, 255);
                panel5.Location = new Point(17, 294);
                panel6.Location = new Point(17, 333);
                panel7.Location = new Point(17, 372);
                panel8.Location = new Point(17, 411);
                panel7.Height = 39;
                panel7.BackColor = Color.FromArgb(61, 99, 157);

            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            if (panel3.Height == 114)
            {
                iconButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                panel3.Location = new Point(17, 140);
                panel4.Location = new Point(17, 179);
                panel5.Location = new Point(17, 218);
                panel6.Location = new Point(17, 257);
                panel7.Location = new Point(17, 296);
                panel8.Location = new Point(17, 335);
                panel6.BackColor = Color.FromArgb(61, 99, 157);
                panel7.BackColor = Color.FromArgb(61, 99, 157);
                panel8.BackColor = Color.FromArgb(61, 99, 157);
                panel3.BackColor = Color.FromArgb(61, 99, 157);
                panel3.Height = 39;
            }
            else
            {
                if (panel3.Height == 39)
                {

                    iconButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 67, 98);
                    iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                    iconButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                    iconButton14.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                    iconButton17.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                    iconButton22.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                    iconButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                    panel3.Height = 114;
                    panel3.BackColor = Color.FromArgb(52, 67, 98);
                    panel3.Location = new Point(17, 140);
                    panel2.Height = 39;
                    panel2.BackColor = Color.FromArgb(61, 99, 157);
                    panel4.Height = 39;
                    panel4.BackColor = Color.FromArgb(61, 99, 157);
                    panel4.Location = new Point(17, 254);
                    panel5.Location = new Point(17, 293);
                    panel6.Location = new Point(17, 333);
                    panel7.Location = new Point(17, 372);
                    panel8.Location = new Point(17, 411);
                    panel5.Height = 39;
                    panel5.BackColor = Color.FromArgb(61, 99, 157);
                    panel6.Height = 39;
                    panel6.BackColor = Color.FromArgb(61, 99, 157);
                    panel7.Height = 39;
                    panel7.BackColor = Color.FromArgb(61, 99, 157);
                    panel8.Height = 39;
                    panel8.BackColor = Color.FromArgb(61, 99, 157);
                }
            }
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            if (panel4.Height == 113)
            {
                iconButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                panel3.Location = new Point(17, 140);
                panel4.Location = new Point(17, 179);
                panel5.Location = new Point(17, 218);
                panel6.Location = new Point(17, 257);
                panel7.Location = new Point(17, 296);
                panel8.Location = new Point(17, 335);
                panel6.BackColor = Color.FromArgb(61, 99, 157);
                panel7.BackColor = Color.FromArgb(61, 99, 157);
                panel8.BackColor = Color.FromArgb(61, 99, 157);
                panel4.BackColor = Color.FromArgb(61, 99, 157);
                panel4.Height = 39;
            }
            else
            {

                iconButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 67, 98);
                iconButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton14.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton17.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton22.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                panel3.Location = new Point(17, 140);
                panel2.Height = 39;
                panel2.BackColor = Color.FromArgb(61, 99, 157);
                panel4.Height = 113;
                panel4.BackColor = Color.FromArgb(52, 67, 98);
                panel4.Location = new Point(17, 179);
                panel3.Height = 39;
                panel7.Height = 39;
                panel7.BackColor = Color.FromArgb(61, 99, 157);
                panel3.BackColor = Color.FromArgb(61, 99, 157);
                panel5.Location = new Point(17, 292);
                panel6.Location = new Point(17, 331);
                panel5.Height = 39;
                panel5.BackColor = Color.FromArgb(61, 99, 157);
                panel6.Height = 39;
                panel6.BackColor = Color.FromArgb(61, 99, 157);
                panel7.Location = new Point(17, 371);
                panel8.Location = new Point(17, 410);
                panel8.Height = 39;
                panel8.BackColor = Color.FromArgb(61, 99, 157);
            }
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            if (panel5.Height == 80)
            {
                iconButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                panel3.Location = new Point(17, 140);
                panel4.Location = new Point(17, 179);
                panel5.Location = new Point(17, 218);
                panel6.Location = new Point(17, 257);
                panel7.Location = new Point(17, 296);
                panel8.Location = new Point(17, 335);
                panel6.BackColor = Color.FromArgb(61, 99, 157);
                panel7.BackColor = Color.FromArgb(61, 99, 157);
                panel8.BackColor = Color.FromArgb(61, 99, 157);
                panel5.BackColor = Color.FromArgb(61, 99, 157);
                panel5.Height = 39;
            }
            else
            {

                iconButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 67, 98);
                iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton14.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton17.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton22.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                panel5.Location = new Point(17, 218);
                panel2.Height = 39;
                panel2.BackColor = Color.FromArgb(61, 99, 157);
                panel3.Height = 39;
                panel3.BackColor = Color.FromArgb(61, 99, 157);
                panel4.Height = 39;
                panel4.BackColor = Color.FromArgb(61, 99, 157);
                panel5.BackColor = Color.FromArgb(52, 67, 98);
                panel7.Height = 39;
                panel7.BackColor = Color.FromArgb(61, 99, 157);
                panel5.Height = 80;
                panel8.Height = 39;
                panel8.BackColor = Color.FromArgb(61, 99, 157);
                panel3.Location = new Point(17, 140);
                panel4.Location = new Point(17, 179);
                panel6.Location = new Point(17, 298);
                //panel7.Location = new Point(17, 372);
                panel6.Height = 39;
                panel6.BackColor = Color.FromArgb(61, 99, 157);
                panel7.Location = new Point(17, 337);
                panel8.Location = new Point(17, 376);
            }
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            if (panel6.Height == 112)
            {
                iconButton14.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                panel3.Location = new Point(17, 140);
                panel4.Location = new Point(17, 179);
                panel5.Location = new Point(17, 218);
                panel6.Location = new Point(17, 257);
                panel7.Location = new Point(17, 296);
                panel8.Location = new Point(17, 335);
                panel6.BackColor = Color.FromArgb(61, 99, 157);
                panel7.BackColor = Color.FromArgb(61, 99, 157);
                panel8.BackColor = Color.FromArgb(61, 99, 157);
                panel6.BackColor = Color.FromArgb(61, 99, 157);
                panel6.Height = 39;
            }
            else
            {

                iconButton14.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 67, 98);
                iconButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton17.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton22.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);

                panel2.Height = 39;
                panel2.BackColor = Color.FromArgb(61, 99, 157);
                panel3.Height = 39;
                panel3.BackColor = Color.FromArgb(61, 99, 157);
                panel4.Height = 39;
                panel4.BackColor = Color.FromArgb(61, 99, 157);
                panel5.Height = 39;
                panel5.BackColor = Color.FromArgb(61, 99, 157);
                panel7.Height = 39;
                panel7.BackColor = Color.FromArgb(61, 99, 157);
                panel6.BackColor = Color.FromArgb(52, 67, 98);
                panel6.Height = 112;
                panel8.Height = 39;
                panel8.BackColor = Color.FromArgb(61, 99, 157);
                panel3.Location = new Point(17, 140);
                panel4.Location = new Point(17, 179);
                panel5.Location = new Point(17, 218);
                panel6.Location = new Point(17, 257);
                panel7.Location = new Point(17, 369);
                panel8.Location = new Point(17, 408);
            }
        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            if (panel7.Height == 145)
            {
                iconButton17.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                panel3.Location = new Point(17, 140);
                panel4.Location = new Point(17, 179);
                panel5.Location = new Point(17, 218);
                panel6.Location = new Point(17, 257);
                panel7.Location = new Point(17, 296);
                panel8.Location = new Point(17, 335);
                panel6.BackColor = Color.FromArgb(61, 99, 157);
                panel7.BackColor = Color.FromArgb(61, 99, 157);
                panel8.BackColor = Color.FromArgb(61, 99, 157);
                panel7.BackColor = Color.FromArgb(61, 99, 157);
                panel7.Height = 39;
            }
            else
            {

                iconButton17.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 67, 98);
                iconButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton14.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton22.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);

                panel2.Height = 39;
                panel2.BackColor = Color.FromArgb(61, 99, 157);
                panel3.Height = 39;
                panel3.BackColor = Color.FromArgb(61, 99, 157);
                panel4.Height = 39;
                panel4.BackColor = Color.FromArgb(61, 99, 157);
                panel5.Height = 39;
                panel5.BackColor = Color.FromArgb(61, 99, 157);
                panel6.Height = 39;
                panel6.BackColor = Color.FromArgb(61, 99, 157);
                panel8.Height = 39;
                panel8.BackColor = Color.FromArgb(61, 99, 157);
                panel7.BackColor = Color.FromArgb(52, 67, 98);
                panel3.Location = new Point(17, 140);
                panel4.Location = new Point(17, 179);
                panel5.Location = new Point(17, 218);
                panel6.Location = new Point(17, 257);
                panel7.Location = new Point(17, 296);
                panel8.Location = new Point(17, 441);
                panel7.Height = 145;
            }
        }

        private void iconButton22_Click(object sender, EventArgs e)
        {
            if (panel8.Height == 145)
            {
                iconButton22.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                panel3.Location = new Point(17, 140);
                panel4.Location = new Point(17, 179);
                panel5.Location = new Point(17, 218);
                panel6.Location = new Point(17, 257);
                panel7.Location = new Point(17, 296);
                panel8.Location = new Point(17, 335);
                panel6.BackColor = Color.FromArgb(61, 99, 157);
                panel7.BackColor = Color.FromArgb(61, 99, 157);
                panel8.BackColor = Color.FromArgb(61, 99, 157);
                panel8.BackColor = Color.FromArgb(61, 99, 157);
                panel8.Height = 39;
            }
            else
            {

                iconButton22.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 67, 98);
                iconButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton14.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton17.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
                iconButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);

                panel2.Height = 39;
                panel2.BackColor = Color.FromArgb(61, 99, 157);
                panel3.Height = 39;
                panel3.BackColor = Color.FromArgb(61, 99, 157);
                panel4.Height = 39;
                panel4.BackColor = Color.FromArgb(61, 99, 157);
                panel5.Height = 39;
                panel5.BackColor = Color.FromArgb(61, 99, 157);
                panel6.Height = 39;
                panel6.BackColor = Color.FromArgb(61, 99, 157);
                panel7.Height = 39;
                panel7.BackColor = Color.FromArgb(61, 99, 157);
                panel8.BackColor = Color.FromArgb(52, 67, 98);
                panel8.Height = 112;
                panel8.Location = new Point(17, 335);
                panel6.Location = new Point(17, 257);
                panel7.Location = new Point(17, 296);
                panel3.Location = new Point(17, 140);
                panel4.Location = new Point(17, 179);
                panel5.Location = new Point(17, 218);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            desactivarbtn();
            panel3.Location = new Point(17, 140);
            panel4.Location = new Point(17, 179);
            panel5.Location = new Point(17, 218);
            panel6.Location = new Point(17, 257);
            panel7.Location = new Point(17, 296);
            panel8.Location = new Point(17, 335);
            panel2.BackColor = Color.FromArgb(61, 99, 157);
            panel2.Height = 39;
            panel3.BackColor = Color.FromArgb(61, 99, 157);
            panel3.Height = 39;
            panel4.BackColor = Color.FromArgb(61, 99, 157);
            panel4.Height = 39;
            panel5.BackColor = Color.FromArgb(61, 99, 157);
            panel5.Height = 39;
            panel6.BackColor = Color.FromArgb(61, 99, 157);
            panel6.Height = 39;
            panel7.BackColor = Color.FromArgb(61, 99, 157);
            panel7.Height = 39;
            panel8.BackColor = Color.FromArgb(61, 99, 157);
            panel8.Height = 39;
            //-------------------------------------------------------------------------.
            iconButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
            iconButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
            iconButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
            iconButton14.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
            iconButton17.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);
            iconButton22.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 38, 71);

            iconoinicio.IconChar = IconChar.Home;
            iconoinicio.IconColor = Color.FromArgb(242, 137, 105);
            label2.Text = "Inicio";
            label2.ForeColor = Color.FromArgb(242, 137, 105);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnopciones2_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(227, 239, 241));
        }

        private void btnopciones1_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(227, 239, 241));
        }

        private void btnreporte1_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(227, 239, 241));
        }

        private void btnreporte2_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(227, 239, 241));
        }

        private void btnreporte3_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(227, 239, 241));
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            Form Fondo = new Form();
            using (usuario us = new usuario())
            {


                Fondo.StartPosition = FormStartPosition.CenterScreen;
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

        private void bunifuPictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void bunifuPictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void btnopciones3_Click(object sender, EventArgs e)
        {
            InicioSecion u = new InicioSecion();

            this.Visible = false;
            u.Visible = true;
        }

        private void PanelContenedor_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
        public void Abrir_Form(object FormEstad)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = FormEstad as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }
        private void btnal1_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(225, 225, 225));
            Abrir_Form(new Empleados());
        }

        private void btnal2_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(225,225,225));
            Abrir_Form(new Pago_para_Empleados());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            InicioSecion u = new InicioSecion();

            this.Visible = false;
            u.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContenedor_Click_1(object sender, EventArgs e)
        {

        }

        private void btnusuario1_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(227, 239, 241));
        }

        private void btncompras1_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(227, 239, 241));
        }

        private void btncompras2_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(227, 239, 241));
        }

        private void btnventas1_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(227, 239, 241));
        }

        private void btnventas2_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(227, 239, 241));
        }

        private void btnalmacen1_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(227, 239, 241));
        }

        private void btnalmacen2_Click(object sender, EventArgs e)
        {
            activarbtn(sender, Color.FromArgb(227, 239, 241));
        }

        private void iconomenu_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_MouseHover(object sender, EventArgs e)
        {
            guna2GradientCircleButton1.Image = Image.FromFile(@"C:\Users\maynor\Downloads\S.png");
        }

        private void iconomenu_MouseHover(object sender, EventArgs e)
        {
            iconomenu.IconColor = Color.FromArgb(255, 255, 255);
            iconomenu.IconSize = 58;
        }
       
        private void iconomenu_MouseLeave(object sender, EventArgs e)
        {
            iconomenu.IconColor = Color.FromArgb(243, 150, 106);
            iconomenu.IconSize = 56;
        }

        private void guna2GradientCircleButton1_MouseLeave(object sender, EventArgs e)
        {
            guna2GradientCircleButton1.Image = Image.FromFile("ninguno");
        }
    }
}
