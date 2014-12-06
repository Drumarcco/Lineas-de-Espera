using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas_de_Espera
{
    public class ModeloMG1 : ModeloLineaDeEspera
    {
        #region Member Variables
        private float _desviacionEstandar;
        public float desviacionEstandar 
        { 
            get { return _desviacionEstandar;} 
            set { _desviacionEstandar = value;} 
        }
        #endregion

        /// <summary>
        /// Metodo constructor de Modelo MG1
        /// </summary>
        /// <param name="tasaMediaTiempoLlegadaClientes">Lambda</param>
        /// <param name="tasaMediaTiempoServicio">Mu</param>
        /// <param name="desviacionEstandar">d</param>
        public ModeloMG1(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio, float desviacionEstandar)
        {
            if (tasaMediaTiempoLlegadaClientes >= tasaMediaTiempoServicio)
                throw new ArgumentException("Lambda debe ser menor que Mu");
            this.numeroServidores = 1;
            this.tasaMediaTiempoLlegadaClientes = tasaMediaTiempoLlegadaClientes;
            this.tasaMediaTiempoServicio = tasaMediaTiempoServicio;
            this.desviacionEstandar = desviacionEstandar;
            setFactorUtilizacion();

            //Lq
            setNumeroEsperadoClientesFila(this.factorUtilizacion, this.tasaMediaTiempoLlegadaClientes, this.desviacionEstandar);
            //L
            setNumeroEsperadoClientesSistema(this.factorUtilizacion, this.numeroEsperadoClientesFila);
            //Wq
            setTiempoEsperaEstimadoFila(this.tasaMediaTiempoLlegadaClientes, this.numeroEsperadoClientesFila);
            //W
            setTiempoEsperaEstimadoSistema(this.tasaMediaTiempoServicio, this.tiempoEsperaEstimadoFila);
            
        }
        //L
        public void setNumeroEsperadoClientesSistema(float factorUtilizacion, float numeroEsperadoClientesFila)
        {
            float numeroEsperadoClientesSistema = numeroEsperadoClientesFila + factorUtilizacion;
            this.numeroEsperadoClientesSistema = numeroEsperadoClientesSistema;
        }
        //Lq
        public void setNumeroEsperadoClientesFila(float factorUtilizacion, float tasaMediaTiempoLlegadaClientes, float desviacionEstandar)
        {
            float numeroEsperadoClientesFila = (float)(( (Math.Pow(tasaMediaTiempoLlegadaClientes, 2) * Math.Pow(desviacionEstandar, 2)) + Math.Pow(factorUtilizacion, 2)) / (2* (1 - factorUtilizacion)));
            this.numeroEsperadoClientesFila = numeroEsperadoClientesFila;
        }
        //W
        public void setTiempoEsperaEstimadoSistema(float tasaMediaTiempoServicio, float tiempoEsperaEstimadoFila)
        {
            float tiempoEsperaEstimadoSistema = tiempoEsperaEstimadoFila + (1 / tasaMediaTiempoServicio);
            this.tiempoEsperaEstimadoSistema = tiempoEsperaEstimadoSistema;
        }
        //Wq
        public void setTiempoEsperaEstimadoFila(float tasaMediaTiempoLlegadaClientes, float numeroEsperadoClientesFila)
        {
            float tiempoEsperaEstimadoFila = numeroEsperadoClientesFila / tasaMediaTiempoLlegadaClientes;
            this.tiempoEsperaEstimadoFila = tiempoEsperaEstimadoFila;
        }

    }
}
