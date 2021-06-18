namespace Platillas_Sistema_Facturacion
{
    partial class FrmAcercaDe
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
            this.picAcercaDe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAcercaDe)).BeginInit();
            this.SuspendLayout();
            // 
            // picAcercaDe
            // 
            this.picAcercaDe.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.seis_licencias_creative1;
            this.picAcercaDe.Location = new System.Drawing.Point(192, 51);
            this.picAcercaDe.Name = "picAcercaDe";
            this.picAcercaDe.Size = new System.Drawing.Size(602, 400);
            this.picAcercaDe.TabIndex = 0;
            this.picAcercaDe.TabStop = false;
            // 
            // FrmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 543);
            this.Controls.Add(this.picAcercaDe);
            this.Name = "FrmAcercaDe";
            this.Text = "FrmAcercaDe";
            ((System.ComponentModel.ISupportInitialize)(this.picAcercaDe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAcercaDe;
    }
}