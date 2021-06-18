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
    public partial class FrmEmpleados : Form
    {

        ClsEmpleado ClsEmpleado = new ClsEmpleado();
        clsRolEmpleado clsRolEmpleado = new clsRolEmpleado();
        

        public FrmEmpleados()
        {
            InitializeComponent();
            IdEmpleado.Text = "0";
            
        }

        private void llenar_combo_Roles()
        {
            DataTable dt = new DataTable();
            // llenamos el combo con los clientes empleados
            dt = clsRolEmpleado.ConsultaRoles();
            cboRolEmpleado.DataSource = dt;
            cboRolEmpleado.DisplayMember = "StrDescripcion";
            cboRolEmpleado.ValueMember = "IdRolEmpleado";
        }

        // realizamos validaciones
        private Boolean Validados()
        {
            Boolean errorCampos = true;
            if (txtnombreEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtnombreEmpleado, "debe ingresar el nombre del empleado");
                txtnombreEmpleado.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtnombreEmpleado, ""); }
            if (txtdocumento.Text == "")
            {
                MensajeError.SetError(txtdocumento, "debe ingresar el documento");
                txtdocumento.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtdocumento, ""); }
            if (!IsNumeric(txtdocumento.Text))
            {
                MensajeError.SetError(txtdocumento, "El Documento debe ser numerico");
                txtdocumento.Focus();
                return false;
            }
            MensajeError.SetError(txtdocumento, "");
            return errorCampos;
        }


        // Método para validar si los valores son numericos
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

        public void Nuevo()
        {
            // limpiamos todos los campos
            // foreach (Control c in this.CLIENTE.Controls)
            // {
            //     if (c is TextBox)
            //     {
            //         c.Text = "";
            //         this.txtnombre.Focus(); //Enfoco en el primer TextBox
            //     }
            // }
            //IdCliente.Text = "0";

            IdEmpleado.Text = "";
            txtnombreEmpleado.Text = "";
            txtdocumento.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtemail.Text = "";
            txtdatosadicionales.Text = "";

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            dgvempleados.DataSource = ClsEmpleado.ConsultaEmpleado();
            llenar_combo_Roles();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void dgvempleados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posActual = 0;
            posActual = dgvempleados.CurrentRow.Index;
            IdEmpleado.Text = dgvempleados[0, posActual].Value.ToString();
            txtnombreEmpleado.Text = dgvempleados[1, posActual].Value.ToString();
            txtdocumento.Text = dgvempleados[2, posActual].Value.ToString();
            txtdireccion.Text = dgvempleados[3, posActual].Value.ToString();
            txttelefono.Text = dgvempleados[4, posActual].Value.ToString();
            txtemail.Text = dgvempleados[5, posActual].Value.ToString();
            cboRolEmpleado.SelectedValue = Convert.ToInt16(dgvempleados[6, posActual].Value.ToString());
            dtpIngreso.Value = Convert.ToDateTime(dgvempleados[7, posActual].Value.ToString());
            if (dgvempleados[8, posActual].Value.ToString() != "")
            {
                dtpRetiro.Value = Convert.ToDateTime(dgvempleados[8, posActual].Value.ToString());
            }
            else
            {
                dtpRetiro.Value = Convert.ToDateTime("01/01/1900");
            }
            txtdatosadicionales.Text = dgvempleados[9, posActual].Value.ToString();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            if (Validados())
            {
                ClsEmpleado.C_IdEmpleado = Int16.Parse("0");
                ClsEmpleado.C_Nombre = txtnombreEmpleado.Text;
                ClsEmpleado.C_Documento = Int64.Parse(txtdocumento.Text);
                ClsEmpleado.C_Direccion = txtdireccion.Text;
                ClsEmpleado.C_Telefono = txttelefono.Text;
                ClsEmpleado.C_Email = txtemail.Text;
                ClsEmpleado.C_IdCboEmpleado = Convert.ToInt32(cboRolEmpleado.SelectedValue);
                ClsEmpleado.C_DtmIngreso = Convert.ToDateTime( dtpIngreso.Text);
                ClsEmpleado.C_DtmRetiro = Convert.ToDateTime( dtpRetiro.Text);
                ClsEmpleado.C_DatosAdicionales = txtdatosadicionales.Text;
                ClsEmpleado.C_UsuarioModifica = "admin";

                mensaje = ClsEmpleado.ActualizaEmpleado();
                MessageBox.Show(mensaje);
                dgvempleados.DataSource = ClsEmpleado.ConsultaEmpleado();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            DialogResult Rta;
            Rta = MessageBox.Show("Desea borrar el registro actual ?", "MENSAJE DE ADVERTENCIA",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                ClsEmpleado.C_IdEmpleado = Int16.Parse(IdEmpleado.Text);
                mensaje = ClsEmpleado.EliminaEmpleado();
                MessageBox.Show(mensaje);
                dgvempleados.DataSource = ClsEmpleado.ConsultaEmpleado();
                Nuevo();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvempleados.DataSource = ClsEmpleado.ConsultaEmpleado(txtBuscar.Text);
            }
            else
            {
                dgvempleados.DataSource = ClsEmpleado.ConsultaEmpleado();
            }
            txtBuscar.Text = "";
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnbuscar.PerformClick();
            }
        }
    }
    
}
