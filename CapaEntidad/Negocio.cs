using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Negocio
    {
        private int idNegocio;
        private string nombre;
        private string ruc;
        private string direccion;

        public int IdNegocio { get; set; }
        public string Nombre { get; set; }
        public string RUC { get; set; }
        public string Direccion { get; set; }
    }
}
