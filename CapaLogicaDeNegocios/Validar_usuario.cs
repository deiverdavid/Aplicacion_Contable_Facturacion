using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaDeNegocios
{
    public class Validar_usuario
    {
        // Definimos los atributos de la clase

        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        public Int32 C_IdEmpleado { get; set; }

        public void ValidarUsuario()
        {
            try
            {

                string sentencia = $"SELECT IdEmpleado,StrUsuario FROM TBLSEGURIDAD WHERE StrUsuario='{C_StrUsuario}' AND Strclave='{C_StrClave}'";

                DataTable dt = new DataTable();
                Acceso_datos Acceso = new Acceso_datos(); // Creamos un objeto de la clase Acceso_datos
                dt = Acceso.EjecutarConsulta(sentencia);
                foreach (DataRow row in dt.Rows)
                    C_IdEmpleado = int.Parse(row[0].ToString());
                
            }
            catch (Exception ex)
            {

                throw (ex);
            }
        }





    }
}
