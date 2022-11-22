namespace MongoDBExercise
{
    partial class frmInicial
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
            this.gdvComputadoras = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.NombreComputadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadAlmacenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarjetaMadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuentePoder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdvComputadoras)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvComputadoras
            // 
            this.gdvComputadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvComputadoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreComputadora,
            this.RAM,
            this.UnidadAlmacenamiento,
            this.TarjetaMadre,
            this.GPU,
            this.CPU,
            this.FuentePoder});
            this.gdvComputadoras.Enabled = false;
            this.gdvComputadoras.Location = new System.Drawing.Point(12, 84);
            this.gdvComputadoras.Name = "gdvComputadoras";
            this.gdvComputadoras.Size = new System.Drawing.Size(779, 386);
            this.gdvComputadoras.TabIndex = 0;
            this.gdvComputadoras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgComputers_CellContentClick);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(233, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(341, 55);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Computadoras";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(51, 487);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(116, 23);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(231, 487);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(413, 487);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(679, 55);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar tabla";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(595, 487);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(139, 23);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar especificaciones";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnShowSpecifications_Click);
            // 
            // NombreComputadora
            // 
            this.NombreComputadora.HeaderText = "NombreComputadora";
            this.NombreComputadora.Name = "NombreComputadora";
            this.NombreComputadora.Width = 115;
            // 
            // RAM
            // 
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            // 
            // UnidadAlmacenamiento
            // 
            this.UnidadAlmacenamiento.HeaderText = "UnidadAlmacenamiento";
            this.UnidadAlmacenamiento.Name = "UnidadAlmacenamiento";
            this.UnidadAlmacenamiento.Width = 120;
            // 
            // TarjetaMadre
            // 
            this.TarjetaMadre.HeaderText = "TarjetaMadre";
            this.TarjetaMadre.Name = "TarjetaMadre";
            // 
            // GPU
            // 
            this.GPU.HeaderText = "GPU";
            this.GPU.Name = "GPU";
            // 
            // CPU
            // 
            this.CPU.HeaderText = "CPU";
            this.CPU.Name = "CPU";
            // 
            // FuentePoder
            // 
            this.FuentePoder.HeaderText = "FuentePoder";
            this.FuentePoder.Name = "FuentePoder";
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 536);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gdvComputadoras);
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvComputadoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvComputadoras;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreComputadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadAlmacenamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarjetaMadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuentePoder;
    }
}

