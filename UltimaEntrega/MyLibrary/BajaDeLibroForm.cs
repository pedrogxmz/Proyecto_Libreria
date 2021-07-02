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
    public partial class BajaDeLibroForm : Form
    {
        Library library;
        public BajaDeLibroForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbIdLibro_TextChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            int id = Convert.ToInt32((string)tbIdLibro.Text);
            if (library.ValidarBookId(id))
            {
                if (!library.ValidarPrestamosPorBookId(id))
                {
                    library.BajaDeLibro(id);
                    MessageBox.Show($"El libro con ID: {id} ha sido dado de baja",
                               "Confirmación",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"El libro con ID: {id} no puede ser dado de baja porque se encuentra en prestamo",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show($"El libro con ID: {id} no está registrado",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
