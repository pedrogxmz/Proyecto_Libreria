using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteDb;

namespace MyLibrary
{
    public partial class MainForm : Form
    {
        private Library library;

        public MainForm()
        {
            InitializeComponent();
            library = new Library();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.Close();
            Close();
        }

        private void ordenadosPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosPorNombreForm Form = new UsuariosPorNombreForm(library);
            Form.ShowDialog();
        }

        private void ordenadosPorApellidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosPorApellidoForm Form = new UsuariosPorApellidoForm(library);
            Form.ShowDialog();
        }

        private void ordenadosPorIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosPorIdForm Form = new UsuariosPorIdForm(library);
            Form.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarUsuarioForm Form = new AgregarUsuarioForm(library);
            Form.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUsuarioForm Form = new EliminarUsuarioForm(library);
            Form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PendingBorrowForm Form = new PendingBorrowForm(library);
            Form.ShowDialog();
        }

        private void devolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBorrowForm Form = new ReturnBorrowForm(library);
            Form.ShowDialog();
        }

        private void AltaDeLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaDeLibrosForm Form = new AltaDeLibrosForm(library);
            Form.ShowDialog();
        }
    }
}
