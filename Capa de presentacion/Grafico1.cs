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
    public partial class Grafico1 : Form
    {
        public Grafico1()
        {
            InitializeComponent();
        }
        private void Obtener_Reporte(DateTime FIni, DateTime Ffin)
        {
            Reporteventas ObejetoR = new Reporteventas();
            ObejetoR.CrearReportes(FIni, Ffin);

            ReporteventasBindingSource.DataSource = ObejetoR;
            SalesListengsBindingSource.DataSource = ObejetoR.salesListengs;
            NetsalesByPeriodBindingSource.DataSource = ObejetoR.netsalesByPeriod;

            this.reportViewer1.RefreshReport();
        }

        private void Grafico1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
           
            dateTimePicker1.Enabled = false;

            dateTimePicker2.Enabled = false;


            button7.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chart1.Visible = false;
            label3.Visible = false;
            var FevhaA = DateTime.Today;
            var FechaT = DateTime.Now;

            Obtener_Reporte(FevhaA, FechaT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chart1.Visible = false;
            label3.Visible = false;
            var FevhaA = DateTime.Today.AddDays(-7);
            var FechaT = DateTime.Now;

            Obtener_Reporte(FevhaA, FechaT);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //chart1.Visible = false;
            label3.Visible = false;
            var FevhaA = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var FechaT = DateTime.Now;

            Obtener_Reporte(FevhaA, FechaT);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //chart1.Visible = false;
            label3.Visible = false;
            var FevhaA = DateTime.Today.AddDays(-30);
            var FechaT = DateTime.Now;

            Obtener_Reporte(FevhaA, FechaT);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //chart1.Visible = false;
            label3.Visible = false;
            var FevhaA = new DateTime(DateTime.Now.Year, 1, 1);
            var FechaT = DateTime.Now;

            Obtener_Reporte(FevhaA, FechaT);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;

            dateTimePicker2.Enabled = true;

            button7.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //chart1.Visible = false;
            label3.Visible = false;
            var FevhaA = dateTimePicker1.Value;
            var FechaT = dateTimePicker2.Value;

            Obtener_Reporte(FevhaA, new DateTime(FechaT.Year, FechaT.Month, FechaT.Day, 23, 59, 59));
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            //this.chart1.Series["LiniaG"].Points.AddXY("LUNES", 10);
            //this.chart1.Series["LiniaG"].Points.AddXY("MARTES", 20);
            //this.chart1.Series["LiniaG"].Points.AddXY("MIERCOLES", 30);
            //this.chart1.Series["LiniaG"].Points.AddXY("JUEVES", 40);
            //this.chart1.Series["LiniaG"].Points.AddXY("VIERNES", 20);
            //this.chart1.Series["LiniaG"].Points.AddXY("SABADO", 60);
            //this.chart1.Series["LiniaG"].Points.AddXY("DOMINGO", 50);
        }

        private void ReporteventasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
