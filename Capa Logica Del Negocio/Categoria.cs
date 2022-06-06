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
    }
   
}
