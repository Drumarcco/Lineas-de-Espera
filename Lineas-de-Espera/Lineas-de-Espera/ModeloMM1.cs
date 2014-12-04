using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas_de_Espera
{
    class ModeloMM1 : ModeloLineaDeEspera
    {
        /// <summary>
        /// Constructor de Modelo MM1 de Lineas de Espera.
        /// </summary>
        /// <param name="tasaMediaTiempoLlegadaClientes">Tasa media de llegada de clientes que ingresan al sistema "lambda"</param>
        /// <param name="tasaMediaTiempoServicio">Tasa media de servicio por unidad de tiempo "mu"</param>
        public ModeloMM1(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio )
        {
            if (tasaMediaTiempoLlegadaClientes >= tasaMediaTiempoServicio)
            {
                throw new ArgumentException("Lambda debe ser menor que Mu", "tasaMediaTiempoLlegadaClientes");
            }
            this.numeroServidores = 1;
            this.tasaMediaTiempoLlegadaClientes = tasaMediaTiempoLlegadaClientes;
            this.tasaMediaTiempoServicio = tasaMediaTiempoServicio;
            setFactorUtilizacion();
            setNumeroEsperadoClientesSistema(this.factorUtilizacion);
            setNumeroEsperadoClientesFila(this.factorUtilizacion);
            setTiempoEsperaEstimadoSistema(this.tasaMediaTiempoServicio, this.tasaMediaTiempoLlegadaClientes);
            setTiempoEsperaEstimadoFila(this.tasaMediaTiempoLlegadaClientes, this.tasaMediaTiempoServicio);
        }
        //Numero esperado de clientes valor de L
        public override void setNumeroEsperadoClientesSistema(float factorUtilizacion)
        {
            float numeroEsperadoClientes;
            numeroEsperadoClientes = factorUtilizacion / (1 - factorUtilizacion);
            this.numeroEsperadoClientesSistema = numeroEsperadoClientes;
        }

        public override void setNumeroEsperadoClientesFila(float factorUtilizacion)
        {
            float numeroEsperadoClientes;
            numeroEsperadoClientes = (float) (Math.Pow(factorUtilizacion, 2) / (1 - factorUtilizacion));
            this.numeroEsperadoClientesFila = numeroEsperadoClientes;
        }

        public override void setTiempoEsperaEstimadoSistema(float tasaMediaTiempoServicio, float tasaMediaTiempoLlegadaClientes)
        {
            float tiempoEsperaEstimado;
            tiempoEsperaEstimado = 1 / (tasaMediaTiempoServicio - tasaMediaTiempoLlegadaClientes);
            this.tiempoEsperaEstimadoSistema = tiempoEsperaEstimado;
        }

        public override void setTiempoEsperaEstimadoFila(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio)
        {
            float tiempoEsperaEstimado;
            tiempoEsperaEstimado = tasaMediaTiempoLlegadaClientes / (tasaMediaTiempoServicio * (tasaMediaTiempoServicio - tasaMediaTiempoLlegadaClientes));
            this.tiempoEsperaEstimadoFila = tiempoEsperaEstimado;
        }

    }
}
