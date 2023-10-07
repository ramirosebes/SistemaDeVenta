using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        //Desktop
        // Data Source=DESKTOP-RAMIRO;Initial Catalog=DB_SERVICIO_DE_COLOR;Integrated Security=True
        // Notebook
        // Data Source=NOTEBOOK-RAMIRO;Initial Catalog=DB_SERVICIO_DE_COLOR;Integrated Security=True

        public static string cadena = ConfigurationManager.ConnectionStrings["cadenaConexion"].ToString();
    }
}

