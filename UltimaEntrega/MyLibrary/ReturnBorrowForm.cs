﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class ReturnBorrowForm : Form
    {
        private Library library;
        public ReturnBorrowForm(Library library)
        {
            InitializeComponent();
            this.library = library;
            cmbBorrowedBooks.DisplayMember = "Title";
            cmbBorrowedBooks.ValueMember = "Book_Id";
            cmbBorrowedBooks.DataSource = library.GetBorrowedBooks();

        }

        private void cmbBorrowedBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cmbBorrowedBooks.SelectedValue;
            cmbUsersWithBorrows.DisplayMember = "Full_Name";
            cmbUsersWithBorrows.ValueMember = "User_Id";
            cmbUsersWithBorrows.DataSource = library.GetBorrowsByBook(id);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteBorrow_Click(object sender, EventArgs e)
        {
            int user_id = (int)cmbUsersWithBorrows.SelectedValue;
            int book_id = (int)cmbBorrowedBooks.SelectedValue;

            switch (MessageBox.Show($"Se devolverá el libro {cmbBorrowedBooks.Text} por el usuario {cmbUsersWithBorrows.Text}, ¿desea continuar?",
                "Confirmación",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information))
            {
                case DialogResult.OK:
                    library.ReturnBook(user_id, book_id);

                    MessageBox.Show("Devolución realizada con éxito",
                       "Confirmación",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    Close();
                    break;

                default:
                    MessageBox.Show("La devolución no se ha realizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }


        }
    }
}
