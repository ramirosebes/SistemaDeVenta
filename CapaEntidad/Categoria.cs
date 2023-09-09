using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public string fechaRegistro { get; set; }
    }
}
