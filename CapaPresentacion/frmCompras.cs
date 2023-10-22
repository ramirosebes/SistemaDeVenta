using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using CapaPresentacion.Modales;

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;

        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            comboBoxTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            comboBoxTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            comboBoxTipoDocumento.DisplayMember = "Texto";
            comboBoxTipoDocumento.ValueMember = "Valor";
            comboBoxTipoDocumento.SelectedIndex = 0;

            textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            textBoxIdProveedor.Text = "0";
            textBoxIdProducto.Text = "0";
        }

        private void buttonBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    textBoxIdProveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    textBoxDocumentoProveedor.Text = modal._Proveedor.Documento;
                    textBoxNombreProveedor.Text = modal._Proveedor.RazonSocial; //Cambiar textboxNombreProveedor por textboxRazonSocialProveedor
                }
                else
                {
                    textBoxDocumentoProveedor.Select();
                }
            }
        }

        private void buttonBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    textBoxIdProducto.Text = modal._Producto.IdProducto.ToString();
                    textBoxCodigoProducto.Text = modal._Producto.Codigo;
                    textBoxProducto.Text = modal._Producto.Nombre;
                    textBoxPrecioCompra.Select();
                }
                else
                {
                    textBoxCodigoProducto.Select();
                }
            }
        }
    }
}
