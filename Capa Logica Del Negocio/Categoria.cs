using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Acceso_de_Datos;
using System.Data;

namespace Capa_Logica_Del_Negocio
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        Conexion_de_datos CD = new Conexion_de_datos();

        public DataTable Listar_Categoria()
        {
            return CD.Listado("ListarCategoria", null);
        }
        public void Registrarcategorias()
        {

            List<Parametros> lst = new List<Parametros>();

            try
            {
                lst.Add(new Parametros("@Nombrecategoria", Nombre));
                CD.EjecutarProcedimientosalmacenados("AgregarCategoria", ref lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AtualizarCategoria()
        {

            List<Parametros> lst = new List<Parametros>();

            try
            {
                lst.Add(new Parametros("@Id",ID));
                lst.Add(new Parametros("@Nombrecategoria", Nombre));
                CD.EjecutarProcedimientosalmacenados("ActualizarCategoria", ref lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarArticulos()
        {

            List<Parametros> lst = new List<Parametros>();

            try
            {
                lst.Add(new Parametros("@Id", ID));
                CD.EjecutarProcedimientosalmacenados("EliminarCategoria", ref lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
