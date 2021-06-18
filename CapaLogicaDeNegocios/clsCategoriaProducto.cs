using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaDeNegocios
{
    public class clsCategoriaProducto
    {
        public int C_IdCategoria{set;get;}
        public string C_Descripcion {set;get;}
        public string C_StrModifica { set; get; }

        Acceso_datos Acceso = new Acceso_datos();

        public string ActualizaCategoriaProducto()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdCategoria", 0));
                lst.Add(new Cls_parametros("@StrDescripcion", C_Descripcion));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_StrModifica));
              

                mensaje = Acceso.Ejecutar_procedimiento("actualizar_CategoriaProd", lst);



            }
            catch (Exception ex)
            {

                mensaje = "Falló la conexión en categoria Productos" + ex;
            }

            return mensaje;
        }

        public string EliminaCategoria()
        {
            string mensaje = "";
            try
            {
                string sentencia = $"Exec Eliminar_CategoriaProd {C_IdCategoria}";
                mensaje = Acceso.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {

                mensaje = "Falló borrado en categoria productos" + ex;
            }
            return mensaje;
        }

        public DataTable ConsultaCategoriaProducto()
        {
            string sentencia;

            try
            {
                sentencia = "Select * from tblcategoria_prod";
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

        public DataTable ConsultaCategoriaProducto(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from tblcategoria_prod where StrDescripcion like'{filtro}%'";
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
