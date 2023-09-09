using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string documento { get; set; }
        public string nombreCompleto { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public Rol oRol { get; set; }
        public bool estado { get; set; }
        public string fechaRegistro { get; set; }
    }
}
