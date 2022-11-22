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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
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
            clsComputadoraModelo oComputadora = new clsComputadoraModelo
            {
                sNombreComputadora = lblNombreComputadora.Text,
                sRAM = lblRAM.Text,
                sUnidadAlmacenamiento = lblUnidadAlmacenamiento.Text,
                sTarjetaMadre = lblTarjetaMadre.Text,
                sGPU = lblGPU.Text,
                sCPU = lblCPU.Text,
                sFuentePoder = lblFuentePoder.Text
            };
            clsConsultasBD.EliminarComputadora(oComputadora);
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsComputadoraModelo oComputadora = clsConsultasBD.BuscarComputadora(txtNombreBuscar.Text);
            if( oComputadora == null )
            {
                MessageBox.Show("Computadora no existente.");
                return;
            }
            lblNombreComputadora.Text = oComputadora.sNombreComputadora;
            lblRAM.Text = oComputadora.sRAM;
            lblCPU.Text = oComputadora.sCPU;
            lblGPU.Text = oComputadora.sGPU;
            lblTarjetaMadre.Text = oComputadora.sTarjetaMadre;
            lblFuentePoder.Text = oComputadora.sFuentePoder;
            lblUnidadAlmacenamiento.Text = oComputadora.sUnidadAlmacenamiento;
            btnEliminar.Enabled = true;
        }   

        private void lblNameSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
