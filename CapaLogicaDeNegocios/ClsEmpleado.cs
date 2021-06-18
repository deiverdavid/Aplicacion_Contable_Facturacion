using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaDeNegocios
{
   public class ClsEmpleado
    {
        public int C_IdEmpleado { get; set; }
        public string C_Nombre{get;set;}        
        public Int64 C_Documento { get; set; }
        public string C_Direccion{get;set;}
        public string C_Telefono{get;set;}
        public string C_Email{get;set;}
        public int IdRolEmpleado{get;set;}
        public DateTime C_DtmIngreso{get;set;}
        public DateTime C_DtmRetiro{get;set;}
        public string C_DatosAdicionales{get;set;}
        public string C_UsuarioModifica{get;set;}
        public int C_IdCboEmpleado { get; set; }

        Acceso_datos Acceso = new Acceso_datos();


        public string ActualizaEmpleado()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdEmpleado", 0));
                lst.Add(new Cls_parametros("@strNombre", C_Nombre));
                lst.Add(new Cls_parametros("@NumDocumento", C_Documento));
                lst.Add(new Cls_parametros("@StrDireccion", C_Direccion));
                lst.Add(new Cls_parametros("@StrTelefono", C_Telefono));
                lst.Add(new Cls_parametros("@StrEmail", C_Email));
                lst.Add(new Cls_parametros("@IdRolEmpleado", C_IdCboEmpleado));
                lst.Add(new Cls_parametros("@DtmIngreso", C_DtmIngreso));
                lst.Add(new Cls_parametros("@DtmRetiro", C_DtmRetiro));
                lst.Add(new Cls_parametros("@strDatosAdicionales", C_DatosAdicionales));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_UsuarioModifica));

                mensaje = Acceso.Ejecutar_procedimiento("actualizar_Empleado", lst);



            }
            catch (Exception ex)
            {

                mensaje = "Falló la conexión en empleados" + ex;
            }

            return mensaje;
        }

        public string EliminaEmpleado()
        {
            string mensaje = "";
            try
            {
                string sentencia = $"Exec Eliminar_Empleado {C_IdEmpleado}";
                mensaje = Acceso.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {

                mensaje = "Falló borrado en empleados" + ex;
            }
            return mensaje;
        }


        public DataTable ConsultaEmpleado()
        {
            string sentencia;

            try
            {
                sentencia = "Select * from tblempleado";
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
        public DataTable ConsultaEmpleado(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from tblempleado where strNombre like'{filtro}%'";
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
