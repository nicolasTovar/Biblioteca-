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
    public partial class FrmBiblioteca : Form
    {
        FrmBibliotecaSena biblioteca;
        FrmEditorial editorial;
        FrmLibro libro;
        public FrmBiblioteca()
        {
            InitializeComponent();
        }
 
        private void tsSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBiblioteca_Click(object sender, EventArgs e)
        {


            biblioteca = FrmBibliotecaSena.Conexion();
            biblioteca.MdiParent = this;
            biblioteca.Show();
        }

        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {
          
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorial = FrmEditorial.Conexion();
            editorial.MdiParent = this;
            editorial.Show();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            libro = FrmLibro.conexion();
            libro.MdiParent = this;
            libro.Show();
        }

        private void tsbBiblioteca_Click(object sender, EventArgs e)
        {
            biblioteca = FrmBibliotecaSena.Conexion();
            biblioteca.MdiParent = this;
            biblioteca.Show();
        }

        private void tsbEditorial_Click(object sender, EventArgs e)
        {
            editorial = FrmEditorial.Conexion();
            editorial.MdiParent = this;
            editorial.Show();
        }

        private void tsbLibro_Click(object sender, EventArgs e)
        {
            libro = FrmLibro.conexion();
            libro.MdiParent = this;
            libro.Show();
        }

        private void msBiblioteca_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsBibliotecaSena_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
