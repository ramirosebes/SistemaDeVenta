using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No activo" });
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";
            comboBoxEstado.SelectedIndex = 0;

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

            List<Proveedor> lista = new CN_Proveedor().Listar();

            foreach (Proveedor item in lista)
            {
                dataGridViewData.Rows.Add(new object[] {"", item.IdProveedor, item.Documento, item.RazonSocial, item.Correo, item.Telefono,
                    item.Estado == true ? "Activo" : "No activo",
                    item.Estado == true ? 1 : 0,
                });
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Proveedor obj = new Proveedor()
            {
                IdProveedor = Convert.ToInt32(textBoxID.Text),
                Documento = textBoxDocumento.Text,
                RazonSocial = textBoxRazonSocial.Text,
                Correo = textBoxCorreo.Text,
                Telefono = textBoxTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdProveedor == 0) //Si es nuevo
            {
                int idGenerado = new CN_Proveedor().Registrar(obj, out mensaje);


                if (idGenerado != 0)
                {
                    dataGridViewData.Rows.Add(new object[] {"", idGenerado, textBoxDocumento.Text, textBoxRazonSocial.Text, textBoxCorreo.Text, textBoxTelefono.Text,
                        ((OpcionCombo)comboBoxEstado.SelectedItem).Texto.ToString(),
                        ((OpcionCombo)comboBoxEstado.SelectedItem).Valor.ToString(),
                });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else //Si ya esta registrado
            {
                bool resultado = new CN_Proveedor().Editar(obj, out mensaje);

                if (resultado)
                {
                    //Una vez que se guarde se actualiza en el DataGridView
                    DataGridViewRow row = dataGridViewData.Rows[Convert.ToInt32(textBoxIndice.Text)];
                    row.Cells["Id"].Value = textBoxID.Text;
                    row.Cells["Documento"].Value = textBoxDocumento.Text;
                    row.Cells["RazonSocial"].Value = textBoxRazonSocial.Text;
                    row.Cells["Correo"].Value = textBoxCorreo.Text;
                    row.Cells["Telefono"].Value = textBoxTelefono.Text;
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
            textBoxDocumento.Clear();
            textBoxRazonSocial.Clear();
            textBoxCorreo.Clear();
            textBoxTelefono.Clear();
            comboBoxEstado.SelectedIndex = 0;
            textBoxDocumento.Select();
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
                    textBoxDocumento.Text = dataGridViewData.Rows[indice].Cells["Documento"].Value.ToString();
                    textBoxRazonSocial.Text = dataGridViewData.Rows[indice].Cells["RazonSocial"].Value.ToString();
                    textBoxCorreo.Text = dataGridViewData.Rows[indice].Cells["Correo"].Value.ToString();
                    textBoxTelefono.Text = dataGridViewData.Rows[indice].Cells["Telefono"].Value.ToString();

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
                if (MessageBox.Show("¿Desae eliminar el proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Proveedor obj = new Proveedor()
                    {
                        IdProveedor = Convert.ToInt32(textBoxID.Text),
                    };

                    bool respuesta = new CN_Proveedor().Eliminar(obj, out mensaje);

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
                        row.Visible = true; //Muestra la fila
                    }
                    else
                    {
                        row.Visible = false; //Oculta la fila
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
    }
}
