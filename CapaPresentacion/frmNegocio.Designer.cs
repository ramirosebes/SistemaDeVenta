namespace CapaPresentacion
{
    partial class frmNegocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNegocio));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelPanelIzquierda = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSubir = new System.Windows.Forms.Button();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelLineDireccion = new System.Windows.Forms.Label();
            this.labelRUC = new System.Windows.Forms.Label();
            this.textBoxRUC = new System.Windows.Forms.TextBox();
            this.labelLineRUC = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelLineNombre = new System.Windows.Forms.Label();
            this.buttonGuardarCambios = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.labelTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(185, 33);
            this.labelTitulo.TabIndex = 35;
            this.labelTitulo.Text = "Detalle del negocio";
            // 
            // labelPanelIzquierda
            // 
            this.labelPanelIzquierda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPanelIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPanelIzquierda.Location = new System.Drawing.Point(0, 0);
            this.labelPanelIzquierda.Name = "labelPanelIzquierda";
            this.labelPanelIzquierda.Size = new System.Drawing.Size(545, 637);
            this.labelPanelIzquierda.TabIndex = 34;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox.Controls.Add(this.buttonGuardarCambios);
            this.groupBox.Controls.Add(this.labelDireccion);
            this.groupBox.Controls.Add(this.textBoxDireccion);
            this.groupBox.Controls.Add(this.labelLineDireccion);
            this.groupBox.Controls.Add(this.labelRUC);
            this.groupBox.Controls.Add(this.textBoxRUC);
            this.groupBox.Controls.Add(this.labelLineRUC);
            this.groupBox.Controls.Add(this.labelNombre);
            this.groupBox.Controls.Add(this.textBoxNombre);
            this.groupBox.Controls.Add(this.labelLineNombre);
            this.groupBox.Controls.Add(this.buttonSubir);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.pictureBoxLogo);
            this.groupBox.Location = new System.Drawing.Point(18, 45);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(508, 253);
            this.groupBox.TabIndex = 36;
            this.groupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logo:";
            // 
            // buttonSubir
            // 
            this.buttonSubir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubir.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSubir.Location = new System.Drawing.Point(10, 207);
            this.buttonSubir.Name = "buttonSubir";
            this.buttonSubir.Size = new System.Drawing.Size(150, 29);
            this.buttonSubir.TabIndex = 2;
            this.buttonSubir.Text = "Subir";
            this.buttonSubir.UseVisualStyleBackColor = false;
            this.buttonSubir.Click += new System.EventHandler(this.buttonSubir_Click);
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.labelDireccion.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelDireccion.Location = new System.Drawing.Point(194, 140);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(71, 23);
            this.labelDireccion.TabIndex = 35;
            this.labelDireccion.Text = "Dirección:";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDireccion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxDireccion.Location = new System.Drawing.Point(195, 172);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(300, 20);
            this.textBoxDireccion.TabIndex = 29;
            // 
            // labelLineDireccion
            // 
            this.labelLineDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineDireccion.Location = new System.Drawing.Point(195, 195);
            this.labelLineDireccion.Name = "labelLineDireccion";
            this.labelLineDireccion.Size = new System.Drawing.Size(300, 1);
            this.labelLineDireccion.TabIndex = 34;
            this.labelLineDireccion.Text = "label2";
            // 
            // labelRUC
            // 
            this.labelRUC.AutoSize = true;
            this.labelRUC.BackColor = System.Drawing.SystemColors.Window;
            this.labelRUC.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelRUC.Location = new System.Drawing.Point(194, 78);
            this.labelRUC.Name = "labelRUC";
            this.labelRUC.Size = new System.Drawing.Size(40, 23);
            this.labelRUC.TabIndex = 33;
            this.labelRUC.Text = "R.U.C:";
            // 
            // textBoxRUC
            // 
            this.textBoxRUC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRUC.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxRUC.Location = new System.Drawing.Point(195, 104);
            this.textBoxRUC.Name = "textBoxRUC";
            this.textBoxRUC.Size = new System.Drawing.Size(300, 20);
            this.textBoxRUC.TabIndex = 28;
            // 
            // labelLineRUC
            // 
            this.labelLineRUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineRUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineRUC.Location = new System.Drawing.Point(195, 127);
            this.labelLineRUC.Name = "labelLineRUC";
            this.labelLineRUC.Size = new System.Drawing.Size(300, 1);
            this.labelLineRUC.TabIndex = 32;
            this.labelLineRUC.Text = "label2";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.SystemColors.Window;
            this.labelNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelNombre.Location = new System.Drawing.Point(191, 16);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(136, 23);
            this.labelNombre.TabIndex = 31;
            this.labelNombre.Text = "Nombre del negocio:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxNombre.Location = new System.Drawing.Point(195, 42);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(300, 20);
            this.textBoxNombre.TabIndex = 27;
            // 
            // labelLineNombre
            // 
            this.labelLineNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelLineNombre.Location = new System.Drawing.Point(195, 65);
            this.labelLineNombre.Name = "labelLineNombre";
            this.labelLineNombre.Size = new System.Drawing.Size(300, 1);
            this.labelLineNombre.TabIndex = 30;
            this.labelLineNombre.Text = "label2";
            // 
            // buttonGuardarCambios
            // 
            this.buttonGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarCambios.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarCambios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardarCambios.Location = new System.Drawing.Point(248, 207);
            this.buttonGuardarCambios.Name = "buttonGuardarCambios";
            this.buttonGuardarCambios.Size = new System.Drawing.Size(200, 30);
            this.buttonGuardarCambios.TabIndex = 36;
            this.buttonGuardarCambios.Text = "Guardar cambios";
            this.buttonGuardarCambios.UseVisualStyleBackColor = false;
            this.buttonGuardarCambios.Click += new System.EventHandler(this.buttonGuardarCambios_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.Location = new System.Drawing.Point(10, 42);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1157, 637);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelPanelIzquierda);
            this.Name = "frmNegocio";
            this.Text = "frmNegocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelPanelIzquierda;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonSubir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelLineDireccion;
        private System.Windows.Forms.Label labelRUC;
        private System.Windows.Forms.TextBox textBoxRUC;
        private System.Windows.Forms.Label labelLineRUC;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelLineNombre;
        private System.Windows.Forms.Button buttonGuardarCambios;
    }
}