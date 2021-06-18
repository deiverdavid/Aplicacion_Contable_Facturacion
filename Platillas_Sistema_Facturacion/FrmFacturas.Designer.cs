namespace Platillas_Sistema_Facturacion
{
    partial class FrmFacturas
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
            this.btnsalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlbusquedad = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.btneliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnactualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnnuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlinformacion = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboempleado = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txttotalfactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.txtIva = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtdescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnumerofactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnbuscarfactura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlbusquedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.pnlinformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Depth = 0;
            this.btnsalir.Location = new System.Drawing.Point(876, 487);
            this.btnsalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Primary = true;
            this.btnsalir.Size = new System.Drawing.Size(100, 45);
            this.btnsalir.TabIndex = 21;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // pnlbusquedad
            // 
            this.pnlbusquedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlbusquedad.Controls.Add(this.label4);
            this.pnlbusquedad.Controls.Add(this.dgvproductos);
            this.pnlbusquedad.Location = new System.Drawing.Point(31, 398);
            this.pnlbusquedad.Name = "pnlbusquedad";
            this.pnlbusquedad.Size = new System.Drawing.Size(695, 145);
            this.pnlbusquedad.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "DETALLE FACTURA";
            // 
            // dgvproductos
            // 
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(34, 20);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.RowHeadersWidth = 51;
            this.dgvproductos.RowTemplate.Height = 24;
            this.dgvproductos.Size = new System.Drawing.Size(631, 112);
            this.dgvproductos.TabIndex = 8;
            // 
            // btneliminar
            // 
            this.btneliminar.Depth = 0;
            this.btneliminar.Location = new System.Drawing.Point(740, 298);
            this.btneliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Primary = true;
            this.btneliminar.Size = new System.Drawing.Size(225, 45);
            this.btneliminar.TabIndex = 19;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Depth = 0;
            this.btnactualizar.Location = new System.Drawing.Point(740, 223);
            this.btnactualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Primary = true;
            this.btnactualizar.Size = new System.Drawing.Size(225, 45);
            this.btnactualizar.TabIndex = 18;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Depth = 0;
            this.btnnuevo.Location = new System.Drawing.Point(740, 154);
            this.btnnuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Primary = true;
            this.btnnuevo.Size = new System.Drawing.Size(225, 45);
            this.btnnuevo.TabIndex = 17;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // pnlinformacion
            // 
            this.pnlinformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlinformacion.Controls.Add(this.comboBox3);
            this.pnlinformacion.Controls.Add(this.label3);
            this.pnlinformacion.Controls.Add(this.label2);
            this.pnlinformacion.Controls.Add(this.label1);
            this.pnlinformacion.Controls.Add(this.cboempleado);
            this.pnlinformacion.Controls.Add(this.cboCliente);
            this.pnlinformacion.Controls.Add(this.dateTimePicker1);
            this.pnlinformacion.Controls.Add(this.txttotalfactura);
            this.pnlinformacion.Controls.Add(this.lblcategoria);
            this.pnlinformacion.Controls.Add(this.txtIva);
            this.pnlinformacion.Controls.Add(this.txtdescuento);
            this.pnlinformacion.Controls.Add(this.txtnumerofactura);
            this.pnlinformacion.Location = new System.Drawing.Point(31, 38);
            this.pnlinformacion.Name = "pnlinformacion";
            this.pnlinformacion.Size = new System.Drawing.Size(695, 354);
            this.pnlinformacion.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(431, 144);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 24);
            this.comboBox3.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cliente";
            // 
            // cboempleado
            // 
            this.cboempleado.FormattingEnabled = true;
            this.cboempleado.Location = new System.Drawing.Point(127, 108);
            this.cboempleado.Name = "cboempleado";
            this.cboempleado.Size = new System.Drawing.Size(193, 24);
            this.cboempleado.TabIndex = 13;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(127, 65);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(193, 24);
            this.cboCliente.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(431, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txttotalfactura
            // 
            this.txttotalfactura.Depth = 0;
            this.txttotalfactura.Hint = "Total Factura";
            this.txttotalfactura.Location = new System.Drawing.Point(19, 270);
            this.txttotalfactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txttotalfactura.Name = "txttotalfactura";
            this.txttotalfactura.PasswordChar = '\0';
            this.txttotalfactura.SelectedText = "";
            this.txttotalfactura.SelectionLength = 0;
            this.txttotalfactura.SelectionStart = 0;
            this.txttotalfactura.Size = new System.Drawing.Size(301, 28);
            this.txttotalfactura.TabIndex = 10;
            this.txttotalfactura.UseSystemPasswordChar = false;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(427, 16);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(123, 20);
            this.lblcategoria.TabIndex = 5;
            this.lblcategoria.Text = "Fecha Registro";
            // 
            // txtIva
            // 
            this.txtIva.Depth = 0;
            this.txtIva.Hint = "Total Iva";
            this.txtIva.Location = new System.Drawing.Point(19, 215);
            this.txtIva.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIva.Name = "txtIva";
            this.txtIva.PasswordChar = '\0';
            this.txtIva.SelectedText = "";
            this.txtIva.SelectionLength = 0;
            this.txtIva.SelectionStart = 0;
            this.txtIva.Size = new System.Drawing.Size(301, 28);
            this.txtIva.TabIndex = 4;
            this.txtIva.UseSystemPasswordChar = false;
            // 
            // txtdescuento
            // 
            this.txtdescuento.Depth = 0;
            this.txtdescuento.Hint = "Descuento";
            this.txtdescuento.Location = new System.Drawing.Point(19, 158);
            this.txtdescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.PasswordChar = '\0';
            this.txtdescuento.SelectedText = "";
            this.txtdescuento.SelectionLength = 0;
            this.txtdescuento.SelectionStart = 0;
            this.txtdescuento.Size = new System.Drawing.Size(128, 28);
            this.txtdescuento.TabIndex = 3;
            this.txtdescuento.UseSystemPasswordChar = false;
            // 
            // txtnumerofactura
            // 
            this.txtnumerofactura.Depth = 0;
            this.txtnumerofactura.Hint = "Nro Factura";
            this.txtnumerofactura.Location = new System.Drawing.Point(19, 16);
            this.txtnumerofactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnumerofactura.Name = "txtnumerofactura";
            this.txtnumerofactura.PasswordChar = '\0';
            this.txtnumerofactura.SelectedText = "";
            this.txtnumerofactura.SelectionLength = 0;
            this.txtnumerofactura.SelectionStart = 0;
            this.txtnumerofactura.Size = new System.Drawing.Size(128, 28);
            this.txtnumerofactura.TabIndex = 0;
            this.txtnumerofactura.UseSystemPasswordChar = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(258, 6);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(376, 29);
            this.lbltitulo.TabIndex = 15;
            this.lbltitulo.Text = "ADMINISTRACIÓN FACTURAS";
            // 
            // btnbuscarfactura
            // 
            this.btnbuscarfactura.Depth = 0;
            this.btnbuscarfactura.Location = new System.Drawing.Point(740, 90);
            this.btnbuscarfactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnbuscarfactura.Name = "btnbuscarfactura";
            this.btnbuscarfactura.Primary = true;
            this.btnbuscarfactura.Size = new System.Drawing.Size(225, 45);
            this.btnbuscarfactura.TabIndex = 22;
            this.btnbuscarfactura.Text = "Buscar factura";
            this.btnbuscarfactura.UseVisualStyleBackColor = true;
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 543);
            this.Controls.Add(this.btnbuscarfactura);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.pnlbusquedad);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.pnlinformacion);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FrmFacturas";
            this.Text = "FrmFacturas";
            this.pnlbusquedad.ResumeLayout(false);
            this.pnlbusquedad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.pnlinformacion.ResumeLayout(false);
            this.pnlinformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnsalir;
        private System.Windows.Forms.Panel pnlbusquedad;
        private System.Windows.Forms.DataGridView dgvproductos;
        private MaterialSkin.Controls.MaterialRaisedButton btneliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnactualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnnuevo;
        private System.Windows.Forms.Panel pnlinformacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txttotalfactura;
        private System.Windows.Forms.Label lblcategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIva;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdescuento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnumerofactura;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboempleado;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnbuscarfactura;
        private System.Windows.Forms.Label label4;
    }
}