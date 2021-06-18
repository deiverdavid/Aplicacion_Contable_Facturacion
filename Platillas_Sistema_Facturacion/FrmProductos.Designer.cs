namespace Platillas_Sistema_Facturacion
{
    partial class FrmProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlbusquedad = new System.Windows.Forms.Panel();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btneliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnactualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnnuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlinformacion = new System.Windows.Forms.Panel();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtdetalles = new System.Windows.Forms.TextBox();
            this.lblproducto = new System.Windows.Forms.Label();
            this.txtrutaimagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.txtNumStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtprecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlbusquedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.pnlinformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // btnsalir
            // 
            this.btnsalir.Depth = 0;
            this.btnsalir.Location = new System.Drawing.Point(839, 477);
            this.btnsalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Primary = true;
            this.btnsalir.Size = new System.Drawing.Size(100, 45);
            this.btnsalir.TabIndex = 14;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // pnlbusquedad
            // 
            this.pnlbusquedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlbusquedad.Controls.Add(this.dgvproductos);
            this.pnlbusquedad.Controls.Add(this.btnbuscar);
            this.pnlbusquedad.Controls.Add(this.txtBuscar);
            this.pnlbusquedad.Location = new System.Drawing.Point(50, 358);
            this.pnlbusquedad.Name = "pnlbusquedad";
            this.pnlbusquedad.Size = new System.Drawing.Size(695, 185);
            this.pnlbusquedad.TabIndex = 13;
            // 
            // dgvproductos
            // 
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(38, 55);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.RowHeadersWidth = 51;
            this.dgvproductos.RowTemplate.Height = 24;
            this.dgvproductos.Size = new System.Drawing.Size(639, 125);
            this.dgvproductos.TabIndex = 8;
            this.dgvproductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvproductos_CellMouseClick);
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
            this.txtBuscar.Hint = "Nombre Producto";
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
            // btneliminar
            // 
            this.btneliminar.Depth = 0;
            this.btneliminar.Location = new System.Drawing.Point(751, 251);
            this.btneliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Primary = true;
            this.btneliminar.Size = new System.Drawing.Size(225, 45);
            this.btneliminar.TabIndex = 12;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Depth = 0;
            this.btnactualizar.Location = new System.Drawing.Point(751, 174);
            this.btnactualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Primary = true;
            this.btnactualizar.Size = new System.Drawing.Size(225, 45);
            this.btnactualizar.TabIndex = 11;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Depth = 0;
            this.btnnuevo.Location = new System.Drawing.Point(751, 94);
            this.btnnuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Primary = true;
            this.btnnuevo.Size = new System.Drawing.Size(225, 45);
            this.btnnuevo.TabIndex = 10;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // pnlinformacion
            // 
            this.pnlinformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlinformacion.Controls.Add(this.txtIdProducto);
            this.pnlinformacion.Controls.Add(this.txtdetalles);
            this.pnlinformacion.Controls.Add(this.lblproducto);
            this.pnlinformacion.Controls.Add(this.txtrutaimagen);
            this.pnlinformacion.Controls.Add(this.cboCategoria);
            this.pnlinformacion.Controls.Add(this.lblcategoria);
            this.pnlinformacion.Controls.Add(this.txtNumStock);
            this.pnlinformacion.Controls.Add(this.txtprecioVenta);
            this.pnlinformacion.Controls.Add(this.txtcompra);
            this.pnlinformacion.Controls.Add(this.txtCodigo);
            this.pnlinformacion.Controls.Add(this.txtNombreProducto);
            this.pnlinformacion.Location = new System.Drawing.Point(50, 42);
            this.pnlinformacion.Name = "pnlinformacion";
            this.pnlinformacion.Size = new System.Drawing.Size(695, 310);
            this.pnlinformacion.TabIndex = 9;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(38, -1);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 22);
            this.txtIdProducto.TabIndex = 10;
            this.txtIdProducto.Visible = false;
            // 
            // txtdetalles
            // 
            this.txtdetalles.Location = new System.Drawing.Point(411, 188);
            this.txtdetalles.Multiline = true;
            this.txtdetalles.Name = "txtdetalles";
            this.txtdetalles.Size = new System.Drawing.Size(266, 92);
            this.txtdetalles.TabIndex = 9;
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducto.Location = new System.Drawing.Point(415, 148);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(143, 20);
            this.lblproducto.TabIndex = 8;
            this.lblproducto.Text = "Detalles Producto";
            // 
            // txtrutaimagen
            // 
            this.txtrutaimagen.Depth = 0;
            this.txtrutaimagen.Hint = "Ruta Imagen";
            this.txtrutaimagen.Location = new System.Drawing.Point(431, 91);
            this.txtrutaimagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtrutaimagen.Name = "txtrutaimagen";
            this.txtrutaimagen.PasswordChar = '\0';
            this.txtrutaimagen.SelectedText = "";
            this.txtrutaimagen.SelectionLength = 0;
            this.txtrutaimagen.SelectionStart = 0;
            this.txtrutaimagen.Size = new System.Drawing.Size(228, 28);
            this.txtrutaimagen.TabIndex = 7;
            this.txtrutaimagen.UseSystemPasswordChar = false;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(502, 24);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 24);
            this.cboCategoria.TabIndex = 6;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(407, 24);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(81, 20);
            this.lblcategoria.TabIndex = 5;
            this.lblcategoria.Text = "Categoría";
            // 
            // txtNumStock
            // 
            this.txtNumStock.Depth = 0;
            this.txtNumStock.Hint = "Cantidad Stock";
            this.txtNumStock.Location = new System.Drawing.Point(38, 262);
            this.txtNumStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumStock.Name = "txtNumStock";
            this.txtNumStock.PasswordChar = '\0';
            this.txtNumStock.SelectedText = "";
            this.txtNumStock.SelectionLength = 0;
            this.txtNumStock.SelectionStart = 0;
            this.txtNumStock.Size = new System.Drawing.Size(301, 28);
            this.txtNumStock.TabIndex = 4;
            this.txtNumStock.UseSystemPasswordChar = false;
            // 
            // txtprecioVenta
            // 
            this.txtprecioVenta.Depth = 0;
            this.txtprecioVenta.Hint = "Precio Venta";
            this.txtprecioVenta.Location = new System.Drawing.Point(38, 208);
            this.txtprecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtprecioVenta.Name = "txtprecioVenta";
            this.txtprecioVenta.PasswordChar = '\0';
            this.txtprecioVenta.SelectedText = "";
            this.txtprecioVenta.SelectionLength = 0;
            this.txtprecioVenta.SelectionStart = 0;
            this.txtprecioVenta.Size = new System.Drawing.Size(301, 28);
            this.txtprecioVenta.TabIndex = 3;
            this.txtprecioVenta.UseSystemPasswordChar = false;
            // 
            // txtcompra
            // 
            this.txtcompra.Depth = 0;
            this.txtcompra.Hint = "Precio Compra";
            this.txtcompra.Location = new System.Drawing.Point(38, 148);
            this.txtcompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.PasswordChar = '\0';
            this.txtcompra.SelectedText = "";
            this.txtcompra.SelectionLength = 0;
            this.txtcompra.SelectionStart = 0;
            this.txtcompra.Size = new System.Drawing.Size(301, 28);
            this.txtcompra.TabIndex = 2;
            this.txtcompra.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Hint = "Código Referencia";
            this.txtCodigo.Location = new System.Drawing.Point(38, 87);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(301, 28);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Hint = "Nombre Producto";
            this.txtNombreProducto.Location = new System.Drawing.Point(38, 24);
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.SelectionLength = 0;
            this.txtNombreProducto.SelectionStart = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(301, 28);
            this.txtNombreProducto.TabIndex = 0;
            this.txtNombreProducto.UseSystemPasswordChar = false;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 543);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.pnlbusquedad);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.pnlinformacion);
            this.Controls.Add(this.label1);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.pnlbusquedad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.pnlinformacion.ResumeLayout(false);
            this.pnlinformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnsalir;
        private System.Windows.Forms.Panel pnlbusquedad;
        private MaterialSkin.Controls.MaterialRaisedButton btnbuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btneliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnactualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnnuevo;
        private System.Windows.Forms.Panel pnlinformacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtprecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProducto;
        private System.Windows.Forms.TextBox txtdetalles;
        private System.Windows.Forms.Label lblproducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtrutaimagen;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.ErrorProvider MensajeError;
        public System.Windows.Forms.DataGridView dgvproductos;
    }
}