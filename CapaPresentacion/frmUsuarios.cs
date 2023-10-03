using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            comboBoxEstado.Items.Add(new OpcionCombo() { valor = 1 , texto = "Activo" });
            comboBoxEstado.Items.Add(new OpcionCombo() { valor = 0 , texto = "No activo" });
            comboBoxEstado.DisplayMember = "texto";
            comboBoxEstado.ValueMember = "valor";
            comboBoxEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CNRol().Listar();

            foreach (Rol item in listaRol)
            {
                comboBoxRol.Items.Add(new OpcionCombo() { valor = item.idRol, texto = item.descripcion });
            }
            comboBoxRol.DisplayMember = "texto";
            comboBoxRol.ValueMember = "valor";
            comboBoxRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dataGridViewData.Columns)
            {
                if (columna.Visible == true && columna.Name != "buttonSeleccionar")
                {
                    comboBoxBusqueda.Items.Add(new OpcionCombo() { valor = columna.Name, texto = columna.HeaderText });                   
                }
            }
            comboBoxBusqueda.DisplayMember = "texto";
            comboBoxBusqueda.ValueMember = "valor";
            comboBoxBusqueda.SelectedIndex = 0;

            //Mostrar todos los usuarios
            List<Usuario> listaUsuario = new CNUsuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                dataGridViewData.Rows.Add(new object[] {"", item.idUsuario, item.documento, item.nombreCompleto, item.correo, item.clave,
                    item.oRol.idRol,
                    item.oRol.descripcion,
                    item.estado == true ? "Activo" : "No activo",
                    item.estado == true ? 1 : 0, //Si lo descomento aparece 1 y 0, ESTE TIENE QUE ESTAR ABAJO
                });
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //dataGridViewData.Rows.Add(new object[] {"", textBoxID.Text, textBoxDocumento.Text, textBoxNombreCompleto.Text, textBoxCorreo.Text, textBoxClave.Text,
            //    ((OpcionCombo)comboBoxRol.SelectedItem).valor.ToString(),
            //    ((OpcionCombo)comboBoxRol.SelectedItem).texto.ToString(),
            //    ((OpcionCombo)comboBoxEstado.SelectedItem).texto.ToString(),
            //    ((OpcionCombo)comboBoxEstado.SelectedItem).valor.ToString(), //Si lo descomento aparece 1 y 0, ESTE TIENE QUE ESTAR ABAJO
            //});
            //Limpiar();
        }

        private void Limpiar()
        {
            textBoxIndice.Text = "-1";
            textBoxID.Text = "0";
            textBoxDocumento.Clear();
            textBoxNombreCompleto.Clear();
            textBoxCorreo.Clear();
            textBoxClave.Clear();
            textBoxConfirmarClave.Clear();
            comboBoxRol.SelectedIndex = 0;
            comboBoxEstado.SelectedIndex = 0;
        }

        private void dataGridViewData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Checkbox2.Width;
                var h = Properties.Resources.Checkbox2.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Checkbox2, new Rectangle(x, y, w, h));
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
                    textBoxID.Text = dataGridViewData.Rows[indice].Cells["idUsuario"].Value.ToString();
                    textBoxDocumento.Text = dataGridViewData.Rows[indice].Cells["documento"].Value.ToString();
                    textBoxNombreCompleto.Text = dataGridViewData.Rows[indice].Cells["nombreCompleto"].Value.ToString();
                    textBoxCorreo.Text = dataGridViewData.Rows[indice].Cells["correo"].Value.ToString();
                    textBoxClave.Text = dataGridViewData.Rows[indice].Cells["clave"].Value.ToString();
                    textBoxConfirmarClave.Text = dataGridViewData.Rows[indice].Cells["clave"].Value.ToString();
                    //comboBoxRol.SelectedValue = dataGridViewData.Rows[indice].Cells["idRol"].Value.ToString();
                    //comboBoxEstado.SelectedValue = dataGridViewData.Rows[indice].Cells["estado"].Value.ToString();

                    foreach (OpcionCombo oc in comboBoxRol.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dataGridViewData.Rows[indice].Cells["idRol"].Value))
                        {
                            int indiceCombo = comboBoxRol.Items.IndexOf(oc);
                            comboBoxRol.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in comboBoxEstado.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dataGridViewData.Rows[indice].Cells["estadoValor"].Value))
                        {
                            int indiceCombo = comboBoxEstado.Items.IndexOf(oc);
                            comboBoxEstado.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                }
            }
        }
    }
}
