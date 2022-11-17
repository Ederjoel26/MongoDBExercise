namespace MongoDBExercise.Views
{
    partial class Delete
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
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPowerSource = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.lblMotherBoard = new System.Windows.Forms.Label();
            this.lblStorateUnit = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(146, 48);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(175, 20);
            this.txtNameSearch.TabIndex = 0;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.txtNameSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete a computer";
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.Location = new System.Drawing.Point(12, 51);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(128, 13);
            this.lblNameSearch.TabIndex = 2;
            this.lblNameSearch.Text = "Computer name to search";
            this.lblNameSearch.Click += new System.EventHandler(this.lblNameSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblPowerSource);
            this.panel1.Controls.Add(this.lblCPU);
            this.panel1.Controls.Add(this.lblGPU);
            this.panel1.Controls.Add(this.lblMotherBoard);
            this.panel1.Controls.Add(this.lblStorateUnit);
            this.panel1.Controls.Add(this.lblRAM);
            this.panel1.Controls.Add(this.lblComputerName);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(60, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 216);
            this.panel1.TabIndex = 10;
            // 
            // lblPowerSource
            // 
            this.lblPowerSource.AutoSize = true;
            this.lblPowerSource.Location = new System.Drawing.Point(71, 174);
            this.lblPowerSource.Name = "lblPowerSource";
            this.lblPowerSource.Size = new System.Drawing.Size(72, 13);
            this.lblPowerSource.TabIndex = 16;
            this.lblPowerSource.Text = "Power source";
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
            // lblMotherBoard
            // 
            this.lblMotherBoard.AutoSize = true;
            this.lblMotherBoard.Location = new System.Drawing.Point(73, 91);
            this.lblMotherBoard.Name = "lblMotherBoard";
            this.lblMotherBoard.Size = new System.Drawing.Size(70, 13);
            this.lblMotherBoard.TabIndex = 13;
            this.lblMotherBoard.Text = "Mother board";
            // 
            // lblStorateUnit
            // 
            this.lblStorateUnit.AutoSize = true;
            this.lblStorateUnit.Location = new System.Drawing.Point(73, 65);
            this.lblStorateUnit.Name = "lblStorateUnit";
            this.lblStorateUnit.Size = new System.Drawing.Size(64, 13);
            this.lblStorateUnit.TabIndex = 12;
            this.lblStorateUnit.Text = "Storage unit";
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
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Location = new System.Drawing.Point(73, 15);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(81, 13);
            this.lblComputerName.TabIndex = 10;
            this.lblComputerName.Text = "Computer name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(136, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete computer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(327, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 356);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNameSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameSearch);
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPowerSource;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblMotherBoard;
        private System.Windows.Forms.Label lblStorateUnit;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
    }
}