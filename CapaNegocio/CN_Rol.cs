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
    public class CN_Rol
    {
        private CD_Rol objcdRol = new CD_Rol();

        public List<Rol> Listar()
        {
            return objcdRol.Listar();
        }
    }
}
