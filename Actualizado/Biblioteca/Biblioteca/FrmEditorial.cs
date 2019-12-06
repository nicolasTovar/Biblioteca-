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
    public partial class FrmEditorial : Form
    {
        DataSet data = new DataSet();
        Dato dato = new Dato();
        SqlDataAdapter adptador = new SqlDataAdapter();
        private static FrmEditorial editorial;
        private FrmEditorial()
        {
            InitializeComponent();
        }
        public static FrmEditorial Conexion()
        {
            if (editorial == null)
            {
                editorial = new FrmEditorial();
            }
            return editorial;
        }
        private void FrmEditorial_Load(object sender, EventArgs e)
        {
            Modificar();
        }
        public void Modificar()
        {
            adptador = dato.seleccionarE();
            adptador.Fill(data,"Editorial");
            this.dgBiblioteca.DataSource = data.Tables[0].DefaultView;
            this.dgBiblioteca.Columns[0].HeaderText = "Código del editorial";
            this.dgBiblioteca.Columns[1].HeaderText = "Nombre del editorial";
        }
        public static void Cambiar()
        {
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder actualizar = new SqlCommandBuilder(adptador);
            adptador.Update(data, "Editorial");
            MessageBox.Show("Actualizado....", "Editorial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            data.Clear();
            Modificar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
