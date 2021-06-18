using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaDeNegocios
{
    public class clsClientes
    {// Definimos los atributos de la clase 

        public int C_IdCliente { get; set; }
        public string C_Nombre { get; set; }
        public Int64 C_Documento { get; set; }
        public string C_Direccion { get; set; }
        public string C_Telefono { get; set; }
        public string C_email { get; set; }
        public string C_UsuarioModifica { get; set; }

        Acceso_datos Acceso = new Acceso_datos();

        public string ActualizaCliente()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdCliente", 0));
                lst.Add(new Cls_parametros("@StrNombre", C_Nombre));
                lst.Add(new Cls_parametros("@NumDocumento", C_Documento));
                lst.Add(new Cls_parametros("@StrDireccion", C_Direccion));
                lst.Add(new Cls_parametros("@StrTelefono", C_Telefono));
                lst.Add(new Cls_parametros("@StrEmail", C_email));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", C_UsuarioModifica));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));

                mensaje = Acceso.Ejecutar_procedimiento("actualizar_Cliente", lst);



            }
            catch (Exception ex)
            {

                mensaje = "Falló la conexión en clientes" + ex;
            }

            return mensaje;
        }

        public string EliminaCliente()
        {
            string mensaje = "";
            try
            {
                string sentencia = $"Exec Eliminar_Cliente {C_IdCliente}";
                mensaje = Acceso.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {

                mensaje = "Falló borrado en clientes" + ex;
            }
            return mensaje;
        }

        public DataTable ConsultaCliente()
        {
            string sentencia;

            try
            {
                sentencia = "Select * from tblclientes";
                DataTable dt = new DataTable(); ;
                Acceso_datos Acceso = new Acceso_datos();   // Creamos un objeto con la clase Acceso_datos
                dt = Acceso.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public DataTable ConsultaCliente(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from tblclientes where Strnombre like'{filtro}%'";
                DataTable dt = new DataTable();
                Acceso_datos Acceso = new Acceso_datos();  // Creamos un objeto con la clase Acceso_datos
                dt = Acceso.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
