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
    public partial class FrmProductos : Form
    {

        clsProducto C_producto = new clsProducto();
        clsCategoriaProducto clsCategoria = new clsCategoriaProducto();

        public FrmProductos()
        {
            InitializeComponent();
            txtIdProducto.Text = "0";
        }

        private void llenar_combo_categoria()
        {
            DataTable dt = new DataTable();
            // llenamos el combo con los clientes empleados
            dt = clsCategoria.ConsultaCategoriaProducto();
            cboCategoria.DataSource = dt;
            cboCategoria.DisplayMember = "StrDescripcion";
            cboCategoria.ValueMember = "IdCategoria";
        }

        // realizamos validaciones
        private Boolean Validados()
        {
            Boolean errorCampos = true;
            if (txtNombreProducto.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreProducto, "debe ingresar el nombre del empleado");
                txtNombreProducto.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombreProducto, ""); }
            if (txtcompra.Text == "")
            {
                MensajeError.SetError(txtcompra, "debe ingresar el documento");
                txtcompra.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtcompra, ""); }
            if (!IsNumeric(txtcompra.Text))
            {
                MensajeError.SetError(txtcompra, "El Documento debe ser numerico");
                txtcompra.Focus();
                return false;
            }
            MensajeError.SetError(txtcompra, "");
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

            txtIdProducto.Text = "";
            txtNombreProducto.Text = "";
            txtCodigo.Text = "";
            txtcompra.Text = "";
            txtprecioVenta.Text = "";
            txtdetalles.Text = "";
            txtrutaimagen.Text = "";
            txtNumStock.Text = "";
           

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void dgvproductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posActual = 0;
            posActual = dgvproductos.CurrentRow.Index;
            txtIdProducto.Text = dgvproductos[0, posActual].Value.ToString();
            txtNombreProducto.Text = dgvproductos[1, posActual].Value.ToString();
            txtCodigo.Text = dgvproductos[2, posActual].Value.ToString();
            txtcompra.Text = dgvproductos[3, posActual].Value.ToString();
            txtprecioVenta.Text = dgvproductos[4, posActual].Value.ToString();
            cboCategoria.SelectedValue = Convert.ToInt16(dgvproductos[5, posActual].Value.ToString());
            txtdetalles.Text = dgvproductos[6, posActual].Value.ToString();
            txtrutaimagen.Text = dgvproductos[7, posActual].Value.ToString();
            txtNumStock.Text = dgvproductos[8, posActual].Value.ToString();
            
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            if (Validados())
            {
                C_producto.C_IdProducto = Int16.Parse("0");
                C_producto.C_Nombre = txtNombreProducto.Text;
                C_producto.C_Codigo = txtCodigo.Text;
                C_producto.C_PrecioCompra = float.Parse(txtcompra.Text);
                C_producto.C_PrecioVenta = float.Parse(txtprecioVenta.Text);
                C_producto.C_IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
                C_producto.C_Detalle= txtdetalles.Text;
                C_producto.C_Foto = txtrutaimagen.Text;
                C_producto.C_NumStock = int.Parse(txtNumStock.Text);
                C_producto.C_UsuarioModifica = "admin";

                mensaje = C_producto.ActualizaProducto();
                MessageBox.Show(mensaje);
                dgvproductos.DataSource = C_producto.ConsultaProducto();
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
                C_producto.C_IdProducto = Int16.Parse(txtIdProducto.Text);
                mensaje = C_producto.EliminaProducto();
                MessageBox.Show(mensaje);
                dgvproductos.DataSource = C_producto.ConsultaProducto();
                Nuevo();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvproductos.DataSource = C_producto.ConsultaProducto(txtBuscar.Text);
            }
            else
            {
                dgvproductos.DataSource = C_producto.ConsultaProducto();
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

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            dgvproductos.DataSource = C_producto.ConsultaProducto();
            llenar_combo_categoria();
        }
    }
}
