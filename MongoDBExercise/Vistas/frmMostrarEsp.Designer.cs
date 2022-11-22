namespace MongoDBExercise.Views
{
    partial class frmMostrarEsp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gdvMantenimiento = new System.Windows.Forms.DataGridView();
            this.lblComputer = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.Mantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(162, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Historial de mantenimiento";
            // 
            // gdvMantenimiento
            // 
            this.gdvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvMantenimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mantenimiento});
            this.gdvMantenimiento.Enabled = false;
            this.gdvMantenimiento.Location = new System.Drawing.Point(28, 91);
            this.gdvMantenimiento.Name = "gdvMantenimiento";
            this.gdvMantenimiento.RowHeadersWidth = 23;
            this.gdvMantenimiento.Size = new System.Drawing.Size(434, 274);
            this.gdvMantenimiento.TabIndex = 1;
            this.gdvMantenimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMaintenence_CellContentClick);
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(12, 67);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(182, 13);
            this.lblComputer.TabIndex = 2;
            this.lblComputer.Text = "Nombre de la computadora a buscar:\r\n";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(200, 64);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 20);
            this.txtBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(401, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(200, 371);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(94, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar ventana";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Mantenimiento
            // 
            this.Mantenimiento.HeaderText = "Historial de mantenimiento";
            this.Mantenimiento.Name = "Mantenimiento";
            this.Mantenimiento.Width = 400;
            // 
            // frmMostrarEsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 405);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.gdvMantenimiento);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMostrarEsp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowSpecifications";
            ((System.ComponentModel.ISupportInitialize)(this.gdvMantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView gdvMantenimiento;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mantenimiento;
    }
}