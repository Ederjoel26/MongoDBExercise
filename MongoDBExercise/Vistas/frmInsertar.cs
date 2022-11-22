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
    public partial class frmInsertar : Form
    {
        public frmInsertar()
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
            if( txtNombreComputadora.Text == string.Empty || txtRAM.Text == string.Empty || txtUnidadAlmacenamiento.Text == string.Empty || txtTarjetaMadre.Text == string.Empty || txtGPU.Text == string.Empty || txtGPU.Text == string.Empty || txtFuentePoder.Text == string.Empty )
            {
                MessageBox.Show("Please fill in the requested fields.");
                return;
            }
            List<string> lstAuxiliar = new List<string>()
            {
                ""
            };
            clsComputadoraModelo Computer = new clsComputadoraModelo
            {
                sNombreComputadora = txtNombreComputadora.Text,
                sRAM = txtRAM.Text,
                sUnidadAlmacenamiento = txtUnidadAlmacenamiento.Text,
                sTarjetaMadre = txtTarjetaMadre.Text,
                sGPU = txtGPU.Text,
                sCPU = txtCPU.Text,
                sFuentePoder = txtFuentePoder.Text,
                lstMantenimiento = lstAuxiliar
            };
            clsConsultasBD.InsertarComputadora(Computer);
            this.Close();
        }
    }
}
