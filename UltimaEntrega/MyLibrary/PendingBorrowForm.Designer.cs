
namespace MyLibrary
{
    partial class PendingBorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingBorrowForm));
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPendinBorrows = new System.Windows.Forms.DataGridView();
            this.Book_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendinBorrows)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(105, 18);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(173, 30);
            this.cmbUsers.TabIndex = 0;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // dgvPendinBorrows
            // 
            this.dgvPendinBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendinBorrows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_Id,
            this.title});
            this.dgvPendinBorrows.Location = new System.Drawing.Point(12, 69);
            this.dgvPendinBorrows.Name = "dgvPendinBorrows";
            this.dgvPendinBorrows.RowHeadersWidth = 51;
            this.dgvPendinBorrows.RowTemplate.Height = 24;
            this.dgvPendinBorrows.Size = new System.Drawing.Size(435, 337);
            this.dgvPendinBorrows.TabIndex = 2;
            // 
            // Book_Id
            // 
            this.Book_Id.DataPropertyName = "book_id";
            this.Book_Id.Frozen = true;
            this.Book_Id.HeaderText = "ID";
            this.Book_Id.MinimumWidth = 6;
            this.Book_Id.Name = "Book_Id";
            this.Book_Id.ReadOnly = true;
            this.Book_Id.Width = 125;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.title.DataPropertyName = "title";
            this.title.Frozen = true;
            this.title.HeaderText = "Título";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.title.Width = 382;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PendingBorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPendinBorrows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PendingBorrowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prestamos Pendientes";
            this.Load += new System.EventHandler(this.PendingBorrowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendinBorrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPendinBorrows;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
    }
}