namespace MongoDBExercise.Views
{
    partial class frmInsertar
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
            this.lblNombreComputadora = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblUnidadAlmacenamiento = new System.Windows.Forms.Label();
            this.lblTarjetaMadre = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblFuentePoder = new System.Windows.Forms.Label();
            this.txtNombreComputadora = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtUnidadAlmacenamiento = new System.Windows.Forms.TextBox();
            this.txtTarjetaMadre = new System.Windows.Forms.TextBox();
            this.txtGPU = new System.Windows.Forms.TextBox();
            this.txtFuentePoder = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreComputadora
            // 
            this.lblNombreComputadora.AutoSize = true;
            this.lblNombreComputadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreComputadora.Location = new System.Drawing.Point(30, 50);
            this.lblNombreComputadora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreComputadora.Name = "lblNombreComputadora";
            this.lblNombreComputadora.Size = new System.Drawing.Size(128, 15);
            this.lblNombreComputadora.TabIndex = 0;
            this.lblNombreComputadora.Text = "Nombre computadora";
            this.lblNombreComputadora.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(33, 81);
            this.lblRAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(34, 15);
            this.lblRAM.TabIndex = 1;
            this.lblRAM.Text = "RAM";
            this.lblRAM.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblUnidadAlmacenamiento
            // 
            this.lblUnidadAlmacenamiento.AutoSize = true;
            this.lblUnidadAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadAlmacenamiento.Location = new System.Drawing.Point(30, 115);
            this.lblUnidadAlmacenamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidadAlmacenamiento.Name = "lblUnidadAlmacenamiento";
            this.lblUnidadAlmacenamiento.Size = new System.Drawing.Size(143, 15);
            this.lblUnidadAlmacenamiento.TabIndex = 2;
            this.lblUnidadAlmacenamiento.Text = "Unidad almacenamiento";
            this.lblUnidadAlmacenamiento.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTarjetaMadre
            // 
            this.lblTarjetaMadre.AutoSize = true;
            this.lblTarjetaMadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjetaMadre.Location = new System.Drawing.Point(30, 150);
            this.lblTarjetaMadre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarjetaMadre.Name = "lblTarjetaMadre";
            this.lblTarjetaMadre.Size = new System.Drawing.Size(84, 15);
            this.lblTarjetaMadre.TabIndex = 3;
            this.lblTarjetaMadre.Text = "Tarjeta madre";
            this.lblTarjetaMadre.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPU.Location = new System.Drawing.Point(30, 184);
            this.lblGPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(33, 15);
            this.lblGPU.TabIndex = 4;
            this.lblGPU.Text = "GPU";
            this.lblGPU.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(30, 218);
            this.lblCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(32, 15);
            this.lblCPU.TabIndex = 5;
            this.lblCPU.Text = "CPU";
            this.lblCPU.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblFuentePoder
            // 
            this.lblFuentePoder.AutoSize = true;
            this.lblFuentePoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuentePoder.Location = new System.Drawing.Point(30, 254);
            this.lblFuentePoder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuentePoder.Name = "lblFuentePoder";
            this.lblFuentePoder.Size = new System.Drawing.Size(80, 15);
            this.lblFuentePoder.TabIndex = 6;
            this.lblFuentePoder.Text = "Fuente poder";
            this.lblFuentePoder.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNombreComputadora
            // 
            this.txtNombreComputadora.Location = new System.Drawing.Point(181, 47);
            this.txtNombreComputadora.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreComputadora.Name = "txtNombreComputadora";
            this.txtNombreComputadora.Size = new System.Drawing.Size(155, 21);
            this.txtNombreComputadora.TabIndex = 7;
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(181, 78);
            this.txtRAM.Margin = new System.Windows.Forms.Padding(4);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(155, 21);
            this.txtRAM.TabIndex = 8;
            // 
            // txtUnidadAlmacenamiento
            // 
            this.txtUnidadAlmacenamiento.Location = new System.Drawing.Point(181, 112);
            this.txtUnidadAlmacenamiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnidadAlmacenamiento.Name = "txtUnidadAlmacenamiento";
            this.txtUnidadAlmacenamiento.Size = new System.Drawing.Size(155, 21);
            this.txtUnidadAlmacenamiento.TabIndex = 9;
            // 
            // txtTarjetaMadre
            // 
            this.txtTarjetaMadre.Location = new System.Drawing.Point(181, 147);
            this.txtTarjetaMadre.Margin = new System.Windows.Forms.Padding(4);
            this.txtTarjetaMadre.Name = "txtTarjetaMadre";
            this.txtTarjetaMadre.Size = new System.Drawing.Size(155, 21);
            this.txtTarjetaMadre.TabIndex = 10;
            // 
            // txtGPU
            // 
            this.txtGPU.Location = new System.Drawing.Point(181, 181);
            this.txtGPU.Margin = new System.Windows.Forms.Padding(4);
            this.txtGPU.Name = "txtGPU";
            this.txtGPU.Size = new System.Drawing.Size(155, 21);
            this.txtGPU.TabIndex = 11;
            // 
            // txtFuentePoder
            // 
            this.txtFuentePoder.Location = new System.Drawing.Point(181, 251);
            this.txtFuentePoder.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuentePoder.Name = "txtFuentePoder";
            this.txtFuentePoder.Size = new System.Drawing.Size(155, 21);
            this.txtFuentePoder.TabIndex = 12;
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(181, 215);
            this.txtCPU.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(155, 21);
            this.txtCPU.TabIndex = 13;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(92, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 20);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Insertar una computadora";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(110, 289);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(138, 25);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar computadora";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertValue_Click);
            // 
            // frmInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 341);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.txtFuentePoder);
            this.Controls.Add(this.txtGPU);
            this.Controls.Add(this.txtTarjetaMadre);
            this.Controls.Add(this.txtUnidadAlmacenamiento);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.txtNombreComputadora);
            this.Controls.Add(this.lblFuentePoder);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblGPU);
            this.Controls.Add(this.lblTarjetaMadre);
            this.Controls.Add(this.lblUnidadAlmacenamiento);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblNombreComputadora);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInsertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.Insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreComputadora;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblUnidadAlmacenamiento;
        private System.Windows.Forms.Label lblTarjetaMadre;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblFuentePoder;
        private System.Windows.Forms.TextBox txtNombreComputadora;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtUnidadAlmacenamiento;
        private System.Windows.Forms.TextBox txtTarjetaMadre;
        private System.Windows.Forms.TextBox txtGPU;
        private System.Windows.Forms.TextBox txtFuentePoder;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnInsertar;
    }
}