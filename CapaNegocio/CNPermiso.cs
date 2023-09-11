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
    public class CNPermiso
    {
        private CDPermiso objcdPermiso = new CDPermiso();

        public List<Permiso> Listar(int idUsuario)
        {
            return objcdPermiso.Listar(idUsuario);
        }
    }
}
