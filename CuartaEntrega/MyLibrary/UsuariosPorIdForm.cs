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
    public partial class UsuariosPorIdForm : Form
    {
        private Library library;
        public UsuariosPorIdForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void UsuariosPorIdForm_Load(object sender, EventArgs e)
        {
            dgvUsuariosPorId.DataSource = library.UsuariosPorId();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
