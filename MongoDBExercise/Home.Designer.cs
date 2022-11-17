namespace MongoDBExercise
{
    partial class Home
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
            this.dgComputers = new System.Windows.Forms.DataGridView();
            this.ComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorageUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotherBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PowerSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShowSpecifications = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgComputers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgComputers
            // 
            this.dgComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComputers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComputerName,
            this.RAM,
            this.StorageUnit,
            this.MotherBoard,
            this.GPU,
            this.CPU,
            this.PowerSource});
            this.dgComputers.Enabled = false;
            this.dgComputers.Location = new System.Drawing.Point(12, 84);
            this.dgComputers.Name = "dgComputers";
            this.dgComputers.Size = new System.Drawing.Size(746, 386);
            this.dgComputers.TabIndex = 0;
            this.dgComputers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgComputers_CellContentClick);
            // 
            // ComputerName
            // 
            this.ComputerName.HeaderText = "ComputerName";
            this.ComputerName.Name = "ComputerName";
            // 
            // RAM
            // 
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            // 
            // StorageUnit
            // 
            this.StorageUnit.HeaderText = "StorageUnit";
            this.StorageUnit.Name = "StorageUnit";
            // 
            // MotherBoard
            // 
            this.MotherBoard.HeaderText = "MotherBoard";
            this.MotherBoard.Name = "MotherBoard";
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
            // PowerSource
            // 
            this.PowerSource.HeaderText = "PowerSource";
            this.PowerSource.Name = "PowerSource";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(233, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(260, 55);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Computers";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(51, 487);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(116, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(231, 487);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(117, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(413, 487);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(671, 55);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update table";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShowSpecifications
            // 
            this.btnShowSpecifications.Location = new System.Drawing.Point(595, 487);
            this.btnShowSpecifications.Name = "btnShowSpecifications";
            this.btnShowSpecifications.Size = new System.Drawing.Size(139, 23);
            this.btnShowSpecifications.TabIndex = 6;
            this.btnShowSpecifications.Text = "Show specifications";
            this.btnShowSpecifications.UseVisualStyleBackColor = true;
            this.btnShowSpecifications.Click += new System.EventHandler(this.btnShowSpecifications_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 536);
            this.Controls.Add(this.btnShowSpecifications);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dgComputers);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgComputers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgComputers;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotherBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PowerSource;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnShowSpecifications;
    }
}

