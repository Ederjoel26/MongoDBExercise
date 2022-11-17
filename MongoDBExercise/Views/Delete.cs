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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void lblComputerName_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ComputerModel Computer = new ComputerModel
            {
                ComputerName = lblComputerName.Text,
                RAM = lblRAM.Text,
                StorageUnit = lblStorateUnit.Text,
                MotherBoard = lblMotherBoard.Text,
                GPU = lblGPU.Text,
                CPU = lblCPU.Text,
                PowerSource = lblPowerSource.Text
            };
            DatabaseQueries.DeleteOneValue(Computer);
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ComputerModel computer = DatabaseQueries.FindOneComputer(txtNameSearch.Text);
            if(computer == null)
            {
                MessageBox.Show("That computer doesn't exist");
                return;
            }
            lblComputerName.Text = computer.ComputerName;
            lblRAM.Text = computer.RAM;
            lblCPU.Text = computer.CPU;
            lblGPU.Text = computer.GPU;
            lblMotherBoard.Text = computer.MotherBoard;
            lblPowerSource.Text = computer.PowerSource;
            lblStorateUnit.Text = computer.StorageUnit;
        }

        private void lblNameSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
