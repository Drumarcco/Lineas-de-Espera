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
        #region Member Variables
        ModeloMM1 _modeloMM1;
        ModeloMD1 _modeloMD1;
        ModeloMG1 _modeloMG1;
        ModeloMMS _modeloMMS;
        ModeloMDS _modeloMDS;
        #endregion

        #region Constructors
        public ModeloUniServidor(ModeloMM1 modeloMM1)
        {
            InitializeComponent();
            this.Text = "Modelo M/M/1";
            _modeloMM1 = modeloMM1;
            lbl_lambda.Text = modeloMM1.tasaMediaTiempoLlegadaClientes.ToString();
            lbl_mu.Text = modeloMM1.tasaMediaTiempoServicio.ToString();
            lbl_numeroServidores.Text = modeloMM1.numeroServidores.ToString();
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
            _modeloMG1 = modeloMG1;
            lbl_lambda.Text = modeloMG1.tasaMediaTiempoLlegadaClientes.ToString() ;
            lbl_mu.Text = modeloMG1.tasaMediaTiempoServicio.ToString();
            lbl_numeroServidores.Text = modeloMG1.numeroServidores.ToString();
            lbl_factorUtilizacion.Text = modeloMG1.factorUtilizacion.ToString();
            lbl_numeroEsperadoClientesSistema.Text = modeloMG1.numeroEsperadoClientesSistema.ToString();
            lbl_numeroEsperadoClientesFila.Text = modeloMG1.numeroEsperadoClientesFila.ToString();
            lbl_tiempoEsperaSistema.Text = modeloMG1.tiempoEsperaEstimadoSistema.ToString();
            lbl_tiempoEsperaCola.Text = modeloMG1.tiempoEsperaEstimadoFila.ToString();
            List<string> listaProbabilidades = modeloMG1.generarListaProbabilidadesClientes(modeloMG1.factorUtilizacion);
            llenarListaProbabilidades(listaProbabilidades);
            lbl_tituloDesviacionEstandar.Visible = true;
            lbl_desviacionEstandar.Visible = true;
            lbl_desviacionEstandar.Text = modeloMG1.desviacionEstandar.ToString();
        }

        public ModeloUniServidor(ModeloMD1 modeloMD1){
            InitializeComponent();
            this.Text = "Modelo M/D/1";
            _modeloMD1 = modeloMD1;
            lbl_lambda.Text = modeloMD1.tasaMediaTiempoLlegadaClientes.ToString();
            lbl_mu.Text = modeloMD1.tasaMediaTiempoServicio.ToString();
            lbl_numeroServidores.Text = modeloMD1.numeroServidores.ToString();
            lbl_factorUtilizacion.Text = modeloMD1.factorUtilizacion.ToString();
            lbl_numeroEsperadoClientesSistema.Text = modeloMD1.numeroEsperadoClientesSistema.ToString();
            lbl_numeroEsperadoClientesFila.Text = modeloMD1.numeroEsperadoClientesFila.ToString();
            lbl_tiempoEsperaSistema.Text = modeloMD1.tiempoEsperaEstimadoSistema.ToString();
            lbl_tiempoEsperaCola.Text = modeloMD1.tiempoEsperaEstimadoFila.ToString();
            List<string> listaProbabilidades = modeloMD1.generarListaProbabilidadesClientes(modeloMD1.factorUtilizacion);
            llenarListaProbabilidades(listaProbabilidades);
        }

        public ModeloUniServidor(ModeloMMS modeloMMS)
        {
            InitializeComponent();
            this.Text = "Modelo M/M/S";
            _modeloMMS = modeloMMS;
            lbl_lambda.Text = modeloMMS.tasaMediaTiempoLlegadaClientes.ToString();
            lbl_mu.Text = modeloMMS.tasaMediaTiempoServicio.ToString();
            lbl_numeroServidores.Text = modeloMMS.numeroServidores.ToString();
            lbl_factorUtilizacion.Text = modeloMMS.factorUtilizacion.ToString();
            lbl_numeroEsperadoClientesSistema.Text = modeloMMS.numeroEsperadoClientesSistema.ToString();
            lbl_numeroEsperadoClientesFila.Text = modeloMMS.numeroEsperadoClientesFila.ToString();
            lbl_tiempoEsperaSistema.Text = modeloMMS.numeroEsperadoClientesSistema.ToString();
            lbl_tiempoEsperaCola.Text = modeloMMS.numeroEsperadoClientesFila.ToString();
            List<string> listaProbabilidades = modeloMMS.generarListaProbabilidadesClientes(
                modeloMMS.tasaMediaTiempoLlegadaClientes,
                modeloMMS.tasaMediaTiempoServicio,
                modeloMMS.numeroServidores);
            llenarListaProbabilidades(listaProbabilidades);
        }

        public ModeloUniServidor(ModeloMDS modeloMDS)
        {
            InitializeComponent();
            this.Text = "Modelo M/D/S";
            _modeloMDS = modeloMDS;
            lbl_lambda.Text = modeloMDS.tasaMediaTiempoLlegadaClientes.ToString();
            lbl_mu.Text = modeloMDS.tasaMediaTiempoServicio.ToString();
            lbl_numeroServidores.Text = modeloMDS.numeroServidores.ToString();
            lbl_factorUtilizacion.Text = modeloMDS.factorUtilizacion.ToString();
            lbl_numeroEsperadoClientesSistema.Text = modeloMDS.numeroEsperadoClientesSistema.ToString();
            lbl_numeroEsperadoClientesFila.Text = modeloMDS.numeroEsperadoClientesFila.ToString();
            lbl_tiempoEsperaSistema.Text = modeloMDS.tiempoEsperaEstimadoSistema.ToString();
            lbl_tiempoEsperaCola.Text = modeloMDS.tiempoEsperaEstimadoFila.ToString();
            List<string> listaProbabilidades = modeloMDS.generarListaProbabilidadesClientes(
                modeloMDS.tasaMediaTiempoLlegadaClientes,
                modeloMDS.tasaMediaTiempoServicio,
                modeloMDS.numeroServidores);
            llenarListaProbabilidades(listaProbabilidades);
        }
        #endregion

        #region Event Handlers
        private void txt_mu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lambda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tiempo_TextChanged(object sender, EventArgs e)
        {
            if (txt_Tiempo.Text != "")
            {
                try
                {
                    float tiempo = float.Parse(txt_Tiempo.Text);
                    if (tiempo < 0) throw new ArgumentException("El tiempo no puede ser negativo.");
                    calcularProbabilidadesTiempoExcedente(tiempo);
                }
                catch (FormatException)
                {
                    MessageBox.Show("El formato del texto introducido es incorrecto.");
                    txt_Tiempo.Clear();
                }
                catch (ArgumentException argException)
                {
                    MessageBox.Show(argException.Message);
                }
            }
        }
        #endregion

        #region Other Methods
        private void llenarListaProbabilidades(List<string> listaProbabilidades)
        {
            foreach (string probabilidad in listaProbabilidades)
            {
                lbx_probabilidadNClientes.Items.Add(probabilidad);
            }
        }
        private void calcularProbabilidadesTiempoExcedente(float tiempo)
        {
            if (_modeloMM1 != null)
            {
                calcularProbabilidadesTiempoExcedenteMM1(_modeloMM1, tiempo);
            }
            else if (_modeloMG1 != null)
            {
                calcularProbabilidadesTiempoExcedenteMG1(_modeloMG1, tiempo);
            }
            else if (_modeloMD1 != null)
            {
                calcularProbabilidadesTiempoExcedenteMD1(_modeloMD1, tiempo);
            }
            else if (_modeloMMS != null)
            {
                calcularProbabilidadesTiempoExcedenteMMS(_modeloMMS, tiempo);
            }
            else if (_modeloMDS != null)
            {
                calcularProbabilidadesTiempoExcedenteMDS(_modeloMDS, tiempo);
            }
        }

        private void calcularProbabilidadesTiempoExcedenteMM1(ModeloMM1 modelo, float tiempo)
        {
            float PWt;
            float PQwt;

            PWt = modelo.calcularProbabilidadTiempoEsperaSistemaExcedente(modelo.tasaMediaTiempoServicio, modelo.factorUtilizacion, tiempo);
            PQwt = modelo.calcularProbabilidadTiempoEsperaFilaExcedente(modelo.factorUtilizacion, modelo.tasaMediaTiempoServicio, tiempo);
            lbl_wMayorT.Text = PWt.ToString();
            lbl_wqMayorT.Text = PQwt.ToString();
        }

        private void calcularProbabilidadesTiempoExcedenteMG1(ModeloMG1 modelo, float tiempo)
        {
            float PWt;
            float PQwt;

            PWt = modelo.calcularProbabilidadTiempoEsperaSistemaExcedente(modelo.tasaMediaTiempoServicio, modelo.factorUtilizacion, tiempo);
            PQwt = modelo.calcularProbabilidadTiempoEsperaFilaExcedente(modelo.factorUtilizacion, modelo.tasaMediaTiempoServicio, tiempo);
            lbl_wMayorT.Text = PWt.ToString();
            lbl_wqMayorT.Text = PQwt.ToString();
        }

        private void calcularProbabilidadesTiempoExcedenteMD1(ModeloMD1 modelo, float tiempo)
        {
            float PWt;
            float PQwt;

            PWt = modelo.calcularProbabilidadTiempoEsperaSistemaExcedente(modelo.tasaMediaTiempoServicio, modelo.factorUtilizacion, tiempo);
            PQwt = modelo.calcularProbabilidadTiempoEsperaFilaExcedente(modelo.tasaMediaTiempoServicio, modelo.factorUtilizacion, tiempo);
            lbl_wMayorT.Text = PWt.ToString();
            lbl_wqMayorT.Text = PQwt.ToString();
        }

        private void calcularProbabilidadesTiempoExcedenteMMS(ModeloMMS modelo, float tiempo)
        {
            float PWt;
            float PQwt;

            PWt = modelo.calcularProbabilidadTiempoEsperaSistemaExcedente(modelo.tasaMediaTiempoLlegadaClientes, modelo.tasaMediaTiempoServicio, 
                modelo.factorUtilizacion, modelo.numeroServidores, tiempo);
            lbl_wMayorT.Text = PWt.ToString();
        }

        private void calcularProbabilidadesTiempoExcedenteMDS(ModeloMDS modelo, float tiempo)
        {
            float PWt;
            float PQwt;

            PWt = modelo.calcularProbabilidadTiempoEsperaSistemaExcedente(modelo.tasaMediaTiempoLlegadaClientes, modelo.tasaMediaTiempoServicio,
                modelo.factorUtilizacion, modelo.numeroServidores, tiempo);
            lbl_wMayorT.Text = PWt.ToString();
        }
        #endregion

        
    }
}
