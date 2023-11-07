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
            this.menuSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuVerDetalleVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuVerDetalleCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuReporteCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuDatosNegocio = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuAcerdaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.contenedor = new System.Windows.Forms.Panel();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelUsuarioTitulo = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.subMenuGrupos = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuTitulo.Size = new System.Drawing.Size(1156, 60);
            this.menuTitulo.TabIndex = 2;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSeguridad,
            this.menuVentas,
            this.menuCompras,
            this.menuReportes,
            this.menuConfiguracion});
            this.menu.Location = new System.Drawing.Point(0, 60);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1156, 34);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip1";
            // 
            // menuSeguridad
            // 
            this.menuSeguridad.AutoSize = false;
            this.menuSeguridad.BackColor = System.Drawing.SystemColors.Window;
            this.menuSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuUsuarios,
            this.subMenuGrupos});
            this.menuSeguridad.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSeguridad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuSeguridad.Name = "menuSeguridad";
            this.menuSeguridad.Size = new System.Drawing.Size(100, 30);
            this.menuSeguridad.Text = "Seguridad";
            this.menuSeguridad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuUsuarios
            // 
            this.subMenuUsuarios.Name = "subMenuUsuarios";
            this.subMenuUsuarios.Size = new System.Drawing.Size(180, 28);
            this.subMenuUsuarios.Text = "Usuarios";
            this.subMenuUsuarios.Click += new System.EventHandler(this.subMenuUsuarios_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.AutoSize = false;
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarVenta,
            this.subMenuVerDetalleVenta,
            this.subMenuClientes});
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
            this.subMenuRegistrarVenta.Size = new System.Drawing.Size(244, 28);
            this.subMenuRegistrarVenta.Text = "Registrar pedido de venta";
            this.subMenuRegistrarVenta.Click += new System.EventHandler(this.subMenuRegistrarVenta_Click);
            // 
            // subMenuVerDetalleVenta
            // 
            this.subMenuVerDetalleVenta.Name = "subMenuVerDetalleVenta";
            this.subMenuVerDetalleVenta.Size = new System.Drawing.Size(244, 28);
            this.subMenuVerDetalleVenta.Text = "Ver pedidos de ventas";
            this.subMenuVerDetalleVenta.Click += new System.EventHandler(this.subMenuVerDetalleVenta_Click);
            // 
            // subMenuClientes
            // 
            this.subMenuClientes.Name = "subMenuClientes";
            this.subMenuClientes.Size = new System.Drawing.Size(244, 28);
            this.subMenuClientes.Text = "Clientes";
            this.subMenuClientes.Click += new System.EventHandler(this.subMenuClientes_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.AutoSize = false;
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarCompra,
            this.subMenuVerDetalleCompra,
            this.subMenuCategorias,
            this.subMenuProveedores,
            this.subMenuProductos});
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
            this.subMenuRegistrarCompra.Size = new System.Drawing.Size(251, 28);
            this.subMenuRegistrarCompra.Text = "Registrar orden de compra";
            this.subMenuRegistrarCompra.Click += new System.EventHandler(this.subMenuRegistrarCompra_Click);
            // 
            // subMenuVerDetalleCompra
            // 
            this.subMenuVerDetalleCompra.Name = "subMenuVerDetalleCompra";
            this.subMenuVerDetalleCompra.Size = new System.Drawing.Size(251, 28);
            this.subMenuVerDetalleCompra.Text = "Ver ordenes de compras";
            this.subMenuVerDetalleCompra.Click += new System.EventHandler(this.subMenuVerDetalleCompra_Click);
            // 
            // subMenuCategorias
            // 
            this.subMenuCategorias.Name = "subMenuCategorias";
            this.subMenuCategorias.Size = new System.Drawing.Size(251, 28);
            this.subMenuCategorias.Text = "Categorias";
            this.subMenuCategorias.Click += new System.EventHandler(this.subMenuCategorias_Click);
            // 
            // subMenuProveedores
            // 
            this.subMenuProveedores.Name = "subMenuProveedores";
            this.subMenuProveedores.Size = new System.Drawing.Size(251, 28);
            this.subMenuProveedores.Text = "Proveedores";
            this.subMenuProveedores.Click += new System.EventHandler(this.subMenuProveedores_Click);
            // 
            // subMenuProductos
            // 
            this.subMenuProductos.Name = "subMenuProductos";
            this.subMenuProductos.Size = new System.Drawing.Size(251, 28);
            this.subMenuProductos.Text = "Productos";
            this.subMenuProductos.Click += new System.EventHandler(this.subMenuProductos_Click);
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
            // menuConfiguracion
            // 
            this.menuConfiguracion.AutoSize = false;
            this.menuConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuDatosNegocio,
            this.subMenuAcerdaDe});
            this.menuConfiguracion.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuConfiguracion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuConfiguracion.Name = "menuConfiguracion";
            this.menuConfiguracion.Size = new System.Drawing.Size(100, 30);
            this.menuConfiguracion.Text = "Configuracion";
            this.menuConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuDatosNegocio
            // 
            this.subMenuDatosNegocio.Name = "subMenuDatosNegocio";
            this.subMenuDatosNegocio.Size = new System.Drawing.Size(252, 28);
            this.subMenuDatosNegocio.Text = "Datos del negocio";
            this.subMenuDatosNegocio.Click += new System.EventHandler(this.datosDelNegocioToolStripMenuItem_Click);
            // 
            // subMenuAcerdaDe
            // 
            this.subMenuAcerdaDe.Name = "subMenuAcerdaDe";
            this.subMenuAcerdaDe.Size = new System.Drawing.Size(252, 28);
            this.subMenuAcerdaDe.Text = "Acerda de Servicio De Color";
            this.subMenuAcerdaDe.Click += new System.EventHandler(this.acerdaDeServicioDeColorToolStripMenuItem_Click);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 94);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1156, 639);
            this.contenedor.TabIndex = 4;
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrarSesion.Image")));
            this.buttonCerrarSesion.Location = new System.Drawing.Point(1106, 12);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(40, 40);
            this.buttonCerrarSesion.TabIndex = 84;
            this.buttonCerrarSesion.UseVisualStyleBackColor = false;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
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
            this.labelUsuarioTitulo.Location = new System.Drawing.Point(201, 23);
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
            this.labelUsuario.Location = new System.Drawing.Point(249, 23);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(77, 19);
            this.labelUsuario.TabIndex = 7;
            this.labelUsuario.Text = "labelUsuario";
            // 
            // subMenuGrupos
            // 
            this.subMenuGrupos.Name = "subMenuGrupos";
            this.subMenuGrupos.Size = new System.Drawing.Size(180, 28);
            this.subMenuGrupos.Text = "Grupos";
            this.subMenuGrupos.Click += new System.EventHandler(this.subMenuGrupos_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 733);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelUsuarioTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem menuConfiguracion;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ToolStripMenuItem menuSeguridad;
        private System.Windows.Forms.ToolStripMenuItem menuVentas;
        private System.Windows.Forms.ToolStripMenuItem menuCompras;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.Label labelUsuarioTitulo;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.ToolStripMenuItem subMenuRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem subMenuVerDetalleVenta;
        private System.Windows.Forms.ToolStripMenuItem subMenuRegistrarCompra;
        private System.Windows.Forms.ToolStripMenuItem subMenuVerDetalleCompra;
        private System.Windows.Forms.ToolStripMenuItem subMenuReporteCompras;
        private System.Windows.Forms.ToolStripMenuItem subMenuReporteVentas;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem subMenuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem subMenuClientes;
        private System.Windows.Forms.ToolStripMenuItem subMenuCategorias;
        private System.Windows.Forms.ToolStripMenuItem subMenuProductos;
        private System.Windows.Forms.ToolStripMenuItem subMenuProveedores;
        private System.Windows.Forms.ToolStripMenuItem subMenuDatosNegocio;
        private System.Windows.Forms.ToolStripMenuItem subMenuAcerdaDe;
        private System.Windows.Forms.ToolStripMenuItem subMenuGrupos;
    }
}

