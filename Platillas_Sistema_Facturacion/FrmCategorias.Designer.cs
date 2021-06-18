namespace Platillas_Sistema_Facturacion
{
    partial class FrmCategorias
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlbusquedad = new System.Windows.Forms.Panel();
            this.dgvCategoriaProd = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBusca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btneliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnactualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnnuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlinformacion = new System.Windows.Forms.Panel();
            this.txtnombrecategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcodigocategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlbusquedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaProd)).BeginInit();
            this.pnlinformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIA DE PRODUCTOS";
            // 
            // btnsalir
            // 
            this.btnsalir.Depth = 0;
            this.btnsalir.Location = new System.Drawing.Point(839, 466);
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
            this.pnlbusquedad.Controls.Add(this.dgvCategoriaProd);
            this.pnlbusquedad.Controls.Add(this.btnbuscar);
            this.pnlbusquedad.Controls.Add(this.txtBusca);
            this.pnlbusquedad.Location = new System.Drawing.Point(50, 279);
            this.pnlbusquedad.Name = "pnlbusquedad";
            this.pnlbusquedad.Size = new System.Drawing.Size(615, 241);
            this.pnlbusquedad.TabIndex = 13;
            // 
            // dgvCategoriaProd
            // 
            this.dgvCategoriaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriaProd.Location = new System.Drawing.Point(38, 68);
            this.dgvCategoriaProd.Name = "dgvCategoriaProd";
            this.dgvCategoriaProd.RowHeadersWidth = 51;
            this.dgvCategoriaProd.RowTemplate.Height = 24;
            this.dgvCategoriaProd.Size = new System.Drawing.Size(564, 163);
            this.dgvCategoriaProd.TabIndex = 8;
            this.dgvCategoriaProd.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategoriaProd_CellMouseClick);
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
            // txtBusca
            // 
            this.txtBusca.Depth = 0;
            this.txtBusca.Hint = "Buscar Categoría";
            this.txtBusca.Location = new System.Drawing.Point(38, 20);
            this.txtBusca.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PasswordChar = '\0';
            this.txtBusca.SelectedText = "";
            this.txtBusca.SelectionLength = 0;
            this.txtBusca.SelectionStart = 0;
            this.txtBusca.Size = new System.Drawing.Size(458, 28);
            this.txtBusca.TabIndex = 5;
            this.txtBusca.UseSystemPasswordChar = false;
            this.txtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusca_KeyPress);
            // 
            // btneliminar
            // 
            this.btneliminar.Depth = 0;
            this.btneliminar.Location = new System.Drawing.Point(714, 208);
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
            this.btnactualizar.Location = new System.Drawing.Point(714, 131);
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
            this.btnnuevo.Location = new System.Drawing.Point(714, 51);
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
            this.pnlinformacion.Controls.Add(this.txtnombrecategoria);
            this.pnlinformacion.Controls.Add(this.txtcodigocategoria);
            this.pnlinformacion.Location = new System.Drawing.Point(50, 41);
            this.pnlinformacion.Name = "pnlinformacion";
            this.pnlinformacion.Size = new System.Drawing.Size(615, 221);
            this.pnlinformacion.TabIndex = 9;
            // 
            // txtnombrecategoria
            // 
            this.txtnombrecategoria.Depth = 0;
            this.txtnombrecategoria.Hint = "Nombre Categoría";
            this.txtnombrecategoria.Location = new System.Drawing.Point(27, 105);
            this.txtnombrecategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombrecategoria.Name = "txtnombrecategoria";
            this.txtnombrecategoria.PasswordChar = '\0';
            this.txtnombrecategoria.SelectedText = "";
            this.txtnombrecategoria.SelectionLength = 0;
            this.txtnombrecategoria.SelectionStart = 0;
            this.txtnombrecategoria.Size = new System.Drawing.Size(301, 28);
            this.txtnombrecategoria.TabIndex = 1;
            this.txtnombrecategoria.UseSystemPasswordChar = false;
            // 
            // txtcodigocategoria
            // 
            this.txtcodigocategoria.Depth = 0;
            this.txtcodigocategoria.Hint = "Código Categoría";
            this.txtcodigocategoria.Location = new System.Drawing.Point(27, 42);
            this.txtcodigocategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcodigocategoria.Name = "txtcodigocategoria";
            this.txtcodigocategoria.PasswordChar = '\0';
            this.txtcodigocategoria.SelectedText = "";
            this.txtcodigocategoria.SelectionLength = 0;
            this.txtcodigocategoria.SelectionStart = 0;
            this.txtcodigocategoria.Size = new System.Drawing.Size(301, 28);
            this.txtcodigocategoria.TabIndex = 0;
            this.txtcodigocategoria.UseSystemPasswordChar = false;
            // 
            // FrmCategorias
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
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.pnlbusquedad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaProd)).EndInit();
            this.pnlinformacion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnsalir;
        private System.Windows.Forms.Panel pnlbusquedad;
        private System.Windows.Forms.DataGridView dgvCategoriaProd;
        private MaterialSkin.Controls.MaterialRaisedButton btnbuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBusca;
        private MaterialSkin.Controls.MaterialRaisedButton btneliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnactualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnnuevo;
        private System.Windows.Forms.Panel pnlinformacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnombrecategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcodigocategoria;
    }
}