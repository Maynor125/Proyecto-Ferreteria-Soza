using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Capa_Acceso_de_Datos
{
    public class Parametros
    {
        public String Nombre { get; set; }
        public Object Valor { get; set; }
        public MySqlDbType TipoDato { get; set; }
        public ParameterDirection Direccion { get; set; }
        public int Tamaño { get; set; }

        public Parametros(String objNombre, Object objValor)
        {
            Nombre = objNombre;
            Valor = objValor;
            Direccion = ParameterDirection.Input;
        }

        public Parametros(String objNombre, Object objValor, MySqlDbType objTipoDato, ParameterDirection objDireccion, int objTamaño)
        {
            Nombre = objNombre;
            Valor = objValor;
            TipoDato = objTipoDato;
            Direccion = objDireccion;
            Tamaño = objTamaño;
        }
    }
}
