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
    public partial class EliminarUsuarioForm : Form
    {
        private Library library;
        public EliminarUsuarioForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            int id = Convert.ToInt32((string)TbId.Text);
            if (library.ValidarId(id))
            {
                if (!library.ValidarPrestamos(id))
                {
                    library.EliminarUsuario(id);
                    MessageBox.Show("Usuario Eliminado",
                                "Confirmación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    dgvPrestamos.DataSource = library.PrestamosPendientes(id);
                    MessageBox.Show($"El usuario con ID: {id} tiene libros en prestamo",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"No existe un usuario con ID: {id}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void TbId_TextChanged(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = true;
        }
    }
}
