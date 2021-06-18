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
{/// <summary>
/// FUNCIONALIDAD:Por medio de este formulario realizamos el acceso a la base de datos con el fin de verficar si el uduario y la clave estan registradas en la tabla TBLSEGURIDAD.
/// </summary>
    public partial class Frmlogin : Form
    {
        // Instanciamos la clase de administracio de clientes de la capa logica de negocios
        Validar_usuario Clase_validaUsuario = new Validar_usuario();

        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != "" && txtcontraseña.Text != string.Empty)// Verifico que los campos de usuario y clave no esten vacios

            {
                Clase_validaUsuario.C_StrClave = txtcontraseña.Text;
                Clase_validaUsuario.C_StrUsuario = txtusuario.Text;
                Clase_validaUsuario.ValidarUsuario();
                if (Clase_validaUsuario.C_IdEmpleado != 0)
                {
                    MessageBox.Show("Bienvenido: Validación aceptada");
                    FrmPrincipal frmppal = new FrmPrincipal(); // Creamos el objeto del formulario FrmPrincipal
                    this.Hide(); // Ocultamos el formulario login
                    frmppal.Show();  // Mostramos el formulario principal
                }
                else
                {
                    MessageBox.Show("Usuario y clave no encontrados");
                    txtusuario.Text = "";
                    txtusuario.Focus();
                    txtcontraseña.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un usuario y una clave");
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btncontinuar.PerformClick();
            }
        }
    }
}
