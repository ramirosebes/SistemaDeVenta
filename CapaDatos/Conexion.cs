using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        //Desktop
        // Data Source=DESKTOP-RAMIRO;Initial Catalog=DBSistemaVenta;Integrated Security=True
        // Notebook
        // Data Source=NOTEBOOK-RAMIRO;Initial Catalog=DBSistemaVenta;Integrated Security=True

        public static string cadena = ConfigurationManager.ConnectionStrings["cadenaConexion"].ToString();
    }
}
