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
            this.Text = "Modelo M/M/1";
            txt_lambda.Text = modeloMM1.tasaMediaTiempoLlegadaClientes.ToString();
            txt_mu.Text = modeloMM1.tasaMediaTiempoServicio.ToString();
            lbl_factorUtilizacion.Text = modeloMM1.factorUtilizacion.ToString();
            lbl_numeroEsperadoClientesSistema.Text = modeloMM1.numeroEsperadoClientesSistema.ToString();
            lbl_numeroEsperadoClientesFila.Text = modeloMM1.numeroEsperadoClientesFila.ToString();
            lbl_tiempoEsperaSistema.Text = modeloMM1.tiempoEsperaEstimadoSistema.ToString();
            lbl_tiempoEsperaCola.Text = modeloMM1.tiempoEsperaEstimadoFila.ToString();
            List<string> listaProbabilidades = modeloMM1.generarListaProbabilidadesClientes(modeloMM1.factorUtilizacion);
            llenarListaProbabilidades(listaProbabilidades);
        }

        public ModeloUniServidor(ModeloMG1 modeloMG1)
        {
            InitializeComponent();
            this.Text = "Modelo M/G/1";
            txt_lambda.Text = modeloMG1.tasaMediaTiempoLlegadaClientes.ToString() ;
            txt_mu.Text = modeloMG1.tasaMediaTiempoServicio.ToString();
            lbl_factorUtilizacion.Text = modeloMG1.factorUtilizacion.ToString();
            lbl_numeroEsperadoClientesSistema.Text = modeloMG1.numeroEsperadoClientesSistema.ToString();
            lbl_numeroEsperadoClientesFila.Text = modeloMG1.numeroEsperadoClientesFila.ToString();
            lbl_tiempoEsperaSistema.Text = modeloMG1.tiempoEsperaEstimadoSistema.ToString();
            lbl_tiempoEsperaCola.Text = modeloMG1.tiempoEsperaEstimadoFila.ToString();
            List<string> listaProbabilidades = modeloMG1.generarListaProbabilidadesClientes(modeloMG1.factorUtilizacion);
            llenarListaProbabilidades(listaProbabilidades);
        }

        public ModeloUniServidor(ModeloMD1 modeloMD1){
            InitializeComponent();
            this.Text = "Modelo M/D/1";
            txt_lambda.Text = modeloMD1.tasaMediaTiempoLlegadaClientes.ToString();
            txt_mu.Text = modeloMD1.tasaMediaTiempoServicio.ToString();
            lbl_factorUtilizacion.Text = modeloMD1.factorUtilizacion.ToString();
            lbl_numeroEsperadoClientesSistema.Text = modeloMD1.numeroEsperadoClientesSistema.ToString();
            lbl_numeroEsperadoClientesFila.Text = modeloMD1.numeroEsperadoClientesFila.ToString();
            lbl_tiempoEsperaSistema.Text = modeloMD1.tiempoEsperaEstimadoSistema.ToString();
            lbl_tiempoEsperaCola.Text = modeloMD1.tiempoEsperaEstimadoFila.ToString();
            List<string> listaProbabilidades = modeloMD1.generarListaProbabilidadesClientes(modeloMD1.factorUtilizacion);
            llenarListaProbabilidades(listaProbabilidades);
        }

        private void llenarListaProbabilidades(List<string> listaProbabilidades)
        {
            foreach (string probabilidad in listaProbabilidades){
                lbx_probabilidadNClientes.Items.Add(probabilidad);
            }
        }

        private void txt_mu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lambda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
