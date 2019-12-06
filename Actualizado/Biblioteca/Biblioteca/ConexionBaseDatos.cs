using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca
{
    class ConexionBaseDatos
    {
        private static SqlConnection conectar;
        private ConexionBaseDatos()
        {

        }
        public static SqlConnection ObtenerConexion()
        {
            if (conectar == null)
            {
                conectar = new SqlConnection(Properties.Settings.Default.biblioteca);
                conectar.Open();
            }
            return conectar;
        }
    }
}
