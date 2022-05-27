using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Capa_Acceso_a_datos
{
   
    class Parametros
    {
        private String Nombre { get; set; }
        private Object Valor { get; set; }
        private SqlDbType TipoDato { get; set; }
        private ParameterDirection Direccion { get; set; }
        private int Tamaño { get; set; }

        public Parametros(String objNombre, Object objValor)
        {
            Nombre = objNombre;
            Valor = objValor;
            Direccion = ParameterDirection.Input;
        }

        public Parametros(String objNombre, Object objValor, SqlDbType objTipoDato, ParameterDirection objDireccion, int objTamaño)
        {
            Nombre = objNombre;
            Valor = objValor;
            TipoDato = objTipoDato;
            Direccion = objDireccion;
            Tamaño = objTamaño;
        }

    }
}
