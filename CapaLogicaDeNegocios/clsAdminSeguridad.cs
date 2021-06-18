using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Windows;
using System.ComponentModel;

namespace CapaLogicaDeNegocios
{
    public class clsAdminSeguridad
    {
        // Definimos los atributos

        public int IdSeguridad { set; get; }
        public int IdEmpleado { set; get; }
        public string StrUsuario { set; get; }
        public string StrClave { set; get; }
        public string C_UsuarioModifica { set; get; }
      

        Acceso_datos Acceso = new Acceso_datos(); // Creamos el objeto


        // Método empleado que permite realizar la consulta a la base de datos
        public DataTable ConsultaEmpleados()
        {
            string sentencia;
            try
            {
                sentencia = "select IdEmpleado,StrNombre from TBLEMPLEADO";
                DataTable dt = new DataTable();
                Acceso_datos Acceso = new Acceso_datos();// Creamos un objeto con la clase Acceso_datos
                dt = Acceso.EjecutarConsulta(sentencia);
                return dt;

            }
            catch (Exception)
            {

                return null;
            }
        }

        //  Método que permite consultar la informacion de un empleado en la tabla de seguridad.
        public DataTable ConsultaSeguridad(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from TBLSEGURIDAD WHERE IdEmpleado={filtro}";
                DataTable dt = new DataTable();
                Acceso_datos Acceso = new Acceso_datos(); // Creamos un objeto con la clase Acceso_datos
                dt = Acceso.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }

        // Permite guardar los cambios realizados sobre la informacion de usuario o clave
        // Permite ingresar un registro nuevo para el empleado que no tiene usuario o clave

        public string ActualizarSeguridad()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdEmpleado", IdEmpleado));
                lst.Add(new Cls_parametros("@StrUsuario", StrUsuario));
                lst.Add(new Cls_parametros("@StrClave", StrClave));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_UsuarioModifica));

                mensaje = Acceso.Ejecutar_procedimiento("actualizar_Seguridad", lst);

                mensaje = "Los datos fueron actualizados";

            }
            catch (Exception ex)
            {

                mensaje = "Falló la actualización en seguridad" + ex;
            }
            return mensaje;
        }
        public string EliminaUsuarioSeg()
        {
            string mensaje = "";
            try
            {
                string sentencia = $"Exec Eliminar_Seguridad {IdEmpleado}";
                mensaje = Acceso.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {

                mensaje = "Falló borrado en usuario" + ex;
            }
            return mensaje;
        }

    }
}
