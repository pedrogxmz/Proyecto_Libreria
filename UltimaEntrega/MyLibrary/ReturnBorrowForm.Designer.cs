
namespace MyLibrary
{
    partial class ReturnBorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBorrowForm));
            this.BorrowedBooks = new System.Windows.Forms.Label();
            this.cmbBorrowedBooks = new System.Windows.Forms.ComboBox();
            this.btnDeleteBorrow = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsersWithBorrows = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BorrowedBooks
            // 
            this.BorrowedBooks.AutoSize = true;
            this.BorrowedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowedBooks.Location = new System.Drawing.Point(12, 45);
            this.BorrowedBooks.Name = "BorrowedBooks";
            this.BorrowedBooks.Size = new System.Drawing.Size(57, 24);
            this.BorrowedBooks.TabIndex = 3;
            this.BorrowedBooks.Text = "Libro:";
            // 
            // cmbBorrowedBooks
            // 
            this.cmbBorrowedBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorrowedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBorrowedBooks.FormattingEnabled = true;
            this.cmbBorrowedBooks.Location = new System.Drawing.Point(75, 42);
            this.cmbBorrowedBooks.Name = "cmbBorrowedBooks";
            this.cmbBorrowedBooks.Size = new System.Drawing.Size(372, 30);
            this.cmbBorrowedBooks.TabIndex = 2;
            this.cmbBorrowedBooks.SelectedIndexChanged += new System.EventHandler(this.cmbBorrowedBooks_SelectedIndexChanged);
            // 
            // btnDeleteBorrow
            // 
            this.btnDeleteBorrow.Location = new System.Drawing.Point(75, 371);
            this.btnDeleteBorrow.Name = "btnDeleteBorrow";
            this.btnDeleteBorrow.Size = new System.Drawing.Size(117, 48);
            this.btnDeleteBorrow.TabIndex = 6;
            this.btnDeleteBorrow.Text = "Devolver Libro";
            this.btnDeleteBorrow.UseVisualStyleBackColor = true;
            this.btnDeleteBorrow.Click += new System.EventHandler(this.btnDeleteBorrow_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(330, 371);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(117, 48);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario:";
            // 
            // cmbUsersWithBorrows
            // 
            this.cmbUsersWithBorrows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsersWithBorrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsersWithBorrows.FormattingEnabled = true;
            this.cmbUsersWithBorrows.Location = new System.Drawing.Point(122, 108);
            this.cmbUsersWithBorrows.Name = "cmbUsersWithBorrows";
            this.cmbUsersWithBorrows.Size = new System.Drawing.Size(304, 30);
            this.cmbUsersWithBorrows.TabIndex = 9;
            // 
            // ReturnBorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsersWithBorrows);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnDeleteBorrow);
            this.Controls.Add(this.BorrowedBooks);
            this.Controls.Add(this.cmbBorrowedBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReturnBorrowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Devolver Préstamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BorrowedBooks;
        private System.Windows.Forms.ComboBox cmbBorrowedBooks;
        private System.Windows.Forms.Button btnDeleteBorrow;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsersWithBorrows;
    }
}