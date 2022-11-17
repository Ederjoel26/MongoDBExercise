using MongoDB.Driver;
using MongoDBExercise.Models;
using MongoDBExercise.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDBExercise
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            FillData();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void FillData()
        {
            dgComputers.Rows.Clear();
            List<ComputerModel> ComputersList = DatabaseQueries.GetAllValues();
            foreach(ComputerModel computer in ComputersList)
            {
                dgComputers.Rows.Add(computer.ComputerName, computer.RAM, computer.StorageUnit, computer.MotherBoard, computer.GPU, computer.CPU, computer.PowerSource);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert InsertForm = new Insert();
            InsertForm.Show();
        }

        private void dgComputers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                                                                                               
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete DeleteForm = new Delete();
            DeleteForm.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Modify ModifyForm = new Modify();
            ModifyForm.Show();
        }

        private void btnShowSpecifications_Click(object sender, EventArgs e)
        {
            ShowSpecifications ShowSpecificationsForm = new ShowSpecifications();
            ShowSpecificationsForm.Show();
        }
    }
}
