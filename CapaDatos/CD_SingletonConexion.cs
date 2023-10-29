using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_SingletonConexion
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["cadenaConexion"].ToString();
        private static SqlConnection conexion;

        private CD_SingletonConexion() { }

        public static SqlConnection ObtenerConexion()
        {
            if (conexion == null)
            {
                conexion = new SqlConnection(connectionString);
            }

            //Puede omitirse esta parte si se abre desde el controlador
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
            else
            {
                //No hace falta esta parte
                conexion.Close();
            }

            return conexion;
        }
    }
}
