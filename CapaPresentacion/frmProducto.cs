using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;

namespace CapaPresentacion
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No activo" });
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";
            comboBoxEstado.SelectedIndex = 0;

            List<Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listaCategoria)
            {
                comboBoxCategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            comboBoxCategoria.DisplayMember = "Texto";
            comboBoxCategoria.ValueMember = "Valor";
            comboBoxCategoria.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dataGridViewData.Columns)
            {
                if (columna.Visible == true && columna.Name != "buttonSeleccionar")
                {
                    comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";
            comboBoxBusqueda.SelectedIndex = 0;

            List<Producto> lista = new CN_Producto().Listar();

            foreach (Producto item in lista)
            {
                dataGridViewData.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No activo",
                });
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Producto obj = new Producto()
            {
                IdProducto = Convert.ToInt32(textBoxID.Text),
                Codigo = textBoxCodigo.Text,
                Nombre = textBoxNombre.Text,
                Descripcion = textBoxDescripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)comboBoxCategoria.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdProducto == 0)
            {
                int idGenerado = new CN_Producto().Registrar(obj, out mensaje);


                if (idGenerado != 0)
                {
                    dataGridViewData.Rows.Add(new object[] {
                        "",
                        idGenerado,
                        textBoxCodigo.Text,
                        textBoxNombre.Text,
                        textBoxDescripcion.Text,
                        ((OpcionCombo)comboBoxCategoria.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)comboBoxCategoria.SelectedItem).Texto.ToString(),
                        "0",
                        "0.00",
                        "0.00",
                        ((OpcionCombo)comboBoxEstado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)comboBoxEstado.SelectedItem).Texto.ToString(),
                });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Producto().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dataGridViewData.Rows[Convert.ToInt32(textBoxIndice.Text)];
                    row.Cells["Id"].Value = textBoxID.Text;
                    row.Cells["Codigo"].Value = textBoxCodigo.Text;
                    row.Cells["Nombre"].Value = textBoxNombre.Text;
                    row.Cells["Descripcion"].Value = textBoxDescripcion.Text;
                    row.Cells["IdCategoria"].Value = ((OpcionCombo)comboBoxCategoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)comboBoxCategoria.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)comboBoxEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)comboBoxEstado.SelectedItem).Texto.ToString();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void Limpiar()
        {
            textBoxIndice.Text = "-1";
            textBoxID.Text = "0";
            textBoxCodigo.Clear();
            textBoxNombre.Clear();
            textBoxDescripcion.Clear();
            comboBoxCategoria.SelectedIndex = 0;
            comboBoxEstado.SelectedIndex = 0;

            textBoxCodigo.Select();
        }

        private void dataGridViewData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Select3.Width;
                var h = Properties.Resources.Select3.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Select3, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewData.Columns[e.ColumnIndex].Name == "buttonSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    textBoxIndice.Text = indice.ToString();
                    textBoxID.Text = dataGridViewData.Rows[indice].Cells["Id"].Value.ToString();

                    textBoxCodigo.Text = dataGridViewData.Rows[indice].Cells["Codigo"].Value.ToString();
                    textBoxNombre.Text = dataGridViewData.Rows[indice].Cells["Nombre"].Value.ToString();
                    textBoxDescripcion.Text = dataGridViewData.Rows[indice].Cells["Descripcion"].Value.ToString();

                    foreach (OpcionCombo oc in comboBoxCategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridViewData.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indiceCombo = comboBoxCategoria.Items.IndexOf(oc);
                            comboBoxCategoria.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in comboBoxEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridViewData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indiceCombo = comboBoxEstado.Items.IndexOf(oc);
                            comboBoxEstado.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxID.Text) != 0)
            {
                if (MessageBox.Show("¿Desae eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Producto obj = new Producto()
                    {
                        IdProducto = Convert.ToInt32(textBoxID.Text),
                    };

                    bool respuesta = new CN_Producto().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dataGridViewData.Rows.RemoveAt(Convert.ToInt32(textBoxIndice.Text)); //Elimina la fila del DataGridView
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)comboBoxBusqueda.SelectedItem).Valor.ToString();

            if (dataGridViewData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textBoxBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void buttonLimpiarBuscardor_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Clear();
            foreach (DataGridViewRow row in dataGridViewData.Rows)
            {
                row.Visible = true;
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dataGridViewData.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                    {
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                    }
                }

                foreach (DataGridViewRow row in dataGridViewData.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[] {
                                row.Cells[2].Value.ToString(),
                                row.Cells[3].Value.ToString(),
                                row.Cells[4].Value.ToString(),
                                row.Cells[6].Value.ToString(),
                                row.Cells[7].Value.ToString(),
                                row.Cells[8].Value.ToString(),
                                row.Cells[9].Value.ToString(),
                                row.Cells[11].Value.ToString(),
                            });
                    }
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
