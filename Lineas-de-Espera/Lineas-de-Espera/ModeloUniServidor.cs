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
            inicializarTips();
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
            inicializarTips();
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
            inicializarTips();
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
            inicializarTips();
            this.Text = "Modelo M/M/S";
            _modeloMMS = modeloMMS;
            lbl_lambda.Text = modeloMMS.tasaMediaTiempoLlegadaClientes.ToString();
            lbl_mu.Text = modeloMMS.tasaMediaTiempoServicio.ToString();
            lbl_numeroServidores.Text = modeloMMS.numeroServidores.ToString();
            lbl_factorUtilizacion.Text = modeloMMS.factorUtilizacion.ToString();
            lbl_numeroEsperadoClientesSistema.Text = modeloMMS.numeroEsperadoClientesSistema.ToString();
            lbl_numeroEsperadoClientesFila.Text = modeloMMS.numeroEsperadoClientesFila.ToString();
            lbl_tiempoEsperaSistema.Text = modeloMMS.tiempoEsperaEstimadoSistema.ToString();
            lbl_tiempoEsperaCola.Text = modeloMMS.tiempoEsperaEstimadoFila.ToString();
            List<string> listaProbabilidades = modeloMMS.generarListaProbabilidadesClientes(
                modeloMMS.tasaMediaTiempoLlegadaClientes,
                modeloMMS.tasaMediaTiempoServicio,
                modeloMMS.numeroServidores);
            llenarListaProbabilidades(listaProbabilidades);
        }

        public ModeloUniServidor(ModeloMDS modeloMDS)
        {
            InitializeComponent();
            inicializarTips();
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
            PQwt = modelo.calcularProbabilidadTiempoEsperaFilaExcedente(modelo.tasaMediaTiempoLlegadaClientes, modelo.tasaMediaTiempoServicio, modelo.factorUtilizacion, modelo.numeroServidores, tiempo);
            lbl_wMayorT.Text = PWt.ToString();
            lbl_wqMayorT.Text = PQwt.ToString();
        }

        private void calcularProbabilidadesTiempoExcedenteMDS(ModeloMDS modelo, float tiempo)
        {
            float PWt;
            float PQwt;

            PWt = modelo.calcularProbabilidadTiempoEsperaSistemaExcedente(modelo.tasaMediaTiempoLlegadaClientes, modelo.tasaMediaTiempoServicio,
                modelo.factorUtilizacion, modelo.numeroServidores, tiempo);
            PQwt = modelo.calcularProbabilidadTiempoEsperaFilaExcedente(modelo.tasaMediaTiempoLlegadaClientes, modelo.tasaMediaTiempoServicio, modelo.factorUtilizacion, modelo.numeroServidores, tiempo);
            lbl_wMayorT.Text = PWt.ToString();
            lbl_wqMayorT.Text = PQwt.ToString();
        }

        private void inicializarTips()
        {
            tip_universal.SetToolTip(label1, "Factor de utilizacion es la intensidad del trafico en el sistema y siempre debe ser < 1");
            tip_universal.SetToolTip(label2, "Lambda es bla bla bla y se mide en bla bla bla");
            tip_universal.SetToolTip(label3, "Mu es bla bla bla y se mide en bla bla bla");
            tip_universal.SetToolTip(label4, "L es el numero esperado de clientes en el sistema (incluyendo los atendidos)");
            tip_universal.SetToolTip(label5, "Lq es el numero de clientes en la fila (sin los atendidos)");
            tip_universal.SetToolTip(label6, "W es el tiempo de espera estimado en el sistema (incluyendo tiempo de servicio) para cada cliente");
            tip_universal.SetToolTip(label7, "Wq es el tiempo de espera estimado en la fila (excluyendo tiempo de servicio) para cada cliente");
            tip_universal.SetToolTip(label8, "Numero de servidores es la cantidad total de canales de servicio, ya sea en paralelo o en red ");
            tip_universal.SetToolTip(label9, "Tiempo de servicio es el periodo que transcurre desde inicio del servicio para un cliente, hasta el final y puede medirse en segundos, minutos u horas");

        }
        #endregion


        private void txt_costoServidor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float costoServidor = float.Parse(txt_costoServidor.Text);
                if (costoServidor < 0) throw new ArgumentException("El costo por servidor debe ser positivo.");
                int numeroServidores = int.Parse(lbl_numeroServidores.Text);
                float costoServidores = ModeloLineaDeEspera.calcularCostoDeServidores(costoServidor, numeroServidores);
                lbl_costoCalculadoServidores.Text = "$" + costoServidores.ToString();

                float costoEspera = float.Parse(lbl_costoCalculadoEspera.Text.Trim('$'));
                actualizarCostoTotal(costoServidores, costoEspera);

            }
            catch (FormatException)
            {

            }
            catch (ArgumentException aEx)
            {
                txt_costoServidor.Clear();
                MessageBox.Show(aEx.Message);
            }
        }

        private void txt_costoEspera_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float costoTiempo = float.Parse(txt_costoEspera.Text);
                if (costoTiempo < 0) throw new ArgumentException("El costo por espera debe ser positivo.");
                float numeroEsperadoClientesSistema = float.Parse(lbl_numeroEsperadoClientesSistema.Text);
                float costoEspera = ModeloLineaDeEspera.calcularCostoDeTiempoEspera(costoTiempo, numeroEsperadoClientesSistema);
                lbl_costoCalculadoEspera.Text = "$" + costoEspera.ToString();

                float costoServidores = float.Parse(lbl_costoCalculadoServidores.Text.Trim('$'));
                actualizarCostoTotal(costoServidores, costoEspera);
            }
            catch (FormatException)
            {

            }
            catch (ArgumentException aEx)
            {
                txt_costoEspera.Clear();
                MessageBox.Show(aEx.Message);
            }
        }

        private void actualizarCostoTotal(float costoServidores, float costoTiempo)
        {
            float total = costoServidores + costoTiempo;
            lbl_costoTotal.Text = "$" + total.ToString();
        }

        
    }
}
