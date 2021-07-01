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
    public partial class AgregarUsuarioForm : Form
    {
        private Library library;
        public AgregarUsuarioForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            string firstname = (string)TbNombre.Text;
            string lastname = (string)TbApellido.Text;
            int id = Convert.ToInt32((string)TbId.Text);

            if (!library.ValidarId(id))
            {
                library.AgregarUsuario(id, firstname, lastname);
                MessageBox.Show($"{id} {firstname} {lastname} ha sido agregado",
                               "Confirmación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show($"Ya existe un usuario registrado con el ID: {id}",
                               "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbApellido_TextChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
        }
    }
}
