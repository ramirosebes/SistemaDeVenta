using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace CapaPresentacion
{
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(textBoxBusqueda.Text);

            if(oCompra.IdCompra != 0)
            {
                textBoxNumeroDocumento.Text = oCompra.NumeroDocumento;
                textBoxFecha.Text = oCompra.FechaRegistro;
                textBoxTipoDocumento.Text = oCompra.TipoDocumento;
                textBoxUsuario.Text = oCompra.oUsuario.NombreCompleto;
                textBoxDocumentoProveedor.Text = oCompra.oProveedor.Documento;
                textBoxRazonSocial.Text = oCompra.oProveedor.RazonSocial; //textBoxNombreProveedor

                dataGridViewData.Rows.Clear();
                foreach (DetalleCompra dc in oCompra.oDetalleCompra)
                {
                    dataGridViewData.Rows.Add(new object[] { dc.oProducto.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });
                }

                textBoxMontoTotal.Text = oCompra.MontoTotal.ToString("0.00");
            }
        }

        private void buttonLimpiarBuscardor_Click(object sender, EventArgs e)
        {
            textBoxFecha.Clear();
            textBoxTipoDocumento.Clear();
            textBoxUsuario.Clear();
            textBoxDocumentoProveedor.Clear();
            textBoxRazonSocial.Clear();

            dataGridViewData.Rows.Clear();
            textBoxMontoTotal.Text = "0.00";
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            if (textBoxTipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string textoHTML = Properties.Resources.PlantillaCompra.ToString();
            Negocio oDatos = new CN_Negocio().ObtenerDatos();

            textoHTML = textoHTML.Replace("@nombrenegocio", oDatos.Nombre.ToUpper()); //@nombreNegocio
            textoHTML = textoHTML.Replace("@@docnegocio", oDatos.RUC); //@documentoNegocio
            textoHTML = textoHTML.Replace("@direcnegocio", oDatos.Direccion); //direccionNegocio

            textoHTML = textoHTML.Replace("@tipodocumento", textBoxTipoDocumento.Text.ToUpper());
            textoHTML = textoHTML.Replace("@numerodocumento", textBoxNumeroDocumento.Text);

            textoHTML = textoHTML.Replace("@docproveedor", textBoxDocumentoProveedor.Text);
            textoHTML = textoHTML.Replace("@nombreproveedor", textBoxRazonSocial.Text);
            textoHTML = textoHTML.Replace("@fecharegistro", textBoxFecha.Text);
            textoHTML = textoHTML.Replace("@usuarioregistro", textBoxUsuario.Text);

            string filas = string.Empty;
            
            foreach (DataGridViewRow row in dataGridViewData.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            textoHTML = textoHTML.Replace("@filas", filas);
            textoHTML = textoHTML.Replace("@montototal", textBoxMontoTotal.Text);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Compra_{0}.pdf", textBoxNumeroDocumento.Text);
            saveFile.Filter = "Pdf Files|*.pdf";

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document pdfDocumento = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDocumento, stream);
                    pdfDocumento.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDocumento.Left, pdfDocumento.GetTop(51));
                        pdfDocumento.Add(img);
                    }

                    using (StringReader sr = new StringReader(textoHTML))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDocumento, sr);
                    }

                    pdfDocumento.Close();
                    stream.Close();
                    MessageBox.Show("Documento generado", "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
