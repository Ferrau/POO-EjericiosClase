namespace Clase_3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMINISTRACIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nAFTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sURTIDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINISTRACIÓNToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDMINISTRACIÓNToolStripMenuItem
            // 
            this.aDMINISTRACIÓNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nAFTAToolStripMenuItem,
            this.sURTIDORESToolStripMenuItem,
            this.gESTIÓNToolStripMenuItem});
            this.aDMINISTRACIÓNToolStripMenuItem.Name = "aDMINISTRACIÓNToolStripMenuItem";
            this.aDMINISTRACIÓNToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.aDMINISTRACIÓNToolStripMenuItem.Text = "ADMINISTRACIÓN";
            // 
            // nAFTAToolStripMenuItem
            // 
            this.nAFTAToolStripMenuItem.Name = "nAFTAToolStripMenuItem";
            this.nAFTAToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nAFTAToolStripMenuItem.Text = "NAFTA";
            this.nAFTAToolStripMenuItem.Click += new System.EventHandler(this.nAFTAToolStripMenuItem_Click);
            // 
            // sURTIDORESToolStripMenuItem
            // 
            this.sURTIDORESToolStripMenuItem.Name = "sURTIDORESToolStripMenuItem";
            this.sURTIDORESToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sURTIDORESToolStripMenuItem.Text = "SURTIDORES";
            this.sURTIDORESToolStripMenuItem.Click += new System.EventHandler(this.sURTIDORESToolStripMenuItem_Click);
            // 
            // gESTIÓNToolStripMenuItem
            // 
            this.gESTIÓNToolStripMenuItem.Name = "gESTIÓNToolStripMenuItem";
            this.gESTIÓNToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gESTIÓNToolStripMenuItem.Text = "GESTIÓN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 719);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRACIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nAFTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sURTIDORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIÓNToolStripMenuItem;
    }
}

