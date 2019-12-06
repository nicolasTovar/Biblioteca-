using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biblioteca
{
    class Dato

    {
        public static string bandera="Actualizar";
        public static int control;
        public DataSet mostrarInicial(string nombre)
        {
            SqlConnection conectar = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Inicial",conectar);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@nombre", SqlDbType.Text);
            parametro.Value = nombre;
            comando.Parameters.Add(parametro);  
            SqlDataAdapter adptador = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adptador.Fill(data, "Libro");
            //conectar.Close();
            return data;

        }
        public SqlCommand Seleccionar(string nombre)
        {
            SqlConnection cone = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Añadir",cone);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@nombre", SqlDbType.Text).Value = nombre;
           return comando;
        }
        public DataSet mostrarTablaE()
        {
            SqlConnection conectar = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Meditorial", conectar);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adptador = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adptador.Fill(data, "Editorial");
            //    conectar.Close();
            return data;
        }
        public DataSet mostrarTablaL()
        {
            SqlConnection conectar = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando2 = new SqlCommand("pa_Mlibro", conectar);
            comando2.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adptador2 = new SqlDataAdapter(comando2);
            DataSet data = new DataSet();
            adptador2.Fill(data, "Libro");
           // conectar.Close();
            return data;
        }
        public DataSet mostrarC(string nombre)
        {
            SqlConnection conex = ConexionBaseDatos.ObtenerConexion();
            DataSet data = new DataSet();
          
                SqlCommand comando = new SqlCommand("pa_Comact", conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter parametro = new SqlParameter("@nombre", SqlDbType.Text);
                comando.Parameters.Add(parametro).Value = nombre;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(data, "Libro");
            //conex.Close();
            return data;
           
        }
        
        public DataSet obtenerNombres(ref ComboBox cb)
        {
            SqlConnection conex = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Nombres", conex);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cb.Items.Add(leer["nomEdi"]).ToString();
            }
            DataSet data = new DataSet();
            //leer.Close();
            return data;
        }
        public DataSet obtenerCodigo(string nombre)
        {
            SqlConnection conex = ConexionBaseDatos.ObtenerConexion();
            DataSet data = new DataSet();

            SqlCommand comando = new SqlCommand("pa_Comact", conex);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@nombre", SqlDbType.Text);
            comando.Parameters.Add(parametro).Value = nombre;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(data, "Libro");
            //conex.Close();
            return data;
        }
        public DataSet obtenerCodigoN(string nombre,int codigo)
        {
            SqlConnection conex = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Modificar", conex);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@nombre", SqlDbType.Text);
            comando.Parameters.Add(parametro).Value = nombre;
            SqlParameter parametro2 = new SqlParameter("@codigo", SqlDbType.Int);
            comando.Parameters.Add(parametro2).Value = codigo;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adaptador.Fill(data, "Editorial");
            //conex.Close();
            return data;
        }
        public DataSet añadirEditorial(string nombre)
        {
          
                SqlConnection conex = ConexionBaseDatos.ObtenerConexion();
                SqlCommand comando = new SqlCommand("pa_Añadir", conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter parametro = new SqlParameter("@nombre", SqlDbType.Text);
                comando.Parameters.Add(parametro).Value = nombre;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adaptador.Fill(data, "Editorial");
    
            //conex.Close();
            return data;

        }

        public DataSet obtener()
        {
            SqlConnection conex = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_EditorialN", conex);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adapter.Fill(data, "Editorial");
            //conex.Close();
            return data;
        }
        public SqlDataAdapter seleccionarE()
        {
            SqlConnection conex = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Ceditorial", conex);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            return adaptador;
        }
        public SqlDataAdapter seleccionarL()
        {
            SqlConnection conex = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Clibro", conex);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            return adaptador;
        }
        public DataSet mostrarDes(string descendente)
        {

            SqlConnection conex = ConexionBaseDatos.ObtenerConexion();
            DataSet data = new DataSet();
            if (descendente == "codLib")
            {
                SqlCommand comando = new SqlCommand("pa_DcodLib", conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(data, "Libro");
            }
            else if (descendente == "nomLib")
            {
                SqlCommand comando = new SqlCommand("pa_DnomLib", conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(data, "Libro");
            }
            else if (descendente == "nomAutor")
            {
                SqlCommand comando = new SqlCommand("pa_DnomAutor", conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(data, "Libro");
            }
            if (descendente == "nomEditorial")
            {
                SqlCommand comando = new SqlCommand("pa_DnomEditorial", conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(data, "Libro");
            }
            else if (descendente == "codEdi")
            {
                SqlCommand comando = new SqlCommand("pa_DcodEdi", conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(data, "Libro");
            }
            else if (descendente== "canPag")
            {
                SqlCommand comando = new SqlCommand("pa_DcanPag",conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(data, "Libro");
            }
           conex.Close();
            return data;
        }
        public DataSet mostrarAsc(string ascendente)
        {


            SqlConnection conex = ConexionBaseDatos.ObtenerConexion();
            DataSet data = new DataSet();
            if (ascendente == "codLib")
            {
                SqlCommand comando = new SqlCommand("pa_AcodLib", conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(data, "Libro");
            }
            else if (ascendente == "nomLib")
            {
                SqlCommand comando = new SqlCommand("pa_AnomLib", conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(data, "Libro");
            }
            else if (ascendente == "nomAutor")
            {
                SqlCommand comando = new SqlCommand("pa_AnomAutor", conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(data, "Libro");
            }
            if (ascendente == "nomEditorial")
            {
                SqlCommand comando = new SqlCommand("pa_AnomEditorial", conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(data, "Libro");
            }
            else if (ascendente == "codEdi")
            {
                SqlCommand comando = new SqlCommand("pa_AodEdi", conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(data, "Libro");
            }
            else if (ascendente== "canPag")
            {
                SqlCommand comando = new SqlCommand("pa_AcanPag",conex);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(data, "Libro");
            }
   
            conex.Close();
            return data;
        }
        public void mostrarLista(ListBox lista)
        {
            SqlConnection conexion = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Editorialm", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                lista.Items.Add(leer["nomEdi"]).ToString();
            }
            leer.Close();
        }
        public SqlCommand Nombres(string nombre)
        {
            SqlConnection conexion = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_mostrarNombres", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@nombre", SqlDbType.Text);
            comando.Parameters.Add(parametro).Value = nombre;

            return comando;
        }
        public DataSet modificarE(string nombre, int codigo)
        {
            SqlConnection conexion = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Modificar", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@Nombre", SqlDbType.Text);
            comando.Parameters.Add(parametro).Value = nombre;
            SqlParameter parameter = new SqlParameter("@codigo", SqlDbType.Int);
            comando.Parameters.Add(parameter).Value = codigo;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataSet set = new DataSet();
            adaptador.Fill(set, "Editorial");
            //conexion.Close();
            return set;
        }
        public void eliminarE(string nombre, int codigo)
        {
            SqlConnection conexion = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Eliminar", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@nombre", SqlDbType.Text);
            comando.Parameters.Add(parametro).Value = nombre;
            SqlParameter parameter = new SqlParameter("@codigo", SqlDbType.Int);
            comando.Parameters.Add(parameter).Value = codigo;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet set = new DataSet();
            adapter.Fill(set, "Editorial");

        }
        //********************************************************************************
        public void Libros(ListBox lista)
        {
            SqlConnection conexion = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_NLibro", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                lista.Items.Add(leer["nomLib"]).ToString();
            }
            leer.Close();
        }
        public DataSet modificarL(string nombre, int codigo)
        {
            SqlConnection conexion = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_ModificarL", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@Nombre", SqlDbType.Text);
            comando.Parameters.Add(parametro).Value = nombre;
            SqlParameter parameter = new SqlParameter("@codigo", SqlDbType.Int);
            comando.Parameters.Add(parameter).Value = codigo;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataSet set = new DataSet();
            adaptador.Fill(set, "Libro");
            //conexion.Close();
            return set;
        }
        public DataSet añadirLibro(string nombre,int codigo)
        {

            SqlConnection conex = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_AñadirLibro", conex);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@nombre", SqlDbType.Text);
            comando.Parameters.Add(parametro).Value = nombre;
            SqlParameter parametro2 = new SqlParameter("@codigo", SqlDbType.Int);
            comando.Parameters.Add(parametro2).Value = codigo;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adaptador.Fill(data, "Libro");

            //conex.Close();
            return data;

        }
        public void mostrarEditoriales(ComboBox nombres)
        {
            SqlConnection con = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Meditorial",con);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            data.Clear();
            adaptador.Fill(data, "Editorial");
            nombres.DataSource = data.Tables[0].DefaultView;
            nombres.DisplayMember = "nomEdi";
            nombres.ValueMember = "codEdi";
            nombres.SelectedIndex = -1;
           
        }
        public SqlCommand mostrarDatos(string nombre)
        {
            SqlConnection con = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Seleccionarlibros", con);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter("@nombre", SqlDbType.Text);
            comando.Parameters.Add(parameter).Value = nombre;
            return comando;
        }
        public SqlCommand mostrarCombo(int nombre)
        {
            SqlConnection con = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_comboE", con);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter("@numero", SqlDbType.Int);
            comando.Parameters.Add(parameter).Value = nombre;
            return comando;
        }
        public void eliminarL(string nombre, int codigo)
        {
            SqlConnection conexion = ConexionBaseDatos.ObtenerConexion();
            SqlCommand comando = new SqlCommand("pa_Eliminarl", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlParameter parametro = new SqlParameter("@nombre", SqlDbType.Text);
            comando.Parameters.Add(parametro).Value = nombre;
            SqlParameter parameter = new SqlParameter("@codigo", SqlDbType.Int);
            comando.Parameters.Add(parameter).Value = codigo;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet set = new DataSet();
            adapter.Fill(set, "Libro");

        }

    }
}
