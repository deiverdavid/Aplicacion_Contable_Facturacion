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
    public partial class FrmRoles : Form
    {

        clsRolEmpleado clsRol = new clsRolEmpleado();
        public FrmRoles()
        {
            InitializeComponent();
        }

        // realizamos validaciones
        //private Boolean Validados()
        //{
        //    Boolean errorCampos = true;
        //    if (txtnombrerol.Text == string.Empty)
        //    {
        //        MensajeError.SetError(txtnombrerol, "debe ingresar el nombre del empleado");
        //        txtnombrerol.Focus();
        //        errorCampos = false;
        //    }
           
        //    return errorCampos;
        //}

        //// Método para validar si los valores son numericos
        //private bool IsNumeric(string num)
        //{
        //    try
        //    {
        //        double x = Convert.ToDouble(num);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

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

            txtnombrerol.Text = "";
            txtdescripcionrol.Text = "";
            

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            dgvrol.DataSource = clsRol.ConsultaRoles();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void dgvrol_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posActual = 0;
            posActual = dgvrol.CurrentRow.Index;
            txtnombrerol.Text = dgvrol[0, posActual].Value.ToString();
            txtdescripcionrol.Text = dgvrol[1, posActual].Value.ToString();
            
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
         
                clsRol.C_IdRolEmpleado = Int16.Parse("0");
                clsRol.C_Descripcion= txtdescripcionrol.Text;
                
                mensaje = clsRol.ActualizaRoles();
                MessageBox.Show(mensaje);
                dgvrol.DataSource = clsRol.ConsultaRoles();
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            DialogResult Rta;
            Rta = MessageBox.Show("Desea borrar el registro actual ?", "MENSAJE DE ADVERTENCIA",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                clsRol.C_IdRolEmpleado = Int16.Parse(txtnombrerol.Text);
                mensaje = clsRol.EliminaRoles();
                MessageBox.Show(mensaje);
                dgvrol.DataSource = clsRol.ConsultaRoles();
                Nuevo();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvrol.DataSource = clsRol.ConsultaRoles(txtBuscar.Text);
            }
            else
            {
                dgvrol.DataSource = clsRol.ConsultaRoles();
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
