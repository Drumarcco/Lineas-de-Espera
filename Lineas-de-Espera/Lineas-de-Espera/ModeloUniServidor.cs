using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lineas_de_Espera
{
    public partial class ModeloUniServidor : Form
    {
        public ModeloUniServidor(ModeloMM1 modeloMM1)
        {
            InitializeComponent();
            txt_lambda.Text = modeloMM1.tasaMediaTiempoLlegadaClientes.ToString();
            txt_mu.Text = modeloMM1.tasaMediaTiempoServicio.ToString();
            lbl_factorUtilizacion.Text = modeloMM1.factorUtilizacion.ToString();
        }

        public ModeloUniServidor(ModeloMG1 modeloMG1)
        {
            InitializeComponent();
            txt_lambda.Text = modeloMG1.tasaMediaTiempoLlegadaClientes.ToString() ;
            txt_mu.Text = modeloMG1.tasaMediaTiempoServicio.ToString();
            lbl_factorUtilizacion.Text = modeloMG1.factorUtilizacion.ToString();
        }

        public ModeloUniServidor(ModeloMD1 modeloMD1){
            InitializeComponent();
            txt_lambda.Text = modeloMD1.tasaMediaTiempoLlegadaClientes.ToString();
            txt_mu.Text = modeloMD1.tasaMediaTiempoServicio.ToString();
            lbl_factorUtilizacion.Text = modeloMD1.factorUtilizacion.ToString();
        }

        private void txt_mu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lambda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
