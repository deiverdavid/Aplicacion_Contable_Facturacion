using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Platillas_Sistema_Facturacion
{
    public partial class FrmPrincipal : MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            MaterialSkinManager material = MaterialSkinManager.Instance;
            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.LIGHT;
            material.ColorScheme = new ColorScheme(Primary.Green800,Primary.Green500,Primary.Blue300,Accent.Green700,TextShade.BLACK);

        }

        void AbrirFormulario(Form FormularioHijo)
        {
            if (this.pnlcontenedor.Controls.Count>0)
            {
                this.pnlcontenedor.Controls.RemoveAt(0);
            }

            FormularioHijo.BackColor = Color.White;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.TopLevel = false;
            FormularioHijo.Dock = DockStyle.Fill;
            this.pnlcontenedor.Controls.Add(FormularioHijo);
            FormularioHijo.Show();



        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();

            AbrirFormulario(frmClientes);
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();

            AbrirFormulario(frmProductos);
        }

        private void btncategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias frmCategorias = new FrmCategorias();

            AbrirFormulario(frmCategorias);

        }

        private void btnfacturas_Click(object sender, EventArgs e)
        {
            FrmFacturas frmFacturas = new FrmFacturas();

            AbrirFormulario(frmFacturas);
        }

        private void btninformes_Click(object sender, EventArgs e)
        {
            FrmInformes frmInformes = new FrmInformes();

            AbrirFormulario(frmInformes);
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados();

            AbrirFormulario(frmEmpleados);
        }

        private void btnroles_Click(object sender, EventArgs e)
        {
            FrmRoles frmRoles = new FrmRoles();

            AbrirFormulario(frmRoles);
        }

        private void btnseguridad_Click(object sender, EventArgs e)
        {
            FrmSeguridad frmSeguridad = new FrmSeguridad();

            AbrirFormulario(frmSeguridad);
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            FrmAyuda frmAyuda = new FrmAyuda();
            AbrirFormulario(frmAyuda);
        }

        private void btnaacercade_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            AbrirFormulario(frmAcercaDe);
        }
    }
}
