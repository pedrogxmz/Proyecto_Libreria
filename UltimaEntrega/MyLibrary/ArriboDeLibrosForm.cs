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
    public partial class ArriboDeLibrosForm : Form
    {
        private Library library;
        public ArriboDeLibrosForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            btnAñadir.Enabled = false;
            int id = Convert.ToInt32((string)tbIdBook.Text);
            int copias = (int)tbNCopias.Value;
            if (library.ValidarBookId(id))
            {
                library.AgregarCopias(id, copias);
                MessageBox.Show($"Se han añadido {copias} del libro con ID: {id}",
                                "Confirmación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show($"El libro con ID:{id} no está registrado",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                Close();
            }

        }

    }
}

