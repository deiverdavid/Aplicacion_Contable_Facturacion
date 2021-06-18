using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaDeNegocios
{
   public class clsRolEmpleado
    {
        public int C_IdRolEmpleado {set;get;}
        public string C_Descripcion { set; get; }

        Acceso_datos acceso_Datos = new Acceso_datos();


        public string ActualizaRoles()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdRolEmpleado", 0));
                lst.Add(new Cls_parametros("@StrDescripcion", C_Descripcion));
               
                mensaje = acceso_Datos.Ejecutar_procedimiento("actualizar_Roles", lst);



            }
            catch (Exception ex)
            {

                mensaje = "Falló la conexión en roles" + ex;
            }

            return mensaje;
        }

        public string EliminaRoles()
        {
            string mensaje = "";
            try
            {
                string sentencia = $"Exec Eliminar_Rol {C_IdRolEmpleado}";
                mensaje = acceso_Datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {

                mensaje = "Falló borrado en roles" + ex;
            }
            return mensaje;
        }

        

       
        public DataTable ConsultaRoles()
        {
            string sentencia;
            try
            {
                sentencia = "select IdRolEmpleado,StrDescripcion from TBLROLES";
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

        public DataTable ConsultaRoles(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from tblroles where StrDescripcion like'{filtro}%'";
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
