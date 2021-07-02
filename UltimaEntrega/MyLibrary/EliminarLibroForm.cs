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
    public partial class EliminarLibroForm : Form
    {
        Library library;
        public EliminarLibroForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            int id = Convert.ToInt32((string)TbIdBook.Text);
            int copias = (int)nudCopias.Value;
            if (library.ValidarBookId(id))
            {
                if(library.ValidarCopias(id, copias))
                {
                    library.EliminarCopias(id, copias);
                    MessageBox.Show($"Se han eliminado {copias} del libro con ID: {id}",
                               "Confirmación",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show($"El numero de copias a eliminar es mayor al numero de copias disponible",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show($"El libro con ID:{id} no está registrado",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

        }

        private void nudCopias_ValueChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true; 
        }
    }
}
