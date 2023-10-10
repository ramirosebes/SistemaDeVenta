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
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 1 , Texto = "Activo" });
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 0 , Texto = "No activo" });
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";
            comboBoxEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                comboBoxRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            comboBoxRol.DisplayMember = "Texto";
            comboBoxRol.ValueMember = "Valor";
            comboBoxRol.SelectedIndex = 0;

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

            //Mostrar todos los usuarios
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                dataGridViewData.Rows.Add(new object[] {"", item.IdUsuario, item.Documento, item.NombreCompleto, item.Correo, item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ? "Activo" : "No activo",
                    item.Estado == true ? 1 : 0, //Si lo descomento aparece 1 y 0, ESTE TIENE QUE ESTAR ABAJO
                });
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objUsuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(textBoxID.Text),
                Documento = textBoxDocumento.Text,
                NombreCompleto = textBoxNombreCompleto.Text,
                Correo = textBoxCorreo.Text,
                Clave = textBoxClave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)comboBoxRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objUsuario.IdUsuario == 0) //Si es un usuario nuevo
            {
                int idUsuarioGenerado = new CN_Usuario().Registrar(objUsuario, out mensaje);


                if (idUsuarioGenerado != 0)
                {
                    dataGridViewData.Rows.Add(new object[] {"", idUsuarioGenerado, textBoxDocumento.Text, textBoxNombreCompleto.Text, textBoxCorreo.Text, textBoxClave.Text,
                    ((OpcionCombo)comboBoxRol.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)comboBoxRol.SelectedItem).Texto.ToString(),
                    ((OpcionCombo)comboBoxEstado.SelectedItem).Texto.ToString(),
                    ((OpcionCombo)comboBoxEstado.SelectedItem).Valor.ToString(), //Si lo descomento aparece 1 y 0, ESTE TIENE QUE ESTAR ABAJO
                });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else //Si es un usuario ya registrado
            {
                bool resultado = new CN_Usuario().Editar(objUsuario, out mensaje);

                if (resultado)
                {
                    //Una vez que se guarde se actualiza en el DataGridView
                    DataGridViewRow row = dataGridViewData.Rows[Convert.ToInt32(textBoxIndice.Text)];
                    row.Cells["Id"].Value = textBoxID.Text;
                    row.Cells["Documento"].Value = textBoxDocumento.Text;
                    row.Cells["NombreCompleto"].Value = textBoxNombreCompleto.Text;
                    row.Cells["Correo"].Value = textBoxCorreo.Text;
                    row.Cells["Clave"].Value = textBoxClave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)comboBoxRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)comboBoxRol.SelectedItem).Texto.ToString();
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
            textBoxNombreCompleto.Clear();
            textBoxCorreo.Clear();
            textBoxClave.Clear();
            textBoxConfirmarClave.Clear();
            comboBoxRol.SelectedIndex = 0;
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

                var w = Properties.Resources.Checkbox1.Width;
                var h = Properties.Resources.Checkbox1.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Checkbox1, new Rectangle(x, y, w, h));
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
                    textBoxNombreCompleto.Text = dataGridViewData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    textBoxCorreo.Text = dataGridViewData.Rows[indice].Cells["Correo"].Value.ToString();
                    textBoxClave.Text = dataGridViewData.Rows[indice].Cells["Clave"].Value.ToString();
                    textBoxConfirmarClave.Text = dataGridViewData.Rows[indice].Cells["Clave"].Value.ToString();

                    foreach (OpcionCombo oc in comboBoxRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGridViewData.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indiceCombo = comboBoxRol.Items.IndexOf(oc);
                            comboBoxRol.SelectedIndex = indiceCombo;
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
            if (Convert.ToInt32(textBoxID.Text) != 0 )
            {
                if(MessageBox.Show("¿Desae eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Usuario objUsuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(textBoxID.Text),
                    };

                    bool respuesta = new CN_Usuario().Eliminar(objUsuario, out mensaje);

                    if(respuesta)
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
