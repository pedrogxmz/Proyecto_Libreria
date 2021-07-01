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
    }
}
