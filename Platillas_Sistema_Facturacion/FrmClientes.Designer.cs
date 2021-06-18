namespace Platillas_Sistema_Facturacion
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IdCliente = new System.Windows.Forms.TextBox();
            this.txtemail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txttelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtdireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtdocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnnuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnactualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btneliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlbusquedad = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnsalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.CLIENTE = new System.Windows.Forms.GroupBox();
            this.pnlbusquedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.CLIENTE.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdCliente
            // 
            this.IdCliente.Location = new System.Drawing.Point(6, 9);
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Size = new System.Drawing.Size(67, 22);
            this.IdCliente.TabIndex = 5;
            this.IdCliente.Visible = false;
            // 
            // txtemail
            // 
            this.txtemail.Depth = 0;
            this.txtemail.Hint = "Email";
            this.txtemail.Location = new System.Drawing.Point(79, 259);
            this.txtemail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.Size = new System.Drawing.Size(367, 28);
            this.txtemail.TabIndex = 4;
            this.txtemail.UseSystemPasswordChar = false;
            // 
            // txttelefono
            // 
            this.txttelefono.Depth = 0;
            this.txttelefono.Hint = "Teléfono";
            this.txttelefono.Location = new System.Drawing.Point(79, 205);
            this.txttelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PasswordChar = '\0';
            this.txttelefono.SelectedText = "";
            this.txttelefono.SelectionLength = 0;
            this.txttelefono.SelectionStart = 0;
            this.txttelefono.Size = new System.Drawing.Size(367, 28);
            this.txttelefono.TabIndex = 3;
            this.txttelefono.UseSystemPasswordChar = false;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Depth = 0;
            this.txtdireccion.Hint = "Dirección";
            this.txtdireccion.Location = new System.Drawing.Point(79, 145);
            this.txtdireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PasswordChar = '\0';
            this.txtdireccion.SelectedText = "";
            this.txtdireccion.SelectionLength = 0;
            this.txtdireccion.SelectionStart = 0;
            this.txtdireccion.Size = new System.Drawing.Size(367, 28);
            this.txtdireccion.TabIndex = 2;
            this.txtdireccion.UseSystemPasswordChar = false;
            // 
            // txtdocumento
            // 
            this.txtdocumento.Depth = 0;
            this.txtdocumento.Hint = "Documento";
            this.txtdocumento.Location = new System.Drawing.Point(79, 84);
            this.txtdocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.PasswordChar = '\0';
            this.txtdocumento.SelectedText = "";
            this.txtdocumento.SelectionLength = 0;
            this.txtdocumento.SelectionStart = 0;
            this.txtdocumento.Size = new System.Drawing.Size(367, 28);
            this.txtdocumento.TabIndex = 1;
            this.txtdocumento.UseSystemPasswordChar = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Depth = 0;
            this.txtnombre.Hint = "Nombre Cliente";
            this.txtnombre.Location = new System.Drawing.Point(79, 21);
            this.txtnombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PasswordChar = '\0';
            this.txtnombre.SelectedText = "";
            this.txtnombre.SelectionLength = 0;
            this.txtnombre.SelectionStart = 0;
            this.txtnombre.Size = new System.Drawing.Size(367, 28);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.UseSystemPasswordChar = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(283, 8);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(408, 29);
            this.lbltitulo.TabIndex = 2;
            this.lbltitulo.Text = "ADMINISTRACIÓN DE CLIENTES";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnnuevo.Depth = 0;
            this.btnnuevo.Location = new System.Drawing.Point(715, 120);
            this.btnnuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Primary = true;
            this.btnnuevo.Size = new System.Drawing.Size(225, 45);
            this.btnnuevo.TabIndex = 3;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnactualizar.Depth = 0;
            this.btnactualizar.Location = new System.Drawing.Point(715, 200);
            this.btnactualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Primary = true;
            this.btnactualizar.Size = new System.Drawing.Size(225, 45);
            this.btnactualizar.TabIndex = 4;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btneliminar.Depth = 0;
            this.btneliminar.Location = new System.Drawing.Point(715, 277);
            this.btneliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Primary = true;
            this.btneliminar.Size = new System.Drawing.Size(225, 45);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // pnlbusquedad
            // 
            this.pnlbusquedad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlbusquedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlbusquedad.Controls.Add(this.dgvClientes);
            this.pnlbusquedad.Controls.Add(this.btnbuscar);
            this.pnlbusquedad.Controls.Add(this.txtBuscar);
            this.pnlbusquedad.Location = new System.Drawing.Point(76, 343);
            this.pnlbusquedad.Name = "pnlbusquedad";
            this.pnlbusquedad.Size = new System.Drawing.Size(615, 188);
            this.pnlbusquedad.TabIndex = 6;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(38, 55);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(564, 132);
            this.dgvClientes.TabIndex = 8;
            this.dgvClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientes_CellMouseClick);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Depth = 0;
            this.btnbuscar.Location = new System.Drawing.Point(502, 3);
            this.btnbuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Primary = true;
            this.btnbuscar.Size = new System.Drawing.Size(100, 45);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Nombre o apellido";
            this.txtBuscar.Location = new System.Drawing.Point(38, 20);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(458, 28);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.Depth = 0;
            this.btnsalir.Location = new System.Drawing.Point(865, 477);
            this.btnsalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Primary = true;
            this.btnsalir.Size = new System.Drawing.Size(100, 45);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // CLIENTE
            // 
            this.CLIENTE.Controls.Add(this.txtnombre);
            this.CLIENTE.Controls.Add(this.IdCliente);
            this.CLIENTE.Controls.Add(this.txtdocumento);
            this.CLIENTE.Controls.Add(this.txtemail);
            this.CLIENTE.Controls.Add(this.txtdireccion);
            this.CLIENTE.Controls.Add(this.txttelefono);
            this.CLIENTE.Location = new System.Drawing.Point(76, 40);
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Size = new System.Drawing.Size(554, 297);
            this.CLIENTE.TabIndex = 9;
            this.CLIENTE.TabStop = false;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 543);
            this.Controls.Add(this.CLIENTE);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.pnlbusquedad);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.pnlbusquedad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.CLIENTE.ResumeLayout(false);
            this.CLIENTE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtemail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txttelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdocumento;
        private System.Windows.Forms.Label lbltitulo;
        private MaterialSkin.Controls.MaterialRaisedButton btnnuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnactualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btneliminar;
        private System.Windows.Forms.Panel pnlbusquedad;
        private MaterialSkin.Controls.MaterialRaisedButton btnbuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnsalir;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ErrorProvider MensajeError;
        private System.Windows.Forms.TextBox IdCliente;
        private System.Windows.Forms.GroupBox CLIENTE;
    }
}