namespace CapaPresentacion
{
    partial class frmCompras
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxTotalAPagar = new System.Windows.Forms.TextBox();
            this.labelTotalAPagar = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxInformacionProducto = new System.Windows.Forms.GroupBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.labelPrecioVenta = new System.Windows.Forms.Label();
            this.textBoxPrecioCompra = new System.Windows.Forms.TextBox();
            this.labelPrecioCompra = new System.Windows.Forms.Label();
            this.textBoxIdProducto = new System.Windows.Forms.TextBox();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.labelProducto = new System.Windows.Forms.Label();
            this.textBoxCodigoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxInformacionProveedor = new System.Windows.Forms.GroupBox();
            this.textBoxIdProveedor = new System.Windows.Forms.TextBox();
            this.textBoxNombreProveedor = new System.Windows.Forms.TextBox();
            this.textBoxDocumentoProveedor = new System.Windows.Forms.TextBox();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.labelNumeroDocumento = new System.Windows.Forms.Label();
            this.groupBoxInformacionCompra = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            this.labelFehca = new System.Windows.Forms.Label();
            this.labelRegistrarCompra = new System.Windows.Forms.Label();
            this.buttonBuscarProducto = new System.Windows.Forms.Button();
            this.buttonBuscarProveedor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxInformacionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.groupBoxInformacionProveedor.SuspendLayout();
            this.groupBoxInformacionCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.buttonRegistrar);
            this.panel1.Controls.Add(this.textBoxTotalAPagar);
            this.panel1.Controls.Add(this.labelTotalAPagar);
            this.panel1.Controls.Add(this.buttonAgregar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBoxInformacionProducto);
            this.panel1.Controls.Add(this.groupBoxInformacionProveedor);
            this.panel1.Controls.Add(this.groupBoxInformacionCompra);
            this.panel1.Controls.Add(this.labelRegistrarCompra);
            this.panel1.Location = new System.Drawing.Point(169, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 613);
            this.panel1.TabIndex = 0;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.buttonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegistrar.Location = new System.Drawing.Point(688, 569);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(140, 30);
            this.buttonRegistrar.TabIndex = 56;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            // 
            // textBoxTotalAPagar
            // 
            this.textBoxTotalAPagar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAPagar.Location = new System.Drawing.Point(688, 536);
            this.textBoxTotalAPagar.Name = "textBoxTotalAPagar";
            this.textBoxTotalAPagar.Size = new System.Drawing.Size(140, 27);
            this.textBoxTotalAPagar.TabIndex = 5;
            this.textBoxTotalAPagar.Text = "0";
            // 
            // labelTotalAPagar
            // 
            this.labelTotalAPagar.AutoSize = true;
            this.labelTotalAPagar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAPagar.Location = new System.Drawing.Point(684, 514);
            this.labelTotalAPagar.Name = "labelTotalAPagar";
            this.labelTotalAPagar.Size = new System.Drawing.Size(81, 19);
            this.labelTotalAPagar.TabIndex = 4;
            this.labelTotalAPagar.Text = "Total a pagar:";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAgregar.Location = new System.Drawing.Point(758, 152);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(59, 76);
            this.buttonAgregar.TabIndex = 55;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.buttonEliminar});
            this.dataGridView1.Location = new System.Drawing.Point(19, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 365);
            this.dataGridView1.TabIndex = 5;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.HeaderText = "";
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.buttonEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.buttonEliminar.Width = 30;
            // 
            // groupBoxInformacionProducto
            // 
            this.groupBoxInformacionProducto.Controls.Add(this.numericUpDownCantidad);
            this.groupBoxInformacionProducto.Controls.Add(this.labelCantidad);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxPrecioVenta);
            this.groupBoxInformacionProducto.Controls.Add(this.labelPrecioVenta);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxPrecioCompra);
            this.groupBoxInformacionProducto.Controls.Add(this.labelPrecioCompra);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxIdProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.buttonBuscarProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.labelProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.textBoxCodigoProducto);
            this.groupBoxInformacionProducto.Controls.Add(this.label2);
            this.groupBoxInformacionProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformacionProducto.Location = new System.Drawing.Point(19, 141);
            this.groupBoxInformacionProducto.Name = "groupBoxInformacionProducto";
            this.groupBoxInformacionProducto.Size = new System.Drawing.Size(733, 87);
            this.groupBoxInformacionProducto.TabIndex = 4;
            this.groupBoxInformacionProducto.TabStop = false;
            this.groupBoxInformacionProducto.Text = "Información del producto";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(625, 44);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(100, 27);
            this.numericUpDownCantidad.TabIndex = 5;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(621, 22);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(59, 19);
            this.labelCantidad.TabIndex = 23;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // textBoxPrecioVenta
            // 
            this.textBoxPrecioVenta.Location = new System.Drawing.Point(519, 45);
            this.textBoxPrecioVenta.Name = "textBoxPrecioVenta";
            this.textBoxPrecioVenta.Size = new System.Drawing.Size(100, 27);
            this.textBoxPrecioVenta.TabIndex = 22;
            // 
            // labelPrecioVenta
            // 
            this.labelPrecioVenta.AutoSize = true;
            this.labelPrecioVenta.Location = new System.Drawing.Point(515, 23);
            this.labelPrecioVenta.Name = "labelPrecioVenta";
            this.labelPrecioVenta.Size = new System.Drawing.Size(93, 19);
            this.labelPrecioVenta.TabIndex = 21;
            this.labelPrecioVenta.Text = "Precio de venta:";
            // 
            // textBoxPrecioCompra
            // 
            this.textBoxPrecioCompra.Location = new System.Drawing.Point(413, 45);
            this.textBoxPrecioCompra.Name = "textBoxPrecioCompra";
            this.textBoxPrecioCompra.Size = new System.Drawing.Size(100, 27);
            this.textBoxPrecioCompra.TabIndex = 20;
            // 
            // labelPrecioCompra
            // 
            this.labelPrecioCompra.AutoSize = true;
            this.labelPrecioCompra.Location = new System.Drawing.Point(409, 23);
            this.labelPrecioCompra.Name = "labelPrecioCompra";
            this.labelPrecioCompra.Size = new System.Drawing.Size(103, 19);
            this.labelPrecioCompra.TabIndex = 19;
            this.labelPrecioCompra.Text = "Precio de compra:";
            // 
            // textBoxIdProducto
            // 
            this.textBoxIdProducto.Location = new System.Drawing.Point(126, 19);
            this.textBoxIdProducto.Name = "textBoxIdProducto";
            this.textBoxIdProducto.Size = new System.Drawing.Size(34, 27);
            this.textBoxIdProducto.TabIndex = 17;
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Location = new System.Drawing.Point(207, 45);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.Size = new System.Drawing.Size(200, 27);
            this.textBoxProducto.TabIndex = 18;
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(203, 22);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(59, 19);
            this.labelProducto.TabIndex = 16;
            this.labelProducto.Text = "Producto:";
            // 
            // textBoxCodigoProducto
            // 
            this.textBoxCodigoProducto.Location = new System.Drawing.Point(10, 45);
            this.textBoxCodigoProducto.Name = "textBoxCodigoProducto";
            this.textBoxCodigoProducto.Size = new System.Drawing.Size(150, 27);
            this.textBoxCodigoProducto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo del producto:";
            // 
            // groupBoxInformacionProveedor
            // 
            this.groupBoxInformacionProveedor.Controls.Add(this.textBoxIdProveedor);
            this.groupBoxInformacionProveedor.Controls.Add(this.textBoxNombreProveedor);
            this.groupBoxInformacionProveedor.Controls.Add(this.buttonBuscarProveedor);
            this.groupBoxInformacionProveedor.Controls.Add(this.textBoxDocumentoProveedor);
            this.groupBoxInformacionProveedor.Controls.Add(this.labelRazonSocial);
            this.groupBoxInformacionProveedor.Controls.Add(this.labelNumeroDocumento);
            this.groupBoxInformacionProveedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformacionProveedor.Location = new System.Drawing.Point(401, 48);
            this.groupBoxInformacionProveedor.Name = "groupBoxInformacionProveedor";
            this.groupBoxInformacionProveedor.Size = new System.Drawing.Size(416, 87);
            this.groupBoxInformacionProveedor.TabIndex = 4;
            this.groupBoxInformacionProveedor.TabStop = false;
            this.groupBoxInformacionProveedor.Text = "Información del proveedor";
            // 
            // textBoxIdProveedor
            // 
            this.textBoxIdProveedor.Location = new System.Drawing.Point(365, 15);
            this.textBoxIdProveedor.Name = "textBoxIdProveedor";
            this.textBoxIdProveedor.Size = new System.Drawing.Size(42, 27);
            this.textBoxIdProveedor.TabIndex = 5;
            // 
            // textBoxNombreProveedor
            // 
            this.textBoxNombreProveedor.Location = new System.Drawing.Point(207, 45);
            this.textBoxNombreProveedor.Name = "textBoxNombreProveedor";
            this.textBoxNombreProveedor.Size = new System.Drawing.Size(200, 27);
            this.textBoxNombreProveedor.TabIndex = 15;
            // 
            // textBoxDocumentoProveedor
            // 
            this.textBoxDocumentoProveedor.Location = new System.Drawing.Point(10, 45);
            this.textBoxDocumentoProveedor.Name = "textBoxDocumentoProveedor";
            this.textBoxDocumentoProveedor.Size = new System.Drawing.Size(150, 27);
            this.textBoxDocumentoProveedor.TabIndex = 2;
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(203, 23);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(80, 19);
            this.labelRazonSocial.TabIndex = 1;
            this.labelRazonSocial.Text = "Razon social:";
            // 
            // labelNumeroDocumento
            // 
            this.labelNumeroDocumento.AutoSize = true;
            this.labelNumeroDocumento.Location = new System.Drawing.Point(6, 23);
            this.labelNumeroDocumento.Name = "labelNumeroDocumento";
            this.labelNumeroDocumento.Size = new System.Drawing.Size(126, 19);
            this.labelNumeroDocumento.TabIndex = 0;
            this.labelNumeroDocumento.Text = "Numero de documento";
            // 
            // groupBoxInformacionCompra
            // 
            this.groupBoxInformacionCompra.Controls.Add(this.comboBoxTipoDocumento);
            this.groupBoxInformacionCompra.Controls.Add(this.textBoxFecha);
            this.groupBoxInformacionCompra.Controls.Add(this.labelTipoDocumento);
            this.groupBoxInformacionCompra.Controls.Add(this.labelFehca);
            this.groupBoxInformacionCompra.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformacionCompra.Location = new System.Drawing.Point(19, 48);
            this.groupBoxInformacionCompra.Name = "groupBoxInformacionCompra";
            this.groupBoxInformacionCompra.Size = new System.Drawing.Size(376, 87);
            this.groupBoxInformacionCompra.TabIndex = 1;
            this.groupBoxInformacionCompra.TabStop = false;
            this.groupBoxInformacionCompra.Text = "Información de la compra";
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(166, 45);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(200, 27);
            this.comboBoxTipoDocumento.TabIndex = 3;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(10, 45);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(150, 27);
            this.textBoxFecha.TabIndex = 2;
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Location = new System.Drawing.Point(162, 23);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(109, 19);
            this.labelTipoDocumento.TabIndex = 1;
            this.labelTipoDocumento.Text = "Tipo de documento:";
            // 
            // labelFehca
            // 
            this.labelFehca.AutoSize = true;
            this.labelFehca.Location = new System.Drawing.Point(6, 23);
            this.labelFehca.Name = "labelFehca";
            this.labelFehca.Size = new System.Drawing.Size(44, 19);
            this.labelFehca.TabIndex = 0;
            this.labelFehca.Text = "Fecha:";
            // 
            // labelRegistrarCompra
            // 
            this.labelRegistrarCompra.AutoSize = true;
            this.labelRegistrarCompra.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarCompra.Location = new System.Drawing.Point(13, 12);
            this.labelRegistrarCompra.Name = "labelRegistrarCompra";
            this.labelRegistrarCompra.Size = new System.Drawing.Size(169, 33);
            this.labelRegistrarCompra.TabIndex = 0;
            this.labelRegistrarCompra.Text = "Registrar compra";
            // 
            // buttonBuscarProducto
            // 
            this.buttonBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarProducto.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscarProducto.Image = global::CapaPresentacion.Properties.Resources.Lupa2;
            this.buttonBuscarProducto.Location = new System.Drawing.Point(166, 45);
            this.buttonBuscarProducto.Name = "buttonBuscarProducto";
            this.buttonBuscarProducto.Size = new System.Drawing.Size(35, 27);
            this.buttonBuscarProducto.TabIndex = 16;
            this.buttonBuscarProducto.UseVisualStyleBackColor = false;
            this.buttonBuscarProducto.Click += new System.EventHandler(this.buttonBuscarProducto_Click);
            // 
            // buttonBuscarProveedor
            // 
            this.buttonBuscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarProveedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarProveedor.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscarProveedor.Image = global::CapaPresentacion.Properties.Resources.Lupa2;
            this.buttonBuscarProveedor.Location = new System.Drawing.Point(166, 45);
            this.buttonBuscarProveedor.Name = "buttonBuscarProveedor";
            this.buttonBuscarProveedor.Size = new System.Drawing.Size(35, 27);
            this.buttonBuscarProveedor.TabIndex = 14;
            this.buttonBuscarProveedor.UseVisualStyleBackColor = false;
            this.buttonBuscarProveedor.Click += new System.EventHandler(this.buttonBuscarProveedor_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1157, 637);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxInformacionProducto.ResumeLayout(false);
            this.groupBoxInformacionProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.groupBoxInformacionProveedor.ResumeLayout(false);
            this.groupBoxInformacionProveedor.PerformLayout();
            this.groupBoxInformacionCompra.ResumeLayout(false);
            this.groupBoxInformacionCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxInformacionCompra;
        private System.Windows.Forms.Label labelRegistrarCompra;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelTipoDocumento;
        private System.Windows.Forms.Label labelFehca;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.GroupBox groupBoxInformacionProveedor;
        private System.Windows.Forms.TextBox textBoxDocumentoProveedor;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.Label labelNumeroDocumento;
        private System.Windows.Forms.TextBox textBoxNombreProveedor;
        private System.Windows.Forms.Button buttonBuscarProveedor;
        private System.Windows.Forms.TextBox textBoxIdProveedor;
        private System.Windows.Forms.GroupBox groupBoxInformacionProducto;
        private System.Windows.Forms.TextBox textBoxIdProducto;
        private System.Windows.Forms.Button buttonBuscarProducto;
        private System.Windows.Forms.TextBox textBoxProducto;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.TextBox textBoxCodigoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxPrecioVenta;
        private System.Windows.Forms.Label labelPrecioVenta;
        private System.Windows.Forms.TextBox textBoxPrecioCompra;
        private System.Windows.Forms.Label labelPrecioCompra;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn buttonEliminar;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textBoxTotalAPagar;
        private System.Windows.Forms.Label labelTotalAPagar;
        private System.Windows.Forms.Button buttonAgregar;
    }
}