using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaDeNegocios
{
    public class clsProducto
    {
        public int C_IdProducto{set;get;}
        public string C_Nombre {set;get;}
        public string C_Codigo {set;get;}
        public float C_PrecioCompra {set;get;}
        public float C_PrecioVenta {set;get;}
        public int C_IdCategoria{set;get;}
        public string C_Detalle {set;get;}
        public string C_Foto{set;get;}
        public int C_NumStock {set;get;}
        public DateTime C_FechaModifica {set;get;}
        public string C_UsuarioModifica { set; get; }


        Acceso_datos accesoDatos = new Acceso_datos();

        public string ActualizaProducto()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();
                lst.Add(new Cls_parametros("@IdProducto", 0));
                lst.Add(new Cls_parametros("@StrNombre", C_Nombre));
                lst.Add(new Cls_parametros("@StrCodigo", C_Codigo));
                lst.Add(new Cls_parametros("@NumPrecioCompra", C_PrecioCompra));
                lst.Add(new Cls_parametros("@NumPrecioVenta", C_PrecioVenta));
                lst.Add(new Cls_parametros("@IdCategoria", C_IdCategoria));
                lst.Add(new Cls_parametros("@StrDetalle", C_Detalle));
                lst.Add(new Cls_parametros("@strFoto", C_Foto));
                lst.Add(new Cls_parametros("@NumStock", C_NumStock));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", C_UsuarioModifica));

                mensaje =accesoDatos.Ejecutar_procedimiento("actualizar_Producto", lst);



            }
            catch (Exception ex)
            {

                mensaje = "Falló la conexión en productos" + ex;
            }

            return mensaje;
        }

        public string EliminaProducto()
        {
            string mensaje = "";
            try
            {
                string sentencia = $"Exec Eliminar_Producto {C_IdProducto}";
                mensaje = accesoDatos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {

                mensaje = "Falló borrado en productos" + ex;
            }
            return mensaje;
        }


        public DataTable ConsultaProducto()
        {
            string sentencia;

            try
            {
                sentencia = "Select * from tblproducto";
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

        public DataTable ConsultaProducto(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from tblproducto where StrNombre like'{filtro}%'";
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
