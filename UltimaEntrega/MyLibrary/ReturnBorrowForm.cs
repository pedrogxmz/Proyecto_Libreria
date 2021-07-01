using System;
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

        private void ReturnBorrowForm_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BorrowedBooks_Click(object sender, EventArgs e)
        {

        }
    }
}
