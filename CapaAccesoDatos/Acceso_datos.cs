using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace CapaAccesoDatos
{
    public class Cls_parametros
    {
        // Definimos parametros
        public string Nombre { get; set; }
        public object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection Direccionparametro { get; set; }

        // Constructor parametros de entrada

        public Cls_parametros(string Objnombre, Object ObjValor)
        {
            Nombre = Objnombre;
            Valor = ObjValor;
            Direccionparametro = ParameterDirection.Input;
        }

        // Constructor parametros de salida
        public Cls_parametros(string Objnombre, SqlDbType ObjTipoDato, Int32 ObjTamaño)
        {
            Nombre = Objnombre;
            TipoDato = ObjTipoDato;
            Tamaño = ObjTamaño;
            Direccionparametro = ParameterDirection.Output;

        }

    }

    public class Acceso_datos
    {
        SqlConnection conexion;// Se define la variable para la conexión de tipo SqlConnection
        SqlCommand cmd;// Se define la variable para realizar comandos en la BD
        SqlDataReader LectorDatos = null;
        SqlDataAdapter da;
        DataTable dt;

        public string AbrirBd()// Método para abrir la base de datos
        {
            string resultado = "";

            try    // Permite capturar errores en caso de que se presente
            {

                // Creamos un objeto de tipo conexion a la base de datos y se pasa como parametro la cadena de conexión
                conexion = new SqlConnection("Data Source=localhost\\DEIVERDAVID;Initial Catalog=[DBFACTURAS_2];Integrated Security=True");
                conexion.Open(); // Invocamos método para abrir la base de datos
                                 // MessageBox.Show("La conexion fue satisfactoria"); // Mostramos mensaje de conexion exitosa


            }
            catch (Exception ex)
            {

                resultado = "fallo abrir conexión " + ex;
            }

            return resultado;
        }

        public string CerrarBd()
        {
            string resultado = "";

            try
            {
                conexion.Close(); // Se llama el metodo que cierra la base de datos
            }
            catch (Exception ex)// Si hay error presenta el siguiente mensaje
            {

                resultado = "Fallo la conexión " + ex;
            }
            return resultado;
        }

        // Método utilizado para ejecutar un procedimiento almacenado en la base de datos

        public string Ejecutar_procedimiento(string procedimiento, List<Cls_parametros> lst)
        {
            string salida = "";
            try
            {
                int retornado;

                AbrirBd();
                SqlCommand Comando = new SqlCommand(procedimiento, conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccionparametro == ParameterDirection.Input)
                        {
                            Comando.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }
                        if (lst[i].Direccionparametro == ParameterDirection.Output)
                        {
                            Comando.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                }
                retornado = Comando.ExecuteNonQuery();
                CerrarBd();
                if (retornado > 0)
                {
                    salida = "Los datos fueron actualizados";
                }
                else
                {
                    salida = "Los datos no fueron Actualizados";
                }
            }
            catch (Exception ex)
            {

                salida = "Falló Operación" + ex;
            }

            return salida;
        }

        public string EjecutarComando(string sentencia)
        {
            string salida = "";
            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                // Cuando se ejecuta retorna un valor numerico que indica Nro de registros afectados

                retornado = cmd.ExecuteNonQuery();
                CerrarBd();
                if (retornado > 0)
                {
                    salida = "Los datos fueron Actulizados";
                }
                else
                {
                    salida = "Los datos no fueron Actulizados";
                }
            }
            catch (Exception ex)
            {

                salida = "Falló Operación: " + ex;
            }
            return salida;

        }

        // Método que permite realizar una consulta en una o varias tablas
        // y retorna un conjunto de registros en un DataTable

        public DataTable EjecutarConsulta(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd,conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarBd();
                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

    }
}
