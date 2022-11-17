using MongoDB.Driver;
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
    public partial class ShowSpecifications : Form
    {
        public ShowSpecifications()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ComputerModel Computer = DatabaseQueries.FindOneComputer(txtSearch.Text);
            FillData(Computer);
        }

        private void FillData(ComputerModel Computer)
        {
            dgMaintenence.Rows.Clear();
            if(Computer == null) 
            {
                MessageBox.Show("That computer doesn't exist");
                return;
            }
            if(Computer.MaintenanceLog.Count == 1)
            {
                MessageBox.Show("There are not maintenence logs for this computer");
                return;
            }
            for(int i = 1; i < Computer.MaintenanceLog.Count; i++)
            {
                dgMaintenence.Rows.Add(Computer.MaintenanceLog[i]);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgMaintenence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
