using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteVenta
    {
        private string fechaRegistro;
        private string tipoDocumento;
        private string numeroDocumento;
        private string montoTotal;
        private string usuarioRegistro;
        private string documentoCliente;
        private string nombreCliente;
        private string codigoProducto;
        private string nombreProducto;
        private string categoria;
        private string precioVenta;
        private string cantidad;
        private string subTotal;

        public string FechaRegistro { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string MontoTotal { get; set; }
        public string UsuarioRegistro { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public string PrecioVenta { get; set; }
        public string Cantidad { get; set; }
        public string SubTotal { get; set; }
    }
}
