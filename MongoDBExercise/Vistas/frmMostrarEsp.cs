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
    public partial class frmMostrarEsp : Form
    {
        public frmMostrarEsp()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsComputadoraModelo oComputadora = clsConsultasBD.BuscarComputadora(txtBuscar.Text);
            LlenarCampos(oComputadora);
        }

        private void LlenarCampos(clsComputadoraModelo oComputadora)
        {
            gdvMantenimiento.Rows.Clear();
            if( oComputadora == null ) 
            {
                MessageBox.Show("Computadora no existente.");
                return;
            }
            if( oComputadora.lstMantenimiento.Count == 1 )
            {
                MessageBox.Show("No hay historial de mantenimiento para esta computadora.");
                return;
            }
            for( int i = 1; i < oComputadora.lstMantenimiento.Count; i++ )
            {
                gdvMantenimiento.Rows.Add(oComputadora.lstMantenimiento[i]);
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
