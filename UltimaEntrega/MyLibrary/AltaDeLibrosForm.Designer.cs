
namespace MyLibrary
{
    partial class AltaDeLibrosForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.tbEditorial = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.TbID = new System.Windows.Forms.TextBox();
            this.tbEdicion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Edición";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID Editorial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Autor";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(174, 29);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(33, 13);
            this.labelid.TabIndex = 15;
            this.labelid.Text = "Titulo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(502, 138);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(421, 138);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(46, 96);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(91, 20);
            this.tbAño.TabIndex = 4;
            this.tbAño.TextChanged += new System.EventHandler(this.tbAño_TextChanged);
            // 
            // tbEditorial
            // 
            this.tbEditorial.Location = new System.Drawing.Point(405, 45);
            this.tbEditorial.Name = "tbEditorial";
            this.tbEditorial.Size = new System.Drawing.Size(91, 20);
            this.tbEditorial.TabIndex = 5;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(308, 45);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(91, 20);
            this.tbAutor.TabIndex = 6;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(177, 45);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(125, 20);
            this.tbTitulo.TabIndex = 7;
            // 
            // TbID
            // 
            this.TbID.Location = new System.Drawing.Point(46, 45);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(125, 20);
            this.TbID.TabIndex = 8;
            // 
            // tbEdicion
            // 
            this.tbEdicion.Location = new System.Drawing.Point(502, 45);
            this.tbEdicion.Name = "tbEdicion";
            this.tbEdicion.Size = new System.Drawing.Size(91, 20);
            this.tbEdicion.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID";
            // 
            // AltaDeLibrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 204);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbEdicion);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.tbEditorial);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.TbID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AltaDeLibrosForm";
            this.Text = "AltaDeLibrosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.TextBox tbEditorial;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.TextBox tbEdicion;
        private System.Windows.Forms.Label label6;
    }
}