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
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.contenedor = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMantenedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(815, 60);
            this.menuTitulo.TabIndex = 2;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Window;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuMantenedor,
            this.menuVentas,
            this.menuCompras,
            this.menuClientes,
            this.menuProveedores,
            this.menuReportes,
            this.menuAcercaDe});
            this.menu.Location = new System.Drawing.Point(0, 60);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(815, 34);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip1";
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.AutoSize = false;
            this.menuAcercaDe.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAcercaDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(100, 30);
            this.menuAcercaDe.Text = "Acerca de";
            this.menuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.Control;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 94);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(815, 356);
            this.contenedor.TabIndex = 4;
            // 
            // labelTitulo
            // 
            this.labelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.labelTitulo.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTitulo.Location = new System.Drawing.Point(15, 15);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(180, 30);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Sistema de Ventas";
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(100, 30);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuReportes
            // 
            this.menuReportes.AutoSize = false;
            this.menuReportes.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(100, 30);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuProveedores
            // 
            this.menuProveedores.AutoSize = false;
            this.menuProveedores.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(100, 30);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuCompras
            // 
            this.menuCompras.AutoSize = false;
            this.menuCompras.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(100, 30);
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuVentas
            // 
            this.menuVentas.AutoSize = false;
            this.menuVentas.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(100, 30);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuMantenedor
            // 
            this.menuMantenedor.AutoSize = false;
            this.menuMantenedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMantenedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.menuMantenedor.Name = "menuMantenedor";
            this.menuMantenedor.Size = new System.Drawing.Size(100, 30);
            this.menuMantenedor.Text = "Mantenedor";
            this.menuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuUsuario
            // 
            this.menuUsuario.AutoSize = false;
            this.menuUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.menuUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(100, 30);
            this.menuUsuario.Text = "Usuarios";
            this.menuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Name = "Inicio";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuMantenedor;
        private System.Windows.Forms.ToolStripMenuItem menuVentas;
        private System.Windows.Forms.ToolStripMenuItem menuCompras;
        private System.Windows.Forms.ToolStripMenuItem menuProveedores;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
    }
}

