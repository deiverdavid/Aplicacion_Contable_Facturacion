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
    public partial class FrmClientes : Form
    {
        // Instanciamos la clase de administracion de clientes de la capa logica de negocios
        clsClientes Capa_clientes = new clsClientes();



        public FrmClientes()
        {
            InitializeComponent();
            IdCliente.Text = "0";
        }



        // realizamos validaciones
        private Boolean Validados()
        {
            Boolean errorCampos = true;
            if (txtnombre.Text == string.Empty)
            {
                MensajeError.SetError(txtnombre, "debe ingresar el nombre del empleado");
                txtnombre.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtnombre, ""); }
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

            IdCliente.Text = "";
            txtnombre.Text = "";
            txtdocumento.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtemail.Text = "";

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // Llenamos el grid con los clientes registrados

            dgvClientes.DataSource = Capa_clientes.ConsultaCliente();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posActual = 0;
            posActual = dgvClientes.CurrentRow.Index;
            IdCliente.Text = dgvClientes[0, posActual].Value.ToString();
            txtnombre.Text = dgvClientes[1, posActual].Value.ToString();
            txtdocumento.Text = dgvClientes[2, posActual].Value.ToString();
            txtdireccion.Text = dgvClientes[3, posActual].Value.ToString();
            txttelefono.Text = dgvClientes[4, posActual].Value.ToString();
            txtemail.Text = dgvClientes[5, posActual].Value.ToString();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            if (Validados())
            {
                Capa_clientes.C_IdCliente = Int16.Parse("0");
                Capa_clientes.C_Nombre = txtnombre.Text;
                Capa_clientes.C_Documento = Int64.Parse(txtdocumento.Text);
                Capa_clientes.C_Direccion = txtdireccion.Text;
                Capa_clientes.C_Telefono = txttelefono.Text;
                Capa_clientes.C_email = txtemail.Text;
                Capa_clientes.C_UsuarioModifica = "Deiver";
                mensaje = Capa_clientes.ActualizaCliente();
                MessageBox.Show(mensaje);
                dgvClientes.DataSource = Capa_clientes.ConsultaCliente();
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
                Capa_clientes.C_IdCliente = Int16.Parse(IdCliente.Text);
                mensaje = Capa_clientes.EliminaCliente();
                MessageBox.Show(mensaje);
                dgvClientes.DataSource = Capa_clientes.ConsultaCliente();
                Nuevo();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvClientes.DataSource = Capa_clientes.ConsultaCliente(txtBuscar.Text);
            }
            else
            {
                dgvClientes.DataSource = Capa_clientes.ConsultaCliente();
            }
            txtBuscar.Text = "";
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                btnbuscar.PerformClick();
            }
        }
    }
}
