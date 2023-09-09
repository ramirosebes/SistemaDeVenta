using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNUsuario
    {
        private CDUsuario objectUsuario = new CDUsuario();

        public List<Usuario> Listar()
        {
            return objectUsuario.Listar();
        }
    }
}
