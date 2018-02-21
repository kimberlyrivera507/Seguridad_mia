namespace PrototipoSeguridad
{
    partial class Bitacora
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
            this.cachedCrystalReportBitacora1 = new PrototipoSeguridad.CachedCrystalReportBitacora();
            this.cachedCrystalReportBitacora2 = new PrototipoSeguridad.CachedCrystalReportBitacora();
            this.cachedCrystalReportBitacora3 = new PrototipoSeguridad.CachedCrystalReportBitacora();
            this.bitac1 = new dll_bitacora.bitac();
            this.SuspendLayout();
            // 
            // bitac1
            // 
            this.bitac1.BackColor = System.Drawing.Color.LightBlue;
            this.bitac1.Location = new System.Drawing.Point(12, 12);
            this.bitac1.Name = "bitac1";
            this.bitac1.NombreTabla = "vista_bitacora";
            this.bitac1.Size = new System.Drawing.Size(1138, 728);
            this.bitac1.TabIndex = 0;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1178, 779);
            this.Controls.Add(this.bitac1);
            this.Name = "Bitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CachedCrystalReportBitacora cachedCrystalReportBitacora1;
        private CachedCrystalReportBitacora cachedCrystalReportBitacora2;
        private CachedCrystalReportBitacora cachedCrystalReportBitacora3;
        private dll_bitacora.bitac bitac1;
    }
}