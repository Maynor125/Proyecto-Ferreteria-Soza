using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Acceso_de_Datos;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Capa_Logica_Del_Negocio
{
    public class Clientee
    {
        Conexion_de_datos CD = new Conexion_de_datos();
      
        public int Id_Cliente { get; set; }

        public string Cedula { get; set; }
        public string Apellidos { get; set; }

        public string Nombres { get; set; }
        public string Sexo { get; set; }
        public string Ciudad { get; set; }

        public string Barrio { get; set; }
        public string Telefono { get; set; }

        public DataTable Listar_Clientes()
        {
            return CD.Listado("ListarClientes", null);
        }


        public void RegistrarCliente()
        {

            List<Parametros> lst = new List<Parametros>();

            try
            {
                lst.Add(new Parametros("@Cedula", Cedula));
                lst.Add(new Parametros("@Apellidos", Apellidos));
                lst.Add(new Parametros("@Nombres", Nombres));
                lst.Add(new Parametros("@Sexo", Sexo));
                lst.Add(new Parametros("@Ciudad", Ciudad));
                lst.Add(new Parametros("@Barrio", Barrio));
                lst.Add(new Parametros("@Telefono", Telefono));
                CD.EjecutarProcedimientosalmacenados("RegistrarClientes", ref lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AtualizarCliente()
        {

            List<Parametros> lst = new List<Parametros>();

            try
            {
                lst.Add(new Parametros("@Id_Clien", Id_Cliente));
                lst.Add(new Parametros("@Cedula", Cedula));
                lst.Add(new Parametros("@Apellidos", Apellidos));
                lst.Add(new Parametros("@Nombres", Nombres));
                lst.Add(new Parametros("@Sexo", Sexo));
                lst.Add(new Parametros("@Ciudad", Ciudad));
                lst.Add(new Parametros("@Barrio", Barrio));
                lst.Add(new Parametros("@Telefono", Telefono));
                CD.EjecutarProcedimientosalmacenados("ActualizarCliente", ref lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarCliente()
        {

            List<Parametros> lst = new List<Parametros>();

            try
            {
                lst.Add(new Parametros("@Id_Clien", Id_Cliente));
                CD.EjecutarProcedimientosalmacenados("EliminarCliente", ref lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
