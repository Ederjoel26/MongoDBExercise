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
    public partial class frmModificar : Form
    {
        private List<string> lstHistorialAuxiliar = new List<string>();
        public frmModificar()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsComputadoraModelo oComputadora = clsConsultasBD.BuscarComputadora(txtNombreBuscar.Text);
            if( oComputadora == null )
            {
                MessageBox.Show("Computadora no existente.");
                return;
            }
            lblIdAuxiliar.Text = oComputadora.sId;
            txtNombreComputadora.Text = oComputadora.sNombreComputadora;
            txtRAM.Text = oComputadora.sRAM;
            txtCPU.Text = oComputadora.sCPU;
            txtGPU.Text = oComputadora.sGPU;
            txtTarjetaMadre.Text = oComputadora.sTarjetaMadre;
            txtFuentePoder.Text = oComputadora.sFuentePoder;
            txtUnidadAlmacenamiento.Text = oComputadora.sUnidadAlmacenamiento;
            lstHistorialAuxiliar = oComputadora.lstMantenimiento;
            txtRAM.Enabled = true;
            txtCPU.Enabled = true;
            txtGPU.Enabled = true;
            txtTarjetaMadre.Enabled = true;
            txtFuentePoder.Enabled = true;
            txtUnidadAlmacenamiento.Enabled = true;
            txtCambios.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if( txtNombreComputadora.Text == string.Empty || txtRAM.Text == string.Empty || txtUnidadAlmacenamiento.Text == string.Empty || txtTarjetaMadre.Text == string.Empty || txtGPU.Text == string.Empty || txtGPU.Text == string.Empty || txtFuentePoder.Text == string.Empty || txtCambios.Text == string.Empty )
            {
                MessageBox.Show("Favor de llenar todos los campos requeridos.");
                return;
            }
            lstHistorialAuxiliar.Add(txtCambios.Text);
            clsComputadoraModelo oComputadora = new clsComputadoraModelo
            {
                sId = lblIdAuxiliar.Text,
                sNombreComputadora = txtNombreComputadora.Text,
                sCPU = txtCPU.Text,
                sGPU = txtGPU.Text,
                sRAM = txtRAM.Text,
                sTarjetaMadre = txtTarjetaMadre.Text,
                sFuentePoder = txtFuentePoder.Text,
                sUnidadAlmacenamiento = txtUnidadAlmacenamiento.Text,
                lstMantenimiento = lstHistorialAuxiliar
            };
            clsConsultasBD.ActualizarComputadora(oComputadora);
            this.Close();
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }
    }
}
