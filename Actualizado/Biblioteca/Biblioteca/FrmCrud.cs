using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmCrud : Form
    {
        FrmEditorialC editorial;
        FrmLibroC libro;
        public FrmCrud()
        {
            InitializeComponent();
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsEditorial_Click(object sender, EventArgs e)
        {
            editorial = FrmEditorialC.mostrarE();
            editorial.MdiParent = this;
            editorial.Show();
        }

        private void tsbCrudeditorial_Click(object sender, EventArgs e)
        {
            editorial = FrmEditorialC.mostrarE();
            editorial.MdiParent = this;
            editorial.Show();
        }

        private void tsbCrudlibro_Click(object sender, EventArgs e)
        {
            libro = FrmLibroC.mostrarL();
            libro.MdiParent = this;
            libro.Show();
        }

        private void tsLibro_Click(object sender, EventArgs e)
        {
            libro = FrmLibroC.mostrarL();
            libro.MdiParent = this;
            libro.Show();
        }
    }
}
