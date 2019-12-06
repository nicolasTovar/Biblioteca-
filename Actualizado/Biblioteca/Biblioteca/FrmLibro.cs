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
    public partial class FrmLibro : Form
    {
        DataSet data = new DataSet();
        Dato dato = new Dato();
        SqlDataAdapter adptador = new SqlDataAdapter();
        private static FrmLibro libro;
        private FrmLibro()
        {
            InitializeComponent();
        }
        public static FrmLibro conexion()
        {
            if (libro == null)
            {
                libro = new FrmLibro();
            }
            return libro;
        }
        private void FrmLibro_Load(object sender, EventArgs e)
        {
           
            Modificar();
        }
        public void Modificar()
        {
            adptador = dato.seleccionarL();
            adptador.Fill(data,"Libro");
            this.dgBiblioteca.DataSource = data.Tables[0].DefaultView;
            this.dgBiblioteca.Columns[0].HeaderText = "Código del libro";
            this.dgBiblioteca.Columns[1].HeaderText = "Nombre del libro";
            this.dgBiblioteca.Columns[2].HeaderText = "Cantidad de páginas";
            this.dgBiblioteca.Columns[3].HeaderText = "Código del editorial";
 
       
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder actualizar = new SqlCommandBuilder(adptador);
            adptador.Update(data, "Libro");
            MessageBox.Show("Actualizado....", "Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            data.Clear();
            Modificar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
