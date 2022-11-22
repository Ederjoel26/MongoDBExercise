namespace MongoDBExercise.Views
{
    partial class frmEliminar
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
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFuentePoder = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.lblTarjetaMadre = new System.Windows.Forms.Label();
            this.lblUnidadAlmacenamiento = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblNombreComputadora = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Location = new System.Drawing.Point(200, 48);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(175, 20);
            this.txtNombreBuscar.TabIndex = 0;
            this.txtNombreBuscar.TextChanged += new System.EventHandler(this.txtNameSearch_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(131, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(194, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Eliminar una computadora";
            // 
            // lblNombreBuscar
            // 
            this.lblNombreBuscar.AutoSize = true;
            this.lblNombreBuscar.Location = new System.Drawing.Point(12, 51);
            this.lblNombreBuscar.Name = "lblNombreBuscar";
            this.lblNombreBuscar.Size = new System.Drawing.Size(182, 13);
            this.lblNombreBuscar.TabIndex = 2;
            this.lblNombreBuscar.Text = "Nombre de la computadora a buscar:";
            this.lblNombreBuscar.Click += new System.EventHandler(this.lblNameSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblFuentePoder);
            this.panel1.Controls.Add(this.lblCPU);
            this.panel1.Controls.Add(this.lblGPU);
            this.panel1.Controls.Add(this.lblTarjetaMadre);
            this.panel1.Controls.Add(this.lblUnidadAlmacenamiento);
            this.panel1.Controls.Add(this.lblRAM);
            this.panel1.Controls.Add(this.lblNombreComputadora);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(85, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 216);
            this.panel1.TabIndex = 10;
            // 
            // lblFuentePoder
            // 
            this.lblFuentePoder.AutoSize = true;
            this.lblFuentePoder.Location = new System.Drawing.Point(71, 174);
            this.lblFuentePoder.Name = "lblFuentePoder";
            this.lblFuentePoder.Size = new System.Drawing.Size(68, 13);
            this.lblFuentePoder.TabIndex = 16;
            this.lblFuentePoder.Text = "FuentePoder";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(73, 147);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(29, 13);
            this.lblCPU.TabIndex = 15;
            this.lblCPU.Text = "CPU";
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Location = new System.Drawing.Point(73, 119);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(30, 13);
            this.lblGPU.TabIndex = 14;
            this.lblGPU.Text = "GPU";
            // 
            // lblTarjetaMadre
            // 
            this.lblTarjetaMadre.AutoSize = true;
            this.lblTarjetaMadre.Location = new System.Drawing.Point(73, 91);
            this.lblTarjetaMadre.Name = "lblTarjetaMadre";
            this.lblTarjetaMadre.Size = new System.Drawing.Size(72, 13);
            this.lblTarjetaMadre.TabIndex = 13;
            this.lblTarjetaMadre.Text = "Tarjeta madre";
            // 
            // lblUnidadAlmacenamiento
            // 
            this.lblUnidadAlmacenamiento.AutoSize = true;
            this.lblUnidadAlmacenamiento.Location = new System.Drawing.Point(73, 65);
            this.lblUnidadAlmacenamiento.Name = "lblUnidadAlmacenamiento";
            this.lblUnidadAlmacenamiento.Size = new System.Drawing.Size(121, 13);
            this.lblUnidadAlmacenamiento.TabIndex = 12;
            this.lblUnidadAlmacenamiento.Text = "Unidad almacenamiento";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(73, 41);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(31, 13);
            this.lblRAM.TabIndex = 11;
            this.lblRAM.Text = "RAM";
            // 
            // lblNombreComputadora
            // 
            this.lblNombreComputadora.AutoSize = true;
            this.lblNombreComputadora.Location = new System.Drawing.Point(73, 15);
            this.lblNombreComputadora.Name = "lblNombreComputadora";
            this.lblNombreComputadora.Size = new System.Drawing.Size(109, 13);
            this.lblNombreComputadora.TabIndex = 10;
            this.lblNombreComputadora.Text = "Nombre computadora";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(161, 321);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar computadora";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(381, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 356);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNombreBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNombreBuscar);
            this.Name = "frmEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFuentePoder;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblTarjetaMadre;
        private System.Windows.Forms.Label lblUnidadAlmacenamiento;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblNombreComputadora;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
    }
}