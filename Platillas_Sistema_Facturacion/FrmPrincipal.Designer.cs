namespace Platillas_Sistema_Facturacion
{
    partial class FrmPrincipal
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
            this.tabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbpmenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.btnsalir = new System.Windows.Forms.Button();
            this.piclogoPri = new System.Windows.Forms.PictureBox();
            this.tablas = new System.Windows.Forms.TabPage();
            this.btncategorias = new System.Windows.Forms.Button();
            this.btnproductos = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.piclogoseg = new System.Windows.Forms.PictureBox();
            this.facturación = new System.Windows.Forms.TabPage();
            this.btninformes = new System.Windows.Forms.Button();
            this.btnfacturas = new System.Windows.Forms.Button();
            this.piclogoter = new System.Windows.Forms.PictureBox();
            this.seguridad = new System.Windows.Forms.TabPage();
            this.btnseguridad = new System.Windows.Forms.Button();
            this.btnroles = new System.Windows.Forms.Button();
            this.btnempleados = new System.Windows.Forms.Button();
            this.piclogocuar = new System.Windows.Forms.PictureBox();
            this.acerca = new System.Windows.Forms.TabPage();
            this.btnaacercade = new System.Windows.Forms.Button();
            this.btnayuda = new System.Windows.Forms.Button();
            this.piclogoquin = new System.Windows.Forms.PictureBox();
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.pnlprincipal = new System.Windows.Forms.Panel();
            this.pnlcontenedor = new System.Windows.Forms.Panel();
            this.tbpmenu.SuspendLayout();
            this.Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogoPri)).BeginInit();
            this.tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogoseg)).BeginInit();
            this.facturación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogoter)).BeginInit();
            this.seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogocuar)).BeginInit();
            this.acerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogoquin)).BeginInit();
            this.pnlmenu.SuspendLayout();
            this.pnlprincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOpcionesMenu
            // 
            this.tabOpcionesMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabOpcionesMenu.BackColor = System.Drawing.Color.White;
            this.tabOpcionesMenu.BaseTabControl = this.tbpmenu;
            this.tabOpcionesMenu.Depth = 0;
            this.tabOpcionesMenu.ForeColor = System.Drawing.Color.White;
            this.tabOpcionesMenu.Location = new System.Drawing.Point(347, 38);
            this.tabOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionesMenu.Name = "tabOpcionesMenu";
            this.tabOpcionesMenu.Size = new System.Drawing.Size(787, 23);
            this.tabOpcionesMenu.TabIndex = 1;
            // 
            // tbpmenu
            // 
            this.tbpmenu.Controls.Add(this.Principal);
            this.tbpmenu.Controls.Add(this.tablas);
            this.tbpmenu.Controls.Add(this.facturación);
            this.tbpmenu.Controls.Add(this.seguridad);
            this.tbpmenu.Controls.Add(this.acerca);
            this.tbpmenu.Depth = 0;
            this.tbpmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbpmenu.Location = new System.Drawing.Point(0, 0);
            this.tbpmenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbpmenu.Name = "tbpmenu";
            this.tbpmenu.SelectedIndex = 0;
            this.tbpmenu.Size = new System.Drawing.Size(200, 588);
            this.tbpmenu.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.Principal.Controls.Add(this.btnsalir);
            this.Principal.Controls.Add(this.piclogoPri);
            this.Principal.Location = new System.Drawing.Point(4, 25);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(192, 559);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            // 
            // btnsalir
            // 
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(187)))), ((int)(((byte)(85)))));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.imaSalir32;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(6, 470);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(204, 64);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // piclogoPri
            // 
            this.piclogoPri.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.Logo64;
            this.piclogoPri.Location = new System.Drawing.Point(30, 20);
            this.piclogoPri.Name = "piclogoPri";
            this.piclogoPri.Size = new System.Drawing.Size(128, 128);
            this.piclogoPri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogoPri.TabIndex = 0;
            this.piclogoPri.TabStop = false;
            // 
            // tablas
            // 
            this.tablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.tablas.Controls.Add(this.btncategorias);
            this.tablas.Controls.Add(this.btnproductos);
            this.tablas.Controls.Add(this.btnclientes);
            this.tablas.Controls.Add(this.piclogoseg);
            this.tablas.Location = new System.Drawing.Point(4, 25);
            this.tablas.Name = "tablas";
            this.tablas.Padding = new System.Windows.Forms.Padding(3);
            this.tablas.Size = new System.Drawing.Size(192, 559);
            this.tablas.TabIndex = 1;
            this.tablas.Text = "Tablas";
            // 
            // btncategorias
            // 
            this.btncategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncategorias.FlatAppearance.BorderSize = 0;
            this.btncategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(187)))), ((int)(((byte)(85)))));
            this.btncategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorias.ForeColor = System.Drawing.Color.Black;
            this.btncategorias.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.imacategories;
            this.btncategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategorias.Location = new System.Drawing.Point(0, 383);
            this.btncategorias.Name = "btncategorias";
            this.btncategorias.Padding = new System.Windows.Forms.Padding(6);
            this.btncategorias.Size = new System.Drawing.Size(222, 64);
            this.btncategorias.TabIndex = 4;
            this.btncategorias.Text = "   Categorias";
            this.btncategorias.UseVisualStyleBackColor = true;
            this.btncategorias.Click += new System.EventHandler(this.btncategorias_Click);
            // 
            // btnproductos
            // 
            this.btnproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproductos.FlatAppearance.BorderSize = 0;
            this.btnproductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(187)))), ((int)(((byte)(85)))));
            this.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.ForeColor = System.Drawing.Color.Black;
            this.btnproductos.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.imaProducts32;
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(-1, 295);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Padding = new System.Windows.Forms.Padding(6);
            this.btnproductos.Size = new System.Drawing.Size(223, 64);
            this.btnproductos.TabIndex = 3;
            this.btnproductos.Text = "   Productos";
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(187)))), ((int)(((byte)(85)))));
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.Color.Black;
            this.btnclientes.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.imaClients;
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(0, 208);
            this.btnclientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Padding = new System.Windows.Forms.Padding(6);
            this.btnclientes.Size = new System.Drawing.Size(222, 64);
            this.btnclientes.TabIndex = 2;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // piclogoseg
            // 
            this.piclogoseg.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.Logo64;
            this.piclogoseg.Location = new System.Drawing.Point(30, 20);
            this.piclogoseg.Name = "piclogoseg";
            this.piclogoseg.Size = new System.Drawing.Size(128, 128);
            this.piclogoseg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogoseg.TabIndex = 1;
            this.piclogoseg.TabStop = false;
            // 
            // facturación
            // 
            this.facturación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.facturación.Controls.Add(this.btninformes);
            this.facturación.Controls.Add(this.btnfacturas);
            this.facturación.Controls.Add(this.piclogoter);
            this.facturación.Location = new System.Drawing.Point(4, 25);
            this.facturación.Name = "facturación";
            this.facturación.Size = new System.Drawing.Size(192, 559);
            this.facturación.TabIndex = 2;
            this.facturación.Text = "Facturación";
            // 
            // btninformes
            // 
            this.btninformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninformes.FlatAppearance.BorderSize = 0;
            this.btninformes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btninformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(187)))), ((int)(((byte)(85)))));
            this.btninformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformes.ForeColor = System.Drawing.Color.Black;
            this.btninformes.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.imareports;
            this.btninformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninformes.Location = new System.Drawing.Point(-4, 327);
            this.btninformes.Margin = new System.Windows.Forms.Padding(0);
            this.btninformes.Name = "btninformes";
            this.btninformes.Padding = new System.Windows.Forms.Padding(6);
            this.btninformes.Size = new System.Drawing.Size(230, 64);
            this.btninformes.TabIndex = 4;
            this.btninformes.Text = "Informes";
            this.btninformes.UseVisualStyleBackColor = true;
            this.btninformes.Click += new System.EventHandler(this.btninformes_Click);
            // 
            // btnfacturas
            // 
            this.btnfacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfacturas.FlatAppearance.BorderSize = 0;
            this.btnfacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnfacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(187)))), ((int)(((byte)(85)))));
            this.btnfacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacturas.ForeColor = System.Drawing.Color.Black;
            this.btnfacturas.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.imainvoices;
            this.btnfacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfacturas.Location = new System.Drawing.Point(-4, 237);
            this.btnfacturas.Margin = new System.Windows.Forms.Padding(0);
            this.btnfacturas.Name = "btnfacturas";
            this.btnfacturas.Padding = new System.Windows.Forms.Padding(6);
            this.btnfacturas.Size = new System.Drawing.Size(230, 64);
            this.btnfacturas.TabIndex = 3;
            this.btnfacturas.Text = "Facturas";
            this.btnfacturas.UseVisualStyleBackColor = true;
            this.btnfacturas.Click += new System.EventHandler(this.btnfacturas_Click);
            // 
            // piclogoter
            // 
            this.piclogoter.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.Logo64;
            this.piclogoter.Location = new System.Drawing.Point(30, 20);
            this.piclogoter.Name = "piclogoter";
            this.piclogoter.Size = new System.Drawing.Size(128, 128);
            this.piclogoter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogoter.TabIndex = 1;
            this.piclogoter.TabStop = false;
            // 
            // seguridad
            // 
            this.seguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.seguridad.Controls.Add(this.btnseguridad);
            this.seguridad.Controls.Add(this.btnroles);
            this.seguridad.Controls.Add(this.btnempleados);
            this.seguridad.Controls.Add(this.piclogocuar);
            this.seguridad.Location = new System.Drawing.Point(4, 25);
            this.seguridad.Name = "seguridad";
            this.seguridad.Size = new System.Drawing.Size(192, 559);
            this.seguridad.TabIndex = 3;
            this.seguridad.Text = "Seguridad";
            // 
            // btnseguridad
            // 
            this.btnseguridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnseguridad.FlatAppearance.BorderSize = 0;
            this.btnseguridad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnseguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(187)))), ((int)(((byte)(85)))));
            this.btnseguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseguridad.ForeColor = System.Drawing.Color.Black;
            this.btnseguridad.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.imasecurity32;
            this.btnseguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnseguridad.Location = new System.Drawing.Point(-4, 410);
            this.btnseguridad.Margin = new System.Windows.Forms.Padding(0);
            this.btnseguridad.Name = "btnseguridad";
            this.btnseguridad.Padding = new System.Windows.Forms.Padding(6);
            this.btnseguridad.Size = new System.Drawing.Size(232, 64);
            this.btnseguridad.TabIndex = 6;
            this.btnseguridad.Text = "Seguridad";
            this.btnseguridad.UseVisualStyleBackColor = true;
            this.btnseguridad.Click += new System.EventHandler(this.btnseguridad_Click);
            // 
            // btnroles
            // 
            this.btnroles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnroles.FlatAppearance.BorderSize = 0;
            this.btnroles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnroles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(187)))), ((int)(((byte)(85)))));
            this.btnroles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroles.ForeColor = System.Drawing.Color.Black;
            this.btnroles.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.imarole;
            this.btnroles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnroles.Location = new System.Drawing.Point(-4, 327);
            this.btnroles.Margin = new System.Windows.Forms.Padding(0);
            this.btnroles.Name = "btnroles";
            this.btnroles.Padding = new System.Windows.Forms.Padding(6);
            this.btnroles.Size = new System.Drawing.Size(181, 64);
            this.btnroles.TabIndex = 5;
            this.btnroles.Text = "Roles";
            this.btnroles.UseVisualStyleBackColor = true;
            this.btnroles.Click += new System.EventHandler(this.btnroles_Click);
            // 
            // btnempleados
            // 
            this.btnempleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnempleados.FlatAppearance.BorderSize = 0;
            this.btnempleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(187)))), ((int)(((byte)(85)))));
            this.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.ForeColor = System.Drawing.Color.Black;
            this.btnempleados.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.imaemployees;
            this.btnempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleados.Location = new System.Drawing.Point(-4, 232);
            this.btnempleados.Margin = new System.Windows.Forms.Padding(0);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Padding = new System.Windows.Forms.Padding(4);
            this.btnempleados.Size = new System.Drawing.Size(240, 64);
            this.btnempleados.TabIndex = 4;
            this.btnempleados.Text = " Empleados";
            this.btnempleados.UseVisualStyleBackColor = true;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
            // 
            // piclogocuar
            // 
            this.piclogocuar.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.Logo64;
            this.piclogocuar.Location = new System.Drawing.Point(30, 20);
            this.piclogocuar.Name = "piclogocuar";
            this.piclogocuar.Size = new System.Drawing.Size(128, 128);
            this.piclogocuar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogocuar.TabIndex = 1;
            this.piclogocuar.TabStop = false;
            // 
            // acerca
            // 
            this.acerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.acerca.Controls.Add(this.btnaacercade);
            this.acerca.Controls.Add(this.btnayuda);
            this.acerca.Controls.Add(this.piclogoquin);
            this.acerca.Location = new System.Drawing.Point(4, 25);
            this.acerca.Name = "acerca";
            this.acerca.Size = new System.Drawing.Size(192, 559);
            this.acerca.TabIndex = 4;
            this.acerca.Text = "Acerca De";
            // 
            // btnaacercade
            // 
            this.btnaacercade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaacercade.FlatAppearance.BorderSize = 0;
            this.btnaacercade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnaacercade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(187)))), ((int)(((byte)(85)))));
            this.btnaacercade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaacercade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaacercade.ForeColor = System.Drawing.Color.Black;
            this.btnaacercade.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.imaabout;
            this.btnaacercade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaacercade.Location = new System.Drawing.Point(-4, 330);
            this.btnaacercade.Margin = new System.Windows.Forms.Padding(0);
            this.btnaacercade.Name = "btnaacercade";
            this.btnaacercade.Padding = new System.Windows.Forms.Padding(6);
            this.btnaacercade.Size = new System.Drawing.Size(211, 64);
            this.btnaacercade.TabIndex = 7;
            this.btnaacercade.Text = "    Acerca de";
            this.btnaacercade.UseVisualStyleBackColor = true;
            this.btnaacercade.Click += new System.EventHandler(this.btnaacercade_Click);
            // 
            // btnayuda
            // 
            this.btnayuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnayuda.FlatAppearance.BorderSize = 0;
            this.btnayuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(187)))), ((int)(((byte)(85)))));
            this.btnayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnayuda.ForeColor = System.Drawing.Color.Black;
            this.btnayuda.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.imahelp;
            this.btnayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnayuda.Location = new System.Drawing.Point(-4, 243);
            this.btnayuda.Margin = new System.Windows.Forms.Padding(0);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Padding = new System.Windows.Forms.Padding(6);
            this.btnayuda.Size = new System.Drawing.Size(200, 64);
            this.btnayuda.TabIndex = 6;
            this.btnayuda.Text = "Ayuda";
            this.btnayuda.UseVisualStyleBackColor = true;
            this.btnayuda.Click += new System.EventHandler(this.btnayuda_Click);
            // 
            // piclogoquin
            // 
            this.piclogoquin.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.Logo64;
            this.piclogoquin.Location = new System.Drawing.Point(30, 20);
            this.piclogoquin.Name = "piclogoquin";
            this.piclogoquin.Size = new System.Drawing.Size(128, 128);
            this.piclogoquin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogoquin.TabIndex = 1;
            this.piclogoquin.TabStop = false;
            // 
            // pnlmenu
            // 
            this.pnlmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmenu.Controls.Add(this.tbpmenu);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(193, 590);
            this.pnlmenu.TabIndex = 0;
            // 
            // pnlprincipal
            // 
            this.pnlprincipal.BackColor = System.Drawing.Color.White;
            this.pnlprincipal.Controls.Add(this.pnlcontenedor);
            this.pnlprincipal.Controls.Add(this.pnlmenu);
            this.pnlprincipal.Location = new System.Drawing.Point(-6, 67);
            this.pnlprincipal.Name = "pnlprincipal";
            this.pnlprincipal.Size = new System.Drawing.Size(1205, 590);
            this.pnlprincipal.TabIndex = 0;
            // 
            // pnlcontenedor
            // 
            this.pnlcontenedor.Location = new System.Drawing.Point(199, 0);
            this.pnlcontenedor.Name = "pnlcontenedor";
            this.pnlcontenedor.Size = new System.Drawing.Size(1006, 590);
            this.pnlcontenedor.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabOpcionesMenu);
            this.Controls.Add(this.pnlprincipal);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE FACTURACIÓN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.tbpmenu.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piclogoPri)).EndInit();
            this.tablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piclogoseg)).EndInit();
            this.facturación.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piclogoter)).EndInit();
            this.seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piclogocuar)).EndInit();
            this.acerca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piclogoquin)).EndInit();
            this.pnlmenu.ResumeLayout(false);
            this.pnlprincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector tabOpcionesMenu;
        private MaterialSkin.Controls.MaterialTabControl tbpmenu;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.PictureBox piclogoPri;
        private System.Windows.Forms.TabPage tablas;
        private System.Windows.Forms.Button btncategorias;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.PictureBox piclogoseg;
        private System.Windows.Forms.TabPage facturación;
        private System.Windows.Forms.Button btninformes;
        private System.Windows.Forms.Button btnfacturas;
        private System.Windows.Forms.PictureBox piclogoter;
        private System.Windows.Forms.TabPage seguridad;
        private System.Windows.Forms.Button btnseguridad;
        private System.Windows.Forms.Button btnroles;
        private System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.PictureBox piclogocuar;
        private System.Windows.Forms.TabPage acerca;
        private System.Windows.Forms.Button btnaacercade;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.PictureBox piclogoquin;
        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Panel pnlprincipal;
        private System.Windows.Forms.Panel pnlcontenedor;
    }
}