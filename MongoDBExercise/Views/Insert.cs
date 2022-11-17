using MongoDBExercise.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDBExercise.Views
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertValue_Click(object sender, EventArgs e)
        {
            if(txtComputerName.Text == "" || txtRAM.Text == "" || txtStorageUnit.Text == "" || txtMotherBoard.Text == "" || txtGPU.Text == "" || txtGPU.Text == "" || txtPowerSource.Text == "")
            {
                MessageBox.Show("Please fill in the requested fields.");
                return;
            }
            List<string> list = new List<string>()
            {
                ""
            };
            ComputerModel Computer = new ComputerModel
            {
                ComputerName = txtComputerName.Text,
                RAM = txtRAM.Text,
                StorageUnit = txtStorageUnit.Text,
                MotherBoard = txtMotherBoard.Text,
                GPU = txtGPU.Text,
                CPU = txtCPU.Text,
                PowerSource = txtPowerSource.Text,
                MaintenanceLog = list
            };
            DatabaseQueries.InsertOneValue(Computer);
            this.Close();
        }
    }
}
