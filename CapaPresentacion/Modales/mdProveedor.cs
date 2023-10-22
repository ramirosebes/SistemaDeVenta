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

namespace CapaPresentacion.Modales
{
    public partial class mdProveedor : Form
    {
        public Proveedor _Proveedor { get; set; }

        public mdProveedor()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dataGridViewData.Columns)
            {
                if (columna.Visible == true)
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
                dataGridViewData.Rows.Add(new object[] {item.IdProveedor, item.Documento, item.RazonSocial});
            }
        }

        private void dataGridViewData_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                _Proveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(dataGridViewData.Rows[iRow].Cells["Id"].Value.ToString()),
                    Documento = dataGridViewData.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial = dataGridViewData.Rows[iRow].Cells["RazonSocial"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
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

    }
}
