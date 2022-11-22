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
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
            LlenarCampos();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void LlenarCampos()
        {
            gdvComputadoras.Rows.Clear();
            List<clsComputadoraModelo> lstComputadoras = clsConsultasBD.ObtenerTodasComputadoras();
            foreach( clsComputadoraModelo oComputer in lstComputadoras )
            {
                gdvComputadoras.Rows.Add(oComputer.sNombreComputadora, oComputer.sRAM, oComputer.sUnidadAlmacenamiento, oComputer.sTarjetaMadre, oComputer.sGPU, oComputer.sCPU, oComputer.sFuentePoder);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertar frmInsertar = new frmInsertar();
            frmInsertar.Show();
        }

        private void dgComputers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                                                                                               
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LlenarCampos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmEliminar frmEliminar = new frmEliminar();
            frmEliminar.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmModificar frmModificar = new frmModificar();
            frmModificar.Show();
        }

        private void btnShowSpecifications_Click(object sender, EventArgs e)
        {
            frmMostrarEsp frmMostrarEsp = new frmMostrarEsp();
            frmMostrarEsp.Show();
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
