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
    public partial class FrmCategorias : Form
    {

        clsCategoriaProducto categoriaProducto = new clsCategoriaProducto();

        

        public FrmCategorias()
        {
            InitializeComponent();
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

            txtcodigocategoria.Text = "";
            txtnombrecategoria.Text = "";


        }


        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            dgvCategoriaProd.DataSource = categoriaProducto.ConsultaCategoriaProducto();
        }

        private void dgvCategoriaProd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posActual = 0;
            posActual = dgvCategoriaProd.CurrentRow.Index;
            txtcodigocategoria.Text = dgvCategoriaProd[0, posActual].Value.ToString();
            txtnombrecategoria.Text = dgvCategoriaProd[1, posActual].Value.ToString();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            categoriaProducto.C_IdCategoria = Int16.Parse("0");
            categoriaProducto.C_Descripcion = txtnombrecategoria.Text;
            categoriaProducto.C_StrModifica = "Admin";

            mensaje = categoriaProducto.ActualizaCategoriaProducto();
            MessageBox.Show(mensaje);
            dgvCategoriaProd.DataSource = categoriaProducto.ConsultaCategoriaProducto();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            DialogResult Rta;
            Rta = MessageBox.Show("Desea borrar el registro actual ?", "MENSAJE DE ADVERTENCIA",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                categoriaProducto.C_IdCategoria = Int16.Parse(txtcodigocategoria.Text);
                mensaje = categoriaProducto.EliminaCategoria();
                MessageBox.Show(mensaje);
                dgvCategoriaProd.DataSource = categoriaProducto.ConsultaCategoriaProducto();
                Nuevo();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                dgvCategoriaProd.DataSource = categoriaProducto.ConsultaCategoriaProducto(txtBusca.Text);
            }
            else
            {
                dgvCategoriaProd.DataSource = categoriaProducto.ConsultaCategoriaProducto();
            }
            txtBusca.Text = "";
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnbuscar.PerformClick();
            }
        }
    }
}
