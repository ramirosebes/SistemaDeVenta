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
            comboBoxEstado.Items.Add(new OpcionCombo() { valor = 1, texto = "Activo" });
            comboBoxEstado.Items.Add(new OpcionCombo() { valor = 0, texto = "No activo" });
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
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            dataGridViewData.Rows.Add(new object[] {"", textBoxID.Text, textBoxDocumento.Text, textBoxNombreCompleto.Text, textBoxCorreo.Text, textBoxClave.Text,
                ((OpcionCombo)comboBoxRol.SelectedItem).valor.ToString(),
                ((OpcionCombo)comboBoxRol.SelectedItem).texto.ToString(),
                //((OpcionCombo)comboBoxEstado.SelectedItem).valor.ToString(),
                ((OpcionCombo)comboBoxEstado.SelectedItem).texto.ToString(),
            });
            Limpiar();
        }

        private void Limpiar()
        {
            textBoxID.Text = "0";
            textBoxDocumento.Clear();
            textBoxNombreCompleto.Clear();
            textBoxCorreo.Clear();
            textBoxClave.Clear();
            textBoxConfirmarClave.Clear();
            comboBoxRol.SelectedIndex = 0;
            comboBoxEstado.SelectedIndex = 0;
        }
    }
}
