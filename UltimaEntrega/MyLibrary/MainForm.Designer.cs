﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenadosPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenadosPorApellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenadosPorIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaDeLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arriboDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(367, 28);
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
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenadosPorNombreToolStripMenuItem,
            this.ordenadosPorApellidoToolStripMenuItem,
            this.ordenadosPorIDToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // ordenadosPorNombreToolStripMenuItem
            // 
            this.ordenadosPorNombreToolStripMenuItem.Name = "ordenadosPorNombreToolStripMenuItem";
            this.ordenadosPorNombreToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.ordenadosPorNombreToolStripMenuItem.Text = "Ordenados por nombre";
            this.ordenadosPorNombreToolStripMenuItem.Click += new System.EventHandler(this.ordenadosPorNombreToolStripMenuItem_Click);
            // 
            // ordenadosPorApellidoToolStripMenuItem
            // 
            this.ordenadosPorApellidoToolStripMenuItem.Name = "ordenadosPorApellidoToolStripMenuItem";
            this.ordenadosPorApellidoToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.ordenadosPorApellidoToolStripMenuItem.Text = "Ordenados por apellido";
            this.ordenadosPorApellidoToolStripMenuItem.Click += new System.EventHandler(this.ordenadosPorApellidoToolStripMenuItem_Click);
            // 
            // ordenadosPorIDToolStripMenuItem
            // 
            this.ordenadosPorIDToolStripMenuItem.Name = "ordenadosPorIDToolStripMenuItem";
            this.ordenadosPorIDToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.ordenadosPorIDToolStripMenuItem.Text = "Ordenados por ID";
            this.ordenadosPorIDToolStripMenuItem.Click += new System.EventHandler(this.ordenadosPorIDToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendientesToolStripMenuItem,
            this.solicitarToolStripMenuItem,
            this.devolverToolStripMenuItem});
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // pendientesToolStripMenuItem
            // 
            this.pendientesToolStripMenuItem.Name = "pendientesToolStripMenuItem";
            this.pendientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pendientesToolStripMenuItem.Text = "Pendientes";
            this.pendientesToolStripMenuItem.Click += new System.EventHandler(this.pendientesToolStripMenuItem_Click);
            // 
            // solicitarToolStripMenuItem
            // 
            this.solicitarToolStripMenuItem.Name = "solicitarToolStripMenuItem";
            this.solicitarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.solicitarToolStripMenuItem.Text = "Solicitar";
            this.solicitarToolStripMenuItem.Click += new System.EventHandler(this.solicitarToolStripMenuItem_Click);
            // 
            // devolverToolStripMenuItem
            // 
            this.devolverToolStripMenuItem.Name = "devolverToolStripMenuItem";
            this.devolverToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.devolverToolStripMenuItem.Text = "Devolver";
            this.devolverToolStripMenuItem.Click += new System.EventHandler(this.devolverToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaDeLibroToolStripMenuItem,
            this.arriboDeLibrosToolStripMenuItem,
            this.eliminarLibrosToolStripMenuItem,
            this.darDeBajaLibroToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // AltaDeLibroToolStripMenuItem
            // 
            this.AltaDeLibroToolStripMenuItem.Name = "AltaDeLibroToolStripMenuItem";
            this.AltaDeLibroToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.AltaDeLibroToolStripMenuItem.Text = "Alta de Libro";
            this.AltaDeLibroToolStripMenuItem.Click += new System.EventHandler(this.AltaDeLibroToolStripMenuItem_Click);
            // 
            // arriboDeLibrosToolStripMenuItem
            // 
            this.arriboDeLibrosToolStripMenuItem.Name = "arriboDeLibrosToolStripMenuItem";
            this.arriboDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.arriboDeLibrosToolStripMenuItem.Text = "Arribo de libros ";
            this.arriboDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.arriboDeLibrosToolStripMenuItem_Click);
            // 
            // eliminarLibrosToolStripMenuItem
            // 
            this.eliminarLibrosToolStripMenuItem.Name = "eliminarLibrosToolStripMenuItem";
            this.eliminarLibrosToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.eliminarLibrosToolStripMenuItem.Text = "Eliminar libros ";
            this.eliminarLibrosToolStripMenuItem.Click += new System.EventHandler(this.eliminarLibrosToolStripMenuItem_Click);
            // 
            // darDeBajaLibroToolStripMenuItem
            // 
            this.darDeBajaLibroToolStripMenuItem.Name = "darDeBajaLibroToolStripMenuItem";
            this.darDeBajaLibroToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.darDeBajaLibroToolStripMenuItem.Text = "Dar de baja libro";
            this.darDeBajaLibroToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaLibroToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(367, 42);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Library";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.ToolStripMenuItem pendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AltaDeLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arriboDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaLibroToolStripMenuItem;
    }
}

