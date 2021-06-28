
namespace MyLibrary
{
    partial class MainForm
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
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenadosPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenadosPorApellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenadosPorIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(275, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenadosPorNombreToolStripMenuItem,
            this.ordenadosPorApellidoToolStripMenuItem,
            this.ordenadosPorIDToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // ordenadosPorNombreToolStripMenuItem
            // 
            this.ordenadosPorNombreToolStripMenuItem.Name = "ordenadosPorNombreToolStripMenuItem";
            this.ordenadosPorNombreToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.ordenadosPorNombreToolStripMenuItem.Text = "Ordenados por nombre";
            this.ordenadosPorNombreToolStripMenuItem.Click += new System.EventHandler(this.ordenadosPorNombreToolStripMenuItem_Click);
            // 
            // ordenadosPorApellidoToolStripMenuItem
            // 
            this.ordenadosPorApellidoToolStripMenuItem.Name = "ordenadosPorApellidoToolStripMenuItem";
            this.ordenadosPorApellidoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.ordenadosPorApellidoToolStripMenuItem.Text = "Ordenados por apellido";
            this.ordenadosPorApellidoToolStripMenuItem.Click += new System.EventHandler(this.ordenadosPorApellidoToolStripMenuItem_Click);
            // 
            // ordenadosPorIDToolStripMenuItem
            // 
            this.ordenadosPorIDToolStripMenuItem.Name = "ordenadosPorIDToolStripMenuItem";
            this.ordenadosPorIDToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.ordenadosPorIDToolStripMenuItem.Text = "Ordenados por ID";
            this.ordenadosPorIDToolStripMenuItem.Click += new System.EventHandler(this.ordenadosPorIDToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(275, 34);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLibrary";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenadosPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenadosPorApellidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenadosPorIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}

