using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Acceso_de_Datos;
using System.Data.SqlClient;
using System.Data;
namespace Capa_Logica_Del_Negocio
{
    public class Reporteventas
    {
        OrdenDatos O = new OrdenDatos();
        public DateTime FechaReporte { get; private set; }
        public DateTime Fechainicio { get; private set; }
        public DateTime Fechafinal { get; private set; }

        public List<SalesListengs> salesListengs { get; private set; }
        public List<NetsalesByPeriod> netsalesByPeriod { get; private set; }

        public double TotalV { get; private set; }

        public DataTable  ReportePM(DateTime FInicio,DateTime FFinal)
        {
            DataTable M = new DataTable();
            Fechainicio = FInicio;
            Fechafinal = FFinal;

            int Dia = Convert.ToInt32((FInicio - FFinal).Days);
           M= O.OrdenPM(FInicio, FFinal);
            return M;
        }

        public DataTable ReporteDPM(DateTime FInicio,int ID)
        {
            DataTable M = new DataTable();
        
            M = O.OrdenDPM(FInicio,ID);
            return M;
        }

        //public bool consulta_M(string b)
        //{
        //    bool t;
        //    t = O.VerificaciontexboxM(b);
        //    return t;
        //}

        public void CrearReportes(DateTime Finicio, DateTime Ffinal)
        {
            //Datos de inicio.
            FechaReporte = DateTime.Now;
            Fechainicio = Finicio;
            Fechafinal = Ffinal;

            //Listado de ventas.
            var listado = new OrdenDatos();
            var Resultado = listado.Orden(Finicio, Ffinal);

            salesListengs = new List<SalesListengs>();
            foreach(System.Data.DataRow row in Resultado.Rows)
            {
                var Lis = new SalesListengs()
                {
                    ID = Convert.ToInt32(row[0]),
                    Fecha = Convert.ToDateTime(row[1]),
                    Cliente = Convert.ToString(row[2]),
                    //Descripcion = Convert.ToString(row[3]),
                    Total = Convert.ToDouble(row[3])
                };
                salesListengs.Add(Lis);

                TotalV += Convert.ToDouble(row[3]);
            }


            var listSalesByDate = (from sales in salesListengs
                                   group sales by sales.Fecha
            into listSales
                                   select new
                                   {
                                       date = listSales.Key,
                                       amount = listSales.Sum(item => item.Total)
                                   }).AsEnumerable();

            //Ventas por periodo.
            var Listadoxfecha=(from Ventas in salesListengs
                               group Ventas by Ventas.Fecha
                               into listaV
                               select new
                               {
                                   F=listaV.Key,
                                   amount = listaV.Sum(item => item.Total)
                               }).AsEnumerable();


            //Dias.
            int Dia = Convert.ToInt32((Finicio - Ffinal).Days);

            //Agrupacion por dias.
            if(Dia<=7)
            {
                netsalesByPeriod=(from Ventas in listSalesByDate
                                  group Ventas by Ventas.date.ToString("dd-MMM-yyyy")
                                  into listavt
                                  select new NetsalesByPeriod
                                  {
                                      Periodo = listavt.Key,
                                      ventaxperiodo = listavt.Sum(item => item.amount)
                                  }).ToList();
            }

            if(Dia<=30)
            {
                netsalesByPeriod = (from Ventas in listSalesByDate
                                    group Ventas by System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                  Ventas.date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                  into listavt
                                    select new NetsalesByPeriod
                                    {
                                        Periodo ="Week"+listavt.Key,
                                        ventaxperiodo = listavt.Sum(item => item.amount)
                                    }).ToList();
            }

            if(Dia<=365)
            {
                netsalesByPeriod = (from Ventas in listSalesByDate 
                                    group Ventas by Ventas.date.ToString("MMM-yyyy")
                                 into listavt
                                    select new NetsalesByPeriod
                                    {
                                        Periodo = listavt.Key,
                                        ventaxperiodo = listavt.Sum(item => item.amount)
                                    }).ToList();
            }
            else
            {
                netsalesByPeriod = (from Ventas in listSalesByDate
                                    group Ventas by Ventas.date.ToString("yyyy")
                                 into listavt
                                    select new NetsalesByPeriod
                                    {
                                        Periodo = listavt.Key,
                                        ventaxperiodo = listavt.Sum(item => item.amount)
                                    }).ToList();
            }
        }
       

    }
}
