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
    public partial class SolicitarPrestamoForm : Form
    {
        private Library library;
        public SolicitarPrestamoForm(Library library)
        {
            this.library = library;
            InitializeComponent();
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "Book_Id";
            cmbBooks.DataSource = library.GetAllBooks();


        }
        private void SolicitarPrestamoForm_Load(object sender, EventArgs e)
        {
            cmbUser.ValueMember = "Id";
            cmbUser.DisplayMember = "Full_Name";
            cmbUser.DataSource = library.UsuariosPorId();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cmbBooks.SelectedValue;
            btnPrestar.Enabled = library.ValidarDisponibilidad(id);
        }
    }
}
