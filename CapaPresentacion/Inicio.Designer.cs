namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMantenedor = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuNegocio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuVerDetalleVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuVerDetalleCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.contenedor = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelUsuarioTitulo = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.subMenuReporteCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1168, 60);
            this.menuTitulo.TabIndex = 2;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuMantenedor,
            this.menuVentas,
            this.menuCompras,
            this.menuClientes,
            this.menuProveedores,
            this.menuReportes,
            this.menuAcercaDe});
            this.menu.Location = new System.Drawing.Point(0, 60);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1168, 34);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.BackColor = System.Drawing.SystemColors.Window;
            this.menuUsuarios.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(100, 30);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuario_Click);
            // 
            // menuMantenedor
            // 
            this.menuMantenedor.AutoSize = false;
            this.menuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCategoria,
            this.subMenuProducto,
            this.subMenuNegocio});
            this.menuMantenedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMantenedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuMantenedor.Name = "menuMantenedor";
            this.menuMantenedor.Size = new System.Drawing.Size(122, 30);
            this.menuMantenedor.Text = "Mantenedor";
            this.menuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuCategoria
            // 
            this.subMenuCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subMenuCategoria.Name = "subMenuCategoria";
            this.subMenuCategoria.Size = new System.Drawing.Size(180, 28);
            this.subMenuCategoria.Text = "Categoria";
            this.subMenuCategoria.Click += new System.EventHandler(this.subMenuCategoria_Click);
            // 
            // subMenuProducto
            // 
            this.subMenuProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subMenuProducto.Name = "subMenuProducto";
            this.subMenuProducto.Size = new System.Drawing.Size(180, 28);
            this.subMenuProducto.Text = "Producto";
            this.subMenuProducto.Click += new System.EventHandler(this.subMenuProducto_Click);
            // 
            // subMenuNegocio
            // 
            this.subMenuNegocio.Name = "subMenuNegocio";
            this.subMenuNegocio.Size = new System.Drawing.Size(180, 28);
            this.subMenuNegocio.Text = "Negocio";
            this.subMenuNegocio.Click += new System.EventHandler(this.subMenuNegocio_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.AutoSize = false;
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarVenta,
            this.subMenuVerDetalleVenta});
            this.menuVentas.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(100, 30);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarVenta
            // 
            this.subMenuRegistrarVenta.Name = "subMenuRegistrarVenta";
            this.subMenuRegistrarVenta.Size = new System.Drawing.Size(180, 28);
            this.subMenuRegistrarVenta.Text = "Registrar";
            this.subMenuRegistrarVenta.Click += new System.EventHandler(this.subMenuRegistrarVenta_Click);
            // 
            // subMenuVerDetalleVenta
            // 
            this.subMenuVerDetalleVenta.Name = "subMenuVerDetalleVenta";
            this.subMenuVerDetalleVenta.Size = new System.Drawing.Size(180, 28);
            this.subMenuVerDetalleVenta.Text = "Ver detalles";
            this.subMenuVerDetalleVenta.Click += new System.EventHandler(this.subMenuVerDetalleVenta_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.AutoSize = false;
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarCompra,
            this.subMenuVerDetalleCompra});
            this.menuCompras.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCompras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(100, 30);
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarCompra
            // 
            this.subMenuRegistrarCompra.Name = "subMenuRegistrarCompra";
            this.subMenuRegistrarCompra.Size = new System.Drawing.Size(180, 28);
            this.subMenuRegistrarCompra.Text = "Registrar";
            this.subMenuRegistrarCompra.Click += new System.EventHandler(this.subMenuRegistrarCompra_Click);
            // 
            // subMenuVerDetalleCompra
            // 
            this.subMenuVerDetalleCompra.Name = "subMenuVerDetalleCompra";
            this.subMenuVerDetalleCompra.Size = new System.Drawing.Size(180, 28);
            this.subMenuVerDetalleCompra.Text = "Ver detalles";
            this.subMenuVerDetalleCompra.Click += new System.EventHandler(this.subMenuVerDetalleCompra_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(100, 30);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.AutoSize = false;
            this.menuProveedores.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProveedores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(100, 30);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.AutoSize = false;
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuReporteCompras,
            this.subMenuReporteVentas});
            this.menuReportes.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(100, 30);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.AutoSize = false;
            this.menuAcercaDe.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAcercaDe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(100, 30);
            this.menuAcercaDe.Text = "Acerca de";
            this.menuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 94);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1168, 639);
            this.contenedor.TabIndex = 4;
            // 
            // labelTitulo
            // 
            this.labelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelTitulo.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTitulo.Location = new System.Drawing.Point(15, 15);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(180, 30);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Servicio De Color";
            // 
            // labelUsuarioTitulo
            // 
            this.labelUsuarioTitulo.AutoSize = true;
            this.labelUsuarioTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelUsuarioTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUsuarioTitulo.Location = new System.Drawing.Point(911, 26);
            this.labelUsuarioTitulo.Name = "labelUsuarioTitulo";
            this.labelUsuarioTitulo.Size = new System.Drawing.Size(53, 19);
            this.labelUsuarioTitulo.TabIndex = 6;
            this.labelUsuarioTitulo.Text = "Usuario:";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUsuario.Location = new System.Drawing.Point(959, 26);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(77, 19);
            this.labelUsuario.TabIndex = 7;
            this.labelUsuario.Text = "labelUsuario";
            // 
            // subMenuReporteCompras
            // 
            this.subMenuReporteCompras.Name = "subMenuReporteCompras";
            this.subMenuReporteCompras.Size = new System.Drawing.Size(207, 28);
            this.subMenuReporteCompras.Text = "Reporte de compras";
            this.subMenuReporteCompras.Click += new System.EventHandler(this.subMenuReporteCompras_Click);
            // 
            // subMenuReporteVentas
            // 
            this.subMenuReporteVentas.Name = "subMenuReporteVentas";
            this.subMenuReporteVentas.Size = new System.Drawing.Size(207, 28);
            this.subMenuReporteVentas.Text = "Reporte de ventas";
            this.subMenuReporteVentas.Click += new System.EventHandler(this.subMenuReporteVentas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 733);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelUsuarioTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuAcercaDe;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuMantenedor;
        private System.Windows.Forms.ToolStripMenuItem menuVentas;
        private System.Windows.Forms.ToolStripMenuItem menuCompras;
        private System.Windows.Forms.ToolStripMenuItem menuProveedores;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.Label labelUsuarioTitulo;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.ToolStripMenuItem subMenuCategoria;
        private System.Windows.Forms.ToolStripMenuItem subMenuProducto;
        private System.Windows.Forms.ToolStripMenuItem subMenuRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem subMenuVerDetalleVenta;
        private System.Windows.Forms.ToolStripMenuItem subMenuRegistrarCompra;
        private System.Windows.Forms.ToolStripMenuItem subMenuVerDetalleCompra;
        private System.Windows.Forms.ToolStripMenuItem subMenuNegocio;
        private System.Windows.Forms.ToolStripMenuItem subMenuReporteCompras;
        private System.Windows.Forms.ToolStripMenuItem subMenuReporteVentas;
    }
}

