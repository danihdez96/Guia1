﻿namespace WindowsFormsApplication1
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicacionToolStripMenuItem,
            this.divisonToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restaToolStripMenuItem.Text = "Resta";
            // 
            // multiplicacionToolStripMenuItem
            // 
            this.multiplicacionToolStripMenuItem.Name = "multiplicacionToolStripMenuItem";
            this.multiplicacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.multiplicacionToolStripMenuItem.Text = "Multiplicacion";
            // 
            // divisonToolStripMenuItem
            // 
            this.divisonToolStripMenuItem.Name = "divisonToolStripMenuItem";
            this.divisonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.divisonToolStripMenuItem.Text = "Divison";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;

    }
}



