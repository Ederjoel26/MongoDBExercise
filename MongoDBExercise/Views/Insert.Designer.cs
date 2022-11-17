namespace MongoDBExercise.Views
{
    partial class Insert
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
            this.lblComputerName = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblStorageUnit = new System.Windows.Forms.Label();
            this.lblMotherBoard = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblPowerSource = new System.Windows.Forms.Label();
            this.txtComputerName = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtStorageUnit = new System.Windows.Forms.TextBox();
            this.txtMotherBoard = new System.Windows.Forms.TextBox();
            this.txtGPU = new System.Windows.Forms.TextBox();
            this.txtPowerSource = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnInsertValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerName.Location = new System.Drawing.Point(33, 47);
            this.lblComputerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(98, 15);
            this.lblComputerName.TabIndex = 0;
            this.lblComputerName.Text = "Computer Name";
            this.lblComputerName.Click += new System.EventHandler(this.label1_Click);
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
            // lblStorageUnit
            // 
            this.lblStorageUnit.AutoSize = true;
            this.lblStorageUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageUnit.Location = new System.Drawing.Point(30, 115);
            this.lblStorageUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStorageUnit.Name = "lblStorageUnit";
            this.lblStorageUnit.Size = new System.Drawing.Size(75, 15);
            this.lblStorageUnit.TabIndex = 2;
            this.lblStorageUnit.Text = "Storage Unit";
            this.lblStorageUnit.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMotherBoard
            // 
            this.lblMotherBoard.AutoSize = true;
            this.lblMotherBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotherBoard.Location = new System.Drawing.Point(30, 150);
            this.lblMotherBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotherBoard.Name = "lblMotherBoard";
            this.lblMotherBoard.Size = new System.Drawing.Size(82, 15);
            this.lblMotherBoard.TabIndex = 3;
            this.lblMotherBoard.Text = "Mother Board";
            this.lblMotherBoard.Click += new System.EventHandler(this.label4_Click);
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
            // lblPowerSource
            // 
            this.lblPowerSource.AutoSize = true;
            this.lblPowerSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerSource.Location = new System.Drawing.Point(30, 254);
            this.lblPowerSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPowerSource.Name = "lblPowerSource";
            this.lblPowerSource.Size = new System.Drawing.Size(84, 15);
            this.lblPowerSource.TabIndex = 6;
            this.lblPowerSource.Text = "Power Source";
            this.lblPowerSource.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtComputerName
            // 
            this.txtComputerName.Location = new System.Drawing.Point(151, 47);
            this.txtComputerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.Size = new System.Drawing.Size(155, 21);
            this.txtComputerName.TabIndex = 7;
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(151, 81);
            this.txtRAM.Margin = new System.Windows.Forms.Padding(4);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(155, 21);
            this.txtRAM.TabIndex = 8;
            // 
            // txtStorageUnit
            // 
            this.txtStorageUnit.Location = new System.Drawing.Point(151, 115);
            this.txtStorageUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtStorageUnit.Name = "txtStorageUnit";
            this.txtStorageUnit.Size = new System.Drawing.Size(155, 21);
            this.txtStorageUnit.TabIndex = 9;
            // 
            // txtMotherBoard
            // 
            this.txtMotherBoard.Location = new System.Drawing.Point(151, 150);
            this.txtMotherBoard.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotherBoard.Name = "txtMotherBoard";
            this.txtMotherBoard.Size = new System.Drawing.Size(155, 21);
            this.txtMotherBoard.TabIndex = 10;
            // 
            // txtGPU
            // 
            this.txtGPU.Location = new System.Drawing.Point(151, 184);
            this.txtGPU.Margin = new System.Windows.Forms.Padding(4);
            this.txtGPU.Name = "txtGPU";
            this.txtGPU.Size = new System.Drawing.Size(155, 21);
            this.txtGPU.TabIndex = 11;
            // 
            // txtPowerSource
            // 
            this.txtPowerSource.Location = new System.Drawing.Point(151, 254);
            this.txtPowerSource.Margin = new System.Windows.Forms.Padding(4);
            this.txtPowerSource.Name = "txtPowerSource";
            this.txtPowerSource.Size = new System.Drawing.Size(155, 21);
            this.txtPowerSource.TabIndex = 12;
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(151, 218);
            this.txtCPU.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(155, 21);
            this.txtCPU.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(114, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 20);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Insert a computer";
            // 
            // btnInsertValue
            // 
            this.btnInsertValue.Location = new System.Drawing.Point(118, 297);
            this.btnInsertValue.Name = "btnInsertValue";
            this.btnInsertValue.Size = new System.Drawing.Size(103, 25);
            this.btnInsertValue.TabIndex = 15;
            this.btnInsertValue.Text = "Insert computer";
            this.btnInsertValue.UseVisualStyleBackColor = true;
            this.btnInsertValue.Click += new System.EventHandler(this.btnInsertValue_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 341);
            this.Controls.Add(this.btnInsertValue);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.txtPowerSource);
            this.Controls.Add(this.txtGPU);
            this.Controls.Add(this.txtMotherBoard);
            this.Controls.Add(this.txtStorageUnit);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.txtComputerName);
            this.Controls.Add(this.lblPowerSource);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblGPU);
            this.Controls.Add(this.lblMotherBoard);
            this.Controls.Add(this.lblStorageUnit);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblComputerName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.Insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblStorageUnit;
        private System.Windows.Forms.Label lblMotherBoard;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblPowerSource;
        private System.Windows.Forms.TextBox txtComputerName;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtStorageUnit;
        private System.Windows.Forms.TextBox txtMotherBoard;
        private System.Windows.Forms.TextBox txtGPU;
        private System.Windows.Forms.TextBox txtPowerSource;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnInsertValue;
    }
}