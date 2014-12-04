using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas_de_Espera
{
    class ModeloMMS : ModeloLineaDeEspera
    {
        /// <summary>
        /// Constructor de modelo MMS de lineas de espera.
        /// </summary>
        /// <param name="tasaMediaTiempoLlegadaClientes">Tasa media de llegada de clientes "lambda".</param>
        /// <param name="tasaMediaTiempoServicio">Tasa media de duracion de servicio "mu".</param>
        /// <param name="numeroServidores">Numero de servidores que atienden las filas.</param>
        public ModeloMMS(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio, int numeroServidores)
        {
            if (tasaMediaTiempoLlegadaClientes >= tasaMediaTiempoServicio)
                throw new ArgumentException("Lambda debe ser menor que mu para que sea un sistema estable", "tasaMediaTiempoLlegadaClientes");
            if (numeroServidores <= 1)
                throw new ArgumentException("El nmero de servidores para este modelo debe ser mayor que 1.", "numeroServidores");
            
            this.numeroServidores = numeroServidores;
            this.tasaMediaTiempoLlegadaClientes = tasaMediaTiempoLlegadaClientes;
            this.tasaMediaTiempoServicio = tasaMediaTiempoServicio;
            setFactorUtilizacion(numeroServidores);
            setNumeroEsperadoClientesFila(this.factorUtilizacion);
            setNumeroEsperadoClientesSistema(this.numeroEsperadoClientesFila);
            setTiempoEsperaEstimadoSistema(this.numeroEsperadoClientesSistema, this.tasaMediaTiempoLlegadaClientes);
            setTiempoEsperaEstimadoFila(this.numeroEsperadoClientesFila, this.tasaMediaTiempoLlegadaClientes);
        }

        public override void setNumeroEsperadoClientesFila(float factorUtilizacion)
        {
            float probabilidadCero = this.probabilidadCeroClientesSistema(factorUtilizacion);
            int factorialServidores = this.factorial(numeroServidores);

            float numeroClientesFila = (float) ( (probabilidadCero * Math.Pow(tasaMediaTiempoLlegadaClientes/tasaMediaTiempoServicio, numeroServidores) * factorUtilizacion) / 
                (factorialServidores * Math.Pow(probabilidadCero, 2)) );

            this.numeroEsperadoClientesFila = numeroClientesFila;
        }

        public override void setNumeroEsperadoClientesSistema(float numeroEsperadoClientesFila)
        {
            float numeroClientesSistema = numeroEsperadoClientesFila + (this.tasaMediaTiempoLlegadaClientes / tasaMediaTiempoServicio);
            this.numeroEsperadoClientesSistema = numeroClientesSistema;
        }

        public override void setTiempoEsperaEstimadoSistema(float numeroEsperadoClientesSistema, float tasaMediaTiempoLlegadaClientes)
        {
            float tiempoEsperaSistema = numeroEsperadoClientesSistema / tasaMediaTiempoLlegadaClientes;
            this.tiempoEsperaEstimadoSistema = tiempoEsperaSistema;
        }

        public override void setTiempoEsperaEstimadoFila(float numeroEsperadoClientesFila, float tasaMediaTiempoLlegadaClientes)
        {
            float tiempoEsperaFila = numeroEsperadoClientesFila / tasaMediaTiempoLlegadaClientes;
            this.tiempoEsperaEstimadoFila = tiempoEsperaFila;
        }
    }
}
