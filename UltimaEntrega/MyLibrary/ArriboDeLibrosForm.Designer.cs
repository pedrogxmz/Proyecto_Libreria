﻿
namespace MyLibrary
{
    partial class ArriboDeLibrosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArriboDeLibrosForm));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.tbNCopias = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIdBook = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbNCopias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(174, 130);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 25);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Enabled = false;
            this.btnAñadir.Location = new System.Drawing.Point(276, 130);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(92, 25);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Agregar";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // tbNCopias
            // 
            this.tbNCopias.Location = new System.Drawing.Point(175, 74);
            this.tbNCopias.Name = "tbNCopias";
            this.tbNCopias.Size = new System.Drawing.Size(145, 20);
            this.tbNCopias.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numero de copias a agregar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Introduce el ID del libro:";
            // 
            // tbIdBook
            // 
            this.tbIdBook.Location = new System.Drawing.Point(151, 37);
            this.tbIdBook.Name = "tbIdBook";
            this.tbIdBook.Size = new System.Drawing.Size(169, 20);
            this.tbIdBook.TabIndex = 8;
            this.tbIdBook.TextChanged += new System.EventHandler(this.tbIdBook_TextChanged);
            // 
            // ArriboDeLibrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 180);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIdBook);
            this.Controls.Add(this.tbNCopias);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ArriboDeLibrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arribo De Libros";
            ((System.ComponentModel.ISupportInitialize)(this.tbNCopias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.NumericUpDown tbNCopias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdBook;
    }
}