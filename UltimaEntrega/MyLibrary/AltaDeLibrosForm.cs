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
    public partial class AltaDeLibrosForm : Form
    {
        private Library library;
        public AltaDeLibrosForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            int id = Convert.ToInt32((string)TbID.Text);
            int copies = Convert.ToInt32(0);
            string title = (string)tbTitulo.Text;
            string author = (string)tbAutor.Text;
            int editorial_id = Convert.ToInt32((string)tbEditorial.Text); 
            int edition = Convert.ToInt32((string)tbEdicion.Text);
            int year = Convert.ToInt32((string)tbAño.Text);

            if (!library.ValidarBookId(id)) // library.ValidarEditorialId(editorial_id))
            {
                if (library.ValidarEditorialId(editorial_id))
                {
                    library.AltaDeLibro(id, copies, title, author, editorial_id, edition, year);
                    MessageBox.Show($"{id} {title} {author}  ha sido agregado",
                                  "Confirmación",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show($"No existe el editorial id: {editorial_id}",
                             "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                MessageBox.Show($"Ya existe un libro registrado con el ID: {id}",
                               "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    Close();
            }
        }
        private void tbAño_TextChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
        }
    }
}
