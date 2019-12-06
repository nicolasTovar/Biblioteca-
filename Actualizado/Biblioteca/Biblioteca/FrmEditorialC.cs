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
    public partial class FrmEditorialC : Form
    {
        Dato dato = new Dato();
        SqlCommand comanda = new SqlCommand();
        private static FrmEditorialC editorial;
     
        private FrmEditorialC()
        {
            InitializeComponent();
        }
        public static FrmEditorialC mostrarE()
        {
            if (editorial == null)
            {
                editorial = new FrmEditorialC();

            }
            return editorial;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
         
        }
        public void mostrar()
        {

            dato.mostrarLista(lsbEditorial);
            this.txtNombre.Select();
        }
        private void FrmEditorialC_Load(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            botonF();
            botonInicial();
            mostrar();
            
            
      
        }
        
        private void lsbEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            comanda = dato.Nombres(lsbEditorial.SelectedItem.ToString());
            SqlDataReader leer = comanda.ExecuteReader();
            if (leer.Read())
            {
                txtCodigoE.Text = leer["codEdi"].ToString();
                txtNombre.Text = leer["nomEdi"].ToString();
            }
            leer.Close();

        }

        public void BotonSalva()
        {
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnIncluir.Enabled = false;
        }
        public void BotonIncluir()
        {
            btnIncluir.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            
        }
        public void BotonExcluir()
        {
            btnExcluir.Enabled = true;
            btnIncluir.Enabled = false;
            btnSalvar.Enabled = false;
        }
        public void botonT()
        {
          
            btnN.Enabled = true;
        }
        public void botonF()
        {
        
            btnN.Enabled = true;
        }
        public void botonInicial()
        {
            btnExcluir.Enabled = true;
            btnIncluir.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtCodigoE.Clear();
            txtNombre.Clear();
            BotonSalva();
            txtNombre.Focus();
     

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Dato.bandera=="Actualizado")
            {
              
                modificar();
                txtNombre.Clear();
            
            }
            else
            {
                añadir();
            }
            botonInicial();
        }
        public void añadir()
        {
            if (txtNombre.Text.Length > 0)
            {
                if ((MessageBox.Show("Está seguro de guardar", "Editoriales", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                 {
              
                    Dato.bandera = "Añadir";
                    dato.añadirEditorial(txtNombre.Text);
                    lsbEditorial.Items.Clear();
                    mostrar();
                    txtNombre.Clear();
                }
                else
                {
                    MessageBox.Show("Llenar los campos", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Datos no guardado", "Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
         
        }
        public void modificar()
        {
            if (txtNombre.Text.Length > 0)
            {

                Dato.bandera = "Actualizar1";
                dato.modificarE((txtNombre.Text), Convert.ToInt32(txtCodigoE.Text));
                lsbEditorial.Items.Clear();
                mostrar();
                botonInicial();


            }
            else {
                MessageBox.Show("Debe seleccionar ", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            btnSalvar.Enabled = true;
            
            modificar();
            BotonSalva();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        public void Eliminar()
        {
            if (txtNombre.Text.Length > 0)
            {

                Dato.bandera = "Eliminar";
                dato.eliminarE((txtNombre.Text), Convert.ToInt32(txtCodigoE.Text));
                txtNombre.Clear();
            
                lsbEditorial.Items.Clear();
                mostrar();
              

            }
            else
            {
                MessageBox.Show("Debe seleccionar", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
