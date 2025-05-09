namespace pryPaz_20250509
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbParcial = new System.Windows.Forms.ComboBox();
            this.pctParcial = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctParcial)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbParcial
            // 
            this.cmbParcial.FormattingEnabled = true;
            this.cmbParcial.Location = new System.Drawing.Point(67, 67);
            this.cmbParcial.Name = "cmbParcial";
            this.cmbParcial.Size = new System.Drawing.Size(261, 21);
            this.cmbParcial.TabIndex = 0;
            // 
            // pctParcial
            // 
            this.pctParcial.Location = new System.Drawing.Point(67, 122);
            this.pctParcial.Name = "pctParcial";
            this.pctParcial.Size = new System.Drawing.Size(362, 220);
            this.pctParcial.TabIndex = 1;
            this.pctParcial.TabStop = false;
            this.pctParcial.Click += new System.EventHandler(this.pctParcial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 400);
            this.Controls.Add(this.pctParcial);
            this.Controls.Add(this.cmbParcial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctParcial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbParcial;
        private System.Windows.Forms.PictureBox pctParcial;
    }
}

