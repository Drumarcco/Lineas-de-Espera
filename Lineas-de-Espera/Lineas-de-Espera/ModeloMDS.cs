using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas_de_Espera
{
    public class ModeloMDS : ModeloLineaDeEspera
    {
        #region Valores de L en MDS
        List<ValoresMDS> valoresMDS = new List<ValoresMDS>()
        {
            new ValoresMDS{ rho = 0.1f, s = 1, l = 0.1f },
            new ValoresMDS{ rho = 0.1f, s = 2, l = 0.17f },
            new ValoresMDS{ rho = 0.1f, s = 3, l = 0.25f },
        };
        #endregion

        public ModeloMDS(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio,
            int numeroServidores)
        {
            if (numeroServidores <= 1)
                throw new ArgumentException("El numero de servidores para este modelo debe ser mayor que 1.");
            if (tasaMediaTiempoLlegadaClientes >= tasaMediaTiempoServicio * numeroServidores)
                throw new ArgumentException("El factor de utilizacion debe ser menor que mu para que sea un sistema estable");

            this.numeroServidores = numeroServidores;
            this.tasaMediaTiempoLlegadaClientes = tasaMediaTiempoLlegadaClientes;
            this.tasaMediaTiempoServicio = tasaMediaTiempoServicio;
            setFactorUtilizacion(numeroServidores);
            setNumeroEsperadoClientesSistema(this.factorUtilizacion, numeroServidores);
            setTiempoEsperaEstimadoSistema(this.numeroEsperadoClientesSistema, this.tasaMediaTiempoLlegadaClientes);
            setTiempoEsperaEstimadoFila(this.tiempoEsperaEstimadoSistema, this.tasaMediaTiempoServicio);
            setNumeroEsperadoClientesFila(this.tasaMediaTiempoLlegadaClientes, this.tiempoEsperaEstimadoFila);
            
        }

        public void setNumeroEsperadoClientesSistema(float factorUtilizacion, int numeroServidores)
        {
            this.numeroEsperadoClientesSistema = getNumeroEsperadoClientesSistema(factorUtilizacion, numeroServidores);
        }     

        public float getNumeroEsperadoClientesSistema(float factorUtilizacion, int numeroServidores){
            foreach (ValoresMDS valor in valoresMDS)
            {
                if (valor.rho == factorUtilizacion && valor.s == numeroServidores)
                {
                    return valor.l;
                }
            }
            throw new ArgumentException("El valor de L no se encontró en la lista de coordenadas de la gráfica.");
        }

        public void setTiempoEsperaEstimadoSistema(float numeroEsperadoClientesSistema, float tasaMediaTiempoLlegadaClientes)
        {
            this.tiempoEsperaEstimadoSistema = numeroEsperadoClientesSistema / tasaMediaTiempoLlegadaClientes;
        }

        public void setTiempoEsperaEstimadoFila(float tiempoEsperaEstimadoSistema, float tasaMediaTiempoServicio)
        {
            this.tiempoEsperaEstimadoFila = tiempoEsperaEstimadoSistema - invertirValor(tasaMediaTiempoServicio);
        }

        public void setNumeroEsperadoClientesFila(float tasaMediaTiempoLlegadaClientes, float tiempoEsperaEstimadoFila)
        {
            this.numeroEsperadoClientesFila = tasaMediaTiempoLlegadaClientes * tiempoEsperaEstimadoFila;
        }
       
    }
}
