using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Acceso_de_Datos;

namespace Capa_Logica_Del_Negocio
{
    public class Empleado
    {
        Conexion_de_datos CD = new Conexion_de_datos();
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public DataTable Listar_Empleado()
        {
            return CD.Listado("MostrarEmpleado", null);
        }
        public void RegistrarEmpleados()
        {

            List<Parametros> lst = new List<Parametros>();

            try
            {
                lst.Add(new Parametros("@cedula", Cedula));
                lst.Add(new Parametros("@apellidos", Apellidos));
                lst.Add(new Parametros("@nombres", Nombres));
                lst.Add(new Parametros("@sexo", Sexo));
                lst.Add(new Parametros("@direccion", Direccion));
                lst.Add(new Parametros("@telefono", Telefono));
                CD.EjecutarProcedimientosalmacenados("Ingresarempleado", ref lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ActualizarEmpleados()
        {

            List<Parametros> lst = new List<Parametros>();

            try
            {

                lst.Add(new Parametros("@Id_e", Id));
                lst.Add(new Parametros("@cedula", Cedula));
                lst.Add(new Parametros("@apellidos", Apellidos));
                lst.Add(new Parametros("@nombres", Nombres));
                lst.Add(new Parametros("@sexo", Sexo));
                lst.Add(new Parametros("@direccion", Direccion));
                lst.Add(new Parametros("@telefono", Telefono));
                CD.EjecutarProcedimientosalmacenados("ActualizarEmpleado", ref lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarEmpleados()
        {

            List<Parametros> lst = new List<Parametros>();

            try
            {
                lst.Add(new Parametros("@Id", Id));
                CD.EjecutarProcedimientosalmacenados("eliminarempleado", ref lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
