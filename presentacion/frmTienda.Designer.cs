namespace presentacion
{
    partial class frmTienda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArticulos = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.cboxCampo = new System.Windows.Forms.ComboBox();
            this.cboxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.pboxTienda = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.brnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.txtbFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticulos
            // 
            this.lblArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Location = new System.Drawing.Point(7, 73);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(50, 13);
            this.lblArticulos.TabIndex = 1;
            this.lblArticulos.Text = "Articulos:";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFiltro.Location = new System.Drawing.Point(554, 22);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(100, 20);
            this.btnFiltro.TabIndex = 4;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // cboxCampo
            // 
            this.cboxCampo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxCampo.FormattingEnabled = true;
            this.cboxCampo.Location = new System.Drawing.Point(74, 22);
            this.cboxCampo.Name = "cboxCampo";
            this.cboxCampo.Size = new System.Drawing.Size(100, 21);
            this.cboxCampo.TabIndex = 1;
            this.cboxCampo.SelectedIndexChanged += new System.EventHandler(this.cboxCampo_SelectedIndexChanged);
            // 
            // cboxCriterio
            // 
            this.cboxCriterio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxCriterio.FormattingEnabled = true;
            this.cboxCriterio.Location = new System.Drawing.Point(285, 22);
            this.cboxCriterio.Name = "cboxCriterio";
            this.cboxCriterio.Size = new System.Drawing.Size(100, 21);
            this.cboxCriterio.TabIndex = 2;
            // 
            // lblCampo
            // 
            this.lblCampo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(7, 26);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 7;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(219, 26);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 8;
            this.lblCriterio.Text = "Criterio:";
            // 
            // pboxTienda
            // 
            this.pboxTienda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxTienda.Location = new System.Drawing.Point(672, 18);
            this.pboxTienda.Name = "pboxTienda";
            this.pboxTienda.Size = new System.Drawing.Size(230, 321);
            this.pboxTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxTienda.TabIndex = 9;
            this.pboxTienda.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Location = new System.Drawing.Point(89, 381);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // brnModificar
            // 
            this.brnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.brnModificar.Location = new System.Drawing.Point(335, 381);
            this.brnModificar.Name = "brnModificar";
            this.brnModificar.Size = new System.Drawing.Size(75, 23);
            this.brnModificar.TabIndex = 6;
            this.brnModificar.Text = "Modifcar";
            this.brnModificar.UseVisualStyleBackColor = true;
            this.brnModificar.Click += new System.EventHandler(this.brnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.Location = new System.Drawing.Point(581, 381);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(10, 107);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(646, 232);
            this.dgvArticulos.TabIndex = 5;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // txtbFiltro
            // 
            this.txtbFiltro.Location = new System.Drawing.Point(430, 22);
            this.txtbFiltro.Name = "txtbFiltro";
            this.txtbFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtbFiltro.TabIndex = 3;
            // 
            // frmTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(938, 429);
            this.Controls.Add(this.txtbFiltro);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.brnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pboxTienda);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cboxCriterio);
            this.Controls.Add(this.cboxCampo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.lblArticulos);
            this.MaximizeBox = false;
            this.Name = "frmTienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda";
            this.Load += new System.EventHandler(this.frmTienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxTienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ComboBox cboxCampo;
        private System.Windows.Forms.ComboBox cboxCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.PictureBox pboxTienda;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button brnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TextBox txtbFiltro;
    }
}

