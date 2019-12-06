using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biblioteca
{
    public partial class FrmBibliotecaSena : Form
    {
        DataSet data = new DataSet();
        Dato dato = new Dato();
        SqlDataAdapter adptador = new SqlDataAdapter();
        private static FrmBibliotecaSena biblioteca;
        private FrmBibliotecaSena()
        {
            InitializeComponent();
        }
        public static FrmBibliotecaSena Conexion()
        {
            if (biblioteca == null)
            {
                biblioteca = new FrmBibliotecaSena();
            }
            return biblioteca;
        }


        private void FrmBibliotecaSena_Load(object sender, EventArgs e)
        {
            dato.obtenerNombres(ref cbNombres);
            this.dgBiblioteca.DataSource = dato.mostrarTablaL().Tables[0].DefaultView;
            this.dgBiblioteca.Columns[0].HeaderText = "Código del libro";
            this.dgBiblioteca.Columns[1].HeaderText = "Nombre del libro";
            this.dgBiblioteca.Columns[2].HeaderText = "Cantidad de páginas";
            this.dgBiblioteca.Columns[3].HeaderText = "Código del editorial";

            lstLibros.Items.Add("codLib");
            lstLibros.Items.Add("nomLib");
            lstLibros.Items.Add("nomAutor");
            lstLibros.Items.Add("nomEditorial");
            lstLibros.Items.Add("codEdi");
            lstLibros.Items.Add("canPag");
        }

        private void btnTeditorial_Click(object sender, EventArgs e)
        {
            this.dgBiblioteca.DataSource = dato.mostrarTablaE().Tables[0].DefaultView;
            this.dgBiblioteca.Columns[0].HeaderText = "Código del editorial";
            this.dgBiblioteca.Columns[1].HeaderText = "Nombre del editorial";


        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            this.dgBiblioteca.DataSource = dato.mostrarTablaL().Tables[0].DefaultView;
            this.dgBiblioteca.Columns[0].HeaderText = "Código del libro";
            this.dgBiblioteca.Columns[1].HeaderText = "Nombre del libro";
            this.dgBiblioteca.Columns[2].HeaderText = "Cantidad de páginas";
            this.dgBiblioteca.Columns[3].HeaderText = "Código del editorial";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.dgBiblioteca.DataSource = dato.mostrarInicial(txtInicial.Text.Trim().ToString()).Tables[0].DefaultView;
        }

        private void cbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgBiblioteca.DataSource = dato.mostrarC(cbNombres.Text.ToString()).Tables[0].DefaultView;
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            this.dgBiblioteca.DataSource = dato.mostrarAsc(lstLibros.Text.ToString()).Tables[0].DefaultView;
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            this.dgBiblioteca.DataSource = dato.mostrarDes(lstLibros.Text.ToString()).Tables[0].DefaultView;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            this.dgBiblioteca.DataSource = dato.mostrarTablaL().Tables[0].DefaultView;
        }
    }
}
