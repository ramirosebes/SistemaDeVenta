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

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static ToolStripMenuItem menuActivo = null;
        private static Form formularioActivo;

        public Inicio(Usuario objUsuario)
        {
            usuarioActual = objUsuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = usuarioActual.nombreCompleto;
        }

        private void abrirFormulario(ToolStripMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.FromArgb(45, 204, 112);
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuUsuario_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem) sender ,new frmUsuarios());
        }

        private void menuCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMantenedor, new frmCategoria());
        }

        private void menuProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMantenedor, new frmProducto());
        }
    }
}
