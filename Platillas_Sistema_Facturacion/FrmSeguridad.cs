using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaDeNegocios;

namespace Platillas_Sistema_Facturacion
{
    public partial class FrmSeguridad : Form
    {
        // Instanciamos la clase de clsAdminSeguridad de la capa logica logica de negocios

        clsAdminSeguridad CapaNegocios_adminseg = new clsAdminSeguridad();
        
        
        public FrmSeguridad()
        {
            InitializeComponent();
        }

        private void llenar_combo_Empleados()
        {
            DataTable dt = new DataTable();
            // llenamos el combo con los clientes empleados
            dt = CapaNegocios_adminseg.ConsultaEmpleados();
            cboEmpleado.DataSource = dt;
            cboEmpleado.DisplayMember = "strNombre";
            cboEmpleado.ValueMember = "IdEmpleado";
        }
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtusuario.Text == string.Empty)
            {
                MensajeError.SetError(txtusuario, "debe ingresar un valor de Usuario");
                txtusuario.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtusuario, ""); }
            if (txtclave.Text == "")
            {
                MensajeError.SetError(txtclave, "Debe ingresar un valor de cédula");
                txtclave.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtclave, ""); }
            return errorCampos;
        }

        //metodo para validar si los valores son numericos
        private bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Función que permite guardar los datos de ingreso a un usuario
        public void Guardar()
        {
            string mensaje = "";
            if (validar())
            {
                try
                {
                    // actualizamos valores de seguridad
                    CapaNegocios_adminseg.IdEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
                    CapaNegocios_adminseg.StrUsuario = txtusuario.Text;
                    CapaNegocios_adminseg.StrClave = txtclave.Text;
                    CapaNegocios_adminseg.C_UsuarioModifica = txtusuario.Text;
                    mensaje = CapaNegocios_adminseg.ActualizarSeguridad();
                    MessageBox.Show(mensaje);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló Actualización: " + ex);
                }
            }
        }

        // Función que permite eliminar los datos de ingreso de un usuario
        public void Eliminar()
        {
            string mensaje = "";
            //Acceso_datos Acceso = new Acceso_datos();
            //string sentencia = $"Exec Eliminar_Seguridad { Convert.ToInt32(cboEmpleado.SelectedValue)}";
            // MessageBox.Show(Acceso.EjecutarComando(sentencia));
            if (validar())
            {
                try
                {
                    CapaNegocios_adminseg.IdEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);

                    mensaje = CapaNegocios_adminseg.EliminaUsuarioSeg();
                    MessageBox.Show(mensaje);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Falló borrado en usuario: "+ ex);
                }
                
            }
            
          
            txtusuario.Text = "";
            txtclave.Text = "";

            
        }

        // función que permite consultar los datos de ingreso de un usuario
        public void Consultar()
        {
            DataTable dt = new DataTable();
            dt = CapaNegocios_adminseg.ConsultaSeguridad(cboEmpleado.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                txtusuario.Text = dt.Rows[0]["StrUsuario"].ToString();
                txtclave.Text = dt.Rows[0]["StrClave"].ToString();
            }
            else
            {
                MessageBox.Show("El usuario no dispone de datos de ingreso");
                txtusuario.Text = "";
                txtclave.Text = "";
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            //verificamos si desea cerrar la ventana
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edición ?", "MENSAJE DE ADVERTENCIA",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void FrmSeguridad_Load(object sender, EventArgs e)
        {
            llenar_combo_Empleados();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
