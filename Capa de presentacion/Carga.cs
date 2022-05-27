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
    public partial class Carga : Form
    {
        int tiempo = 0;
        

        public Carga()
        {
           
            InitializeComponent();
            bunifuCircleProgress1.Value = 0;
        }
        InicioSecion I = new InicioSecion();
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            bunifuCircleProgress1.Value += 1;
            bunifuCircleProgress1.Text = bunifuCircleProgress1.Value.ToString() + "%";
            if(bunifuCircleProgress1.Value==100)
            {
                timer1.Enabled = false;
                this.Visible = false;
                I.Show();
               
            }



            //bunifuCircleProgress1.Increment(1);
            //bunifuCircleProgress1.Value = tiempo;
            //if (bunifuCircleProgress1.Value==100)
            //{
            //    //bunifuCircleProgress1.Value = 0;
            //    //timer1.Stop();
            //    //I.Show();
            //    //this.Visible = false;

            //}
        }

        private void Carga_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
