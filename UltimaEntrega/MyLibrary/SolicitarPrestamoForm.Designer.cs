
namespace MyLibrary
{
    partial class SolicitarPrestamoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitarPrestamoForm));
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbBooks
            // 
            this.cmbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(76, 64);
            this.cmbBooks.MaxDropDownItems = 20;
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(371, 28);
            this.cmbBooks.TabIndex = 0;
            this.cmbBooks.SelectedIndexChanged += new System.EventHandler(this.cmbBooks_SelectedIndexChanged);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(12, 67);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(57, 24);
            this.lblBook.TabIndex = 2;
            this.lblBook.Text = "Libro:";
            // 
            // btnPrestar
            // 
            this.btnPrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestar.Location = new System.Drawing.Point(191, 460);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(99, 33);
            this.btnPrestar.TabIndex = 4;
            this.btnPrestar.Text = "Prestar";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(321, 460);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 33);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario:";
            // 
            // cmbUser
            // 
            this.cmbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(103, 231);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(344, 28);
            this.cmbUser.TabIndex = 6;
            // 
            // SolicitarPrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.cmbBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SolicitarPrestamoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Solicitar Prestamo";
            this.Load += new System.EventHandler(this.SolicitarPrestamoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUser;
    }
}