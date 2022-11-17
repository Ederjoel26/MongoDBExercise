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
    public partial class Modify : Form
    {
        private List<string> log = new List<string>();
        public Modify()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ComputerModel computer = DatabaseQueries.FindOneComputer(txtNameSearch.Text);
            if(computer == null )
            {
                MessageBox.Show("That computer doesn't exist");
                return;
            }
            ID.Text = computer.Id;
            txtComputerName.Text = computer.ComputerName;
            txtRAM.Text = computer.RAM;
            txtCPU.Text = computer.CPU;
            txtGPU.Text = computer.GPU;
            txtMotherBoard.Text = computer.MotherBoard;
            txtPowerSource.Text = computer.PowerSource;
            txtStorageUnit.Text = computer.StorageUnit;
            log = computer.MaintenanceLog;
            txtRAM.Enabled = true;
            txtCPU.Enabled = true;
            txtGPU.Enabled = true;
            txtMotherBoard.Enabled = true;
            txtPowerSource.Enabled = true;
            txtStorageUnit.Enabled = true;
            txtReason.Enabled = true;
            btnModify.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(txtComputerName.Text == "" || txtRAM.Text == "" || txtStorageUnit.Text == "" || txtMotherBoard.Text == "" || txtGPU.Text == "" || txtGPU.Text == "" || txtPowerSource.Text == "" || txtReason.Text == "")
            {
                MessageBox.Show("Please fill in the requested fields.");
                return;
            }
            log.Add(txtReason.Text);
            ComputerModel computerUpdated = new ComputerModel
            {
                Id = ID.Text,
                ComputerName = txtComputerName.Text,
                CPU = txtCPU.Text,
                GPU = txtGPU.Text,
                RAM = txtRAM.Text,
                MotherBoard = txtMotherBoard.Text,
                PowerSource = txtPowerSource.Text,
                StorageUnit = txtStorageUnit.Text,
                MaintenanceLog = log
            };
            DatabaseQueries.UpdateOneValue(computerUpdated);
            this.Close();
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }
    }
}
