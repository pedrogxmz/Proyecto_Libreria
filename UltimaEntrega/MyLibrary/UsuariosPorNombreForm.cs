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
    public partial class UsuariosPorNombreForm : Form
    {
        private Library library;
        public UsuariosPorNombreForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void UsuariosPorNombreForm_Load(object sender, EventArgs e)
        {
            dgvUsuariosPorNombre.DataSource = library.UsuariosPorNombre();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
