using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas_de_Espera
{
    class ModeloMG1 : ModeloLineaDeEspera
    {
        /// <summary>
        /// Metodo constructor de Modelo MG1
        /// </summary>
        /// <param name="tasaMediaTiempoLlegadaClientes">Lambda</param>
        /// <param name="tasaMediaTiempoServicio">Mu</param>
        /// <param name="desviacionEstandar">d</param>
        public ModeloMG1(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio, float desviacionEstandar)
        {
            this.numeroServidores = 1;
            this.tasaMediaTiempoLlegadaClientes = tasaMediaTiempoLlegadaClientes;
            this.tasaMediaTiempoServicio = tasaMediaTiempoServicio;
            this.desviacionEstandar = desviacionEstandar;
            setFactorUtilizacion();
            //L
            setNumeroEsperadoClientesSistema(this.factorUtilizacion, this.numeroEsperadoClientesFila);
            //Lq
            setNumeroEsperadoClientesFila(this.factorUtilizacion, this.tasaMediaTiempoLlegadaClientes, this.desviacionEstandar);
            //W
            setTiempoEsperaEstimadoSistema(this.tasaMediaTiempoServicio, this.tiempoEsperaEstimadoFila);
            //Wq
            setTiempoEsperaEstimadoFila(this.tasaMediaTiempoLlegadaClientes, this.numeroEsperadoClientesFila);
        }
        //L
        public override void setNumeroEsperadoClientesSistema(float factorUtilizacion, float numeroEsperadoClientesFila)
        {
            float numeroEsperadoClientesSistema = numeroEsperadoClientesFila + factorUtilizacion;
            this.numeroEsperadoClientesSistema = numeroEsperadoClientesSistema;
        }
        //Lq
        public override void setNumeroEsperadoClientesFila(float factorUtilizacion, float tasaMediaTiempoLlegadaClientes, float desviacionEstandar)
        {
            float numeroEsperadoClientesFila = (float)((Math.Pow(tasaMediaTiempoLlegadaClientes, 2) * Math.Pow(desviacionEstandar, 2)) + Math.Pow(factorUtilizacion, 2) / 2* (1 - factorUtilizacion));
            this.numeroEsperadoClientesFila = numeroEsperadoClientesFila;
        }
        //W
        public override void setTiempoEsperaEstimadoSistema(float tasaMediaTiempoServicio, float tiempoEsperaEstimadoFila)
        {
            float tiempoEsperaEstimadoSistema = tiempoEsperaEstimadoFila + (1 / tasaMediaTiempoServicio);
            this.tiempoEsperaEstimadoSistema = tiempoEsperaEstimadoSistema;
        }
        //Wq
        public override void setTiempoEsperaEstimadoFila(float tasaMediaTiempoLlegadaClientes, float numeroEsperadoClientesFila)
        {
            float tiempoEsperaEstimadoFila = numeroEsperadoClientesFila / tasaMediaTiempoLlegadaClientes;
            this.tiempoEsperaEstimadoFila = tiempoEsperaEstimadoFila;
        }
    }
}
