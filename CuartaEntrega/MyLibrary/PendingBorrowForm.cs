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
    public partial class PendingBorrowForm : Form
    {
        private Library library;
        public PendingBorrowForm(Library library)
        {
            InitializeComponent();
            this.library = library;
            cmbUsers.DisplayMember = "Full_Name";
            cmbUsers.ValueMember = "User_Id";
            cmbUsers.DataSource = library.GetUsersWithBorrows();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cmbUsers.SelectedValue;
            dgvPendinBorrows.DataSource = library.PrestamosPendientes(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
