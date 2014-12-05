using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas_de_Espera
{
    class ModeloMD1 : ModeloLineaDeEspera
    {
        /// <summary>
        /// Metodo constructor de Modelo MD1
        /// </summary>
        /// <param name="tasaMediaTiempoLlegadaClientes">Lambda</param>
        /// <param name="tasaMediaTiempoServicio">Mu</param>
        public ModeloMD1(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio)
        {
            if (tasaMediaTiempoLlegadaClientes >= tasaMediaTiempoServicio)
                throw new ArgumentException("Lambda debe ser menor que mu");
            this.numeroServidores = 1;
            this.tasaMediaTiempoLlegadaClientes = tasaMediaTiempoLlegadaClientes;
            this.tasaMediaTiempoServicio = tasaMediaTiempoServicio;
            setFactorUtilizacion();
            setNumeroEsperadoClientesSistema(this.factorUtilizacion, this.numeroEsperadoClientesFila);
            setNumeroEsperadoClientesFila(this.factorUtilizacion);
            setTiempoEsperaEstimadoSistema(this.factorUtilizacion, this.tiempoEsperaEstimadoFila);
            setTiempoEsperaEstimadoFila(this.tasaMediaTiempoLlegadaClientes, this.numeroEsperadoClientesFila);

        }

        public void setNumeroEsperadoClientesSistema(float factorUtilizacion, float numeroEsperadoClientesFila)
        {
            float numeroEsperadoClientes;
            numeroEsperadoClientes = factorUtilizacion + numeroEsperadoClientesFila;
            this.numeroEsperadoClientesSistema = numeroEsperadoClientes;
        }

        public void setNumeroEsperadoClientesFila(float factorUtilizacion)
        {

            float numeroEsperadoClientes;
            numeroEsperadoClientes = (float)(Math.Pow(factorUtilizacion, 2) / (2 * (1 - factorUtilizacion)));
            this.numeroEsperadoClientesFila = numeroEsperadoClientes;
        }

        public void setTiempoEsperaEstimadoSistema(float factorUtilizacion, float tiempoEsperaEstimadoFila)
        {
            float tiempoEsperaEstimado;
            tiempoEsperaEstimado = tiempoEsperaEstimadoFila + factorUtilizacion;
            this.tiempoEsperaEstimadoSistema = tiempoEsperaEstimado;
        }

        public void setTiempoEsperaEstimadoFila(float tasaMediaTiempoLlegadaClientes, float numeroEsperadoClientesFila)
        {
            float tiempoEsperaEstimado;
            tiempoEsperaEstimado = tiempoEsperaEstimadoFila / tasaMediaTiempoLlegadaClientes;
            this.tiempoEsperaEstimadoFila = tiempoEsperaEstimado;
        }
    }
}