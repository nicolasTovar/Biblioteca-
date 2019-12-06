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
    public partial class FrmLibroC : Form
    {
        Dato dato = new Dato();
        SqlCommand comando = new SqlCommand();
        private static FrmLibroC libro;
        private FrmLibroC()
        {
            InitializeComponent();
        }
        public static FrmLibroC mostrarL()
        {
            if (libro == null)
            {
                libro = new FrmLibroC();
            }
            return libro;
        }
        private void FrmLibroC_Load(object sender, EventArgs e)
        {

           
            dato.mostrarEditoriales(cbEditorial);
            lsbLibro.Items.Clear();
            dato.Libros(lsbLibro);
            botonF();
            botonInicial();
            mostrar();
            btnActualizar.Enabled = false;
            tex();

        }
        public void tex()
        {
            txtCodigoE.Enabled = false;
            txtNombre.Enabled = false;
            cbEditorial.Enabled = false;
        }
        public void mostrar()
        {

            dato.Libros(lsbLibro);
            this.txtNombre.Select();
        }
        public void botonInicial()
        {
            btnExcluir.Enabled = true;
            btnIncluir.Enabled = true;
            btnSalvar.Enabled = false;
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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            cbEditorial.Enabled = true;
            BotonSalva();
            txtNombre.Focus();

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (Dato.bandera == "Actualizado")
            {
                lsbLibro.Items.Clear();
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
                    if ((MessageBox.Show("Está seguro de guardar", "Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        Dato.bandera = "Añadir";
                        dato.añadirLibro(txtNombre.Text,Convert.ToInt32(cbEditorial.SelectedValue));
                        lsbLibro.Items.Clear();
                        mostrar();
                        txtNombre.Clear();
                 
                    }
                    else
                    {
                        MessageBox.Show("Datos no guardado", "Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                 }
                else
                {
                    MessageBox.Show("Llenar los campos", "Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           
        }
        public void modificar()
        {
            if (txtNombre.Text.Length > 0)
            {

                Dato.bandera = "Actualizar1";
                dato.modificarL((txtNombre.Text), Convert.ToInt32(txtCodigoE.Text));
                cbEditorial.Enabled = true;
                lsbLibro.Items.Clear();
                mostrar();
                botonInicial();


            }
            else
            {
                MessageBox.Show("Debe seleccionar ", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cbEditorial.Items.Clear();
            cbEditorial.Refresh();
            dato.mostrarEditoriales(cbEditorial);

        }
        public void combo()
        {
            

        }

        private void lsbLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            int numero=0;
            comando = dato.mostrarDatos(lsbLibro.SelectedItem.ToString());
          
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtNombre.Text = leer["nomLib"].ToString();
                txtCodigoE.Text = leer["codLib"].ToString();
                numero = Convert.ToInt32(leer["codE"]);
            }
            leer.Close();
            

            SqlCommand comando2 = new SqlCommand();
            comando2 = dato.mostrarCombo(numero);
            SqlDataReader leer2 = comando2.ExecuteReader();
            if (leer2.Read())
            {

                cbEditorial.Text = leer2["nomEdi"].ToString();
            }
            leer2.Close();



        }
        public void limpiar()
        {
            txtNombre.Clear();
            cbEditorial.Items.Clear();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = true;
            txtNombre.Enabled = true;
            modificar();
            btnSalvar.Enabled = true;
            BotonSalva();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        public void eliminar()
        {
            if (txtNombre.Text.Length > 0)
            {

                Dato.bandera = "Eliminar";
                dato.eliminarL((txtNombre.Text), Convert.ToInt32(txtCodigoE.Text));
                limpiar();
               
                lsbLibro.Items.Clear();
            
                mostrar();

             

            }
            else
            {
                MessageBox.Show("Debe seleccionar", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
