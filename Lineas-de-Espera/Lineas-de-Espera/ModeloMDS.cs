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
            new ValoresMDS{ rho = 0.1f, s = 4, l = 0.3f },
            new ValoresMDS{ rho = 0.1f, s = 5, l = 0.4f },
            new ValoresMDS{ rho = 0.1f, s = 7, l = 0.6f },
            new ValoresMDS{ rho = 0.1f, s = 10, l = 0.8f },
            new ValoresMDS{ rho = 0.1f, s = 15, l = 1.10f },
            new ValoresMDS{ rho = 0.1f, s = 20, l = 1.4f },
            new ValoresMDS{ rho = 0.1f, s = 25, l = 1.9f },

            new ValoresMDS{ rho = 0.2f, s = 1, l = 0.23f },
            new ValoresMDS{ rho = 0.2f, s = 2, l = 0.35f },
            new ValoresMDS{ rho = 0.2f, s = 3, l = 0.4f },
            new ValoresMDS{ rho = 0.2f, s = 4, l = 0.6f },
            new ValoresMDS{ rho = 0.2f, s = 5, l = 0.8f },
            new ValoresMDS{ rho = 0.2f, s = 7, l = 1.2f },
            new ValoresMDS{ rho = 0.2f, s = 10, l = 1.6f },
            new ValoresMDS{ rho = 0.2f, s = 15, l = 2.0f },
            new ValoresMDS{ rho = 0.2f, s = 20, l = 3.0f },
            new ValoresMDS{ rho = 0.2f, s = 25, l = 4.5f },

            new ValoresMDS{ rho = 0.3f, s = 1, l = 0.3f },
            new ValoresMDS{ rho = 0.3f, s = 2, l = 0.48f },
            new ValoresMDS{ rho = 0.3f, s = 3, l = 0.75f },
            new ValoresMDS{ rho = 0.3f, s = 4, l = 0.9f },
            new ValoresMDS{ rho = 0.3f, s = 5, l = 1.3f },
            new ValoresMDS{ rho = 0.3f, s = 7, l = 1.8f },
            new ValoresMDS{ rho = 0.3f, s = 10, l = 2.5f },
            new ValoresMDS{ rho = 0.3f, s = 15, l = 3.0f },
            new ValoresMDS{ rho = 0.3f, s = 20, l = 4.8f },
            new ValoresMDS{ rho = 0.3f, s = 25, l = 7.0f },

            new ValoresMDS{ rho = 0.4f, s = 1, l = 0.5f },
            new ValoresMDS{ rho = 0.4f, s = 2, l = 0.75f },
            new ValoresMDS{ rho = 0.4f, s = 3, l = 1.2f },
            new ValoresMDS{ rho = 0.4f, s = 4, l = 1.4f },
            new ValoresMDS{ rho = 0.4f, s = 5, l = 1.8f },
            new ValoresMDS{ rho = 0.4f, s = 7, l = 3.0f },
            new ValoresMDS{ rho = 0.4f, s = 10, l = 4.0f },
            new ValoresMDS{ rho = 0.4f, s = 15, l = 5.0f },
            new ValoresMDS{ rho = 0.4f, s = 20, l = 7.5f },
            new ValoresMDS{ rho = 0.4f, s = 25, l = 10.0f },

            new ValoresMDS{ rho = 0.5f, s = 1, l = 0.75f },
            new ValoresMDS{ rho = 0.5f, s = 2, l = 1.0f },
            new ValoresMDS{ rho = 0.5f, s = 3, l = 1.75f },
            new ValoresMDS{ rho = 0.5f, s = 4, l = 1.9f },
            new ValoresMDS{ rho = 0.5f, s = 5, l = 2.5f },
            new ValoresMDS{ rho = 0.5f, s = 7, l = 3.0f },
            new ValoresMDS{ rho = 0.5f, s = 10, l = 5.0f },
            new ValoresMDS{ rho = 0.5f, s = 15, l = 6.5f },
            new ValoresMDS{ rho = 0.5f, s = 20, l = 9.5f },
            new ValoresMDS{ rho = 0.5f, s = 25, l = 13.0f },

            new ValoresMDS{ rho = 0.6f, s = 1, l = 1.0f },
            new ValoresMDS{ rho = 0.6f, s = 2, l = 1.1f },
            new ValoresMDS{ rho = 0.6f, s = 3, l = 1.9f },
            new ValoresMDS{ rho = 0.6f, s = 4, l = 2.1f },
            new ValoresMDS{ rho = 0.6f, s = 5, l = 3.0f },
            new ValoresMDS{ rho = 0.6f, s = 7, l = 4.0f },
            new ValoresMDS{ rho = 0.6f, s = 10, l = 6.0f },
            new ValoresMDS{ rho = 0.6f, s = 15, l = 8.0f },
            new ValoresMDS{ rho = 0.6f, s = 20, l = 12.0f },
            new ValoresMDS{ rho = 0.6f, s = 25, l = 15.0f },
      
            new ValoresMDS{ rho = 0.7f, s = 1, l = 1.2f },
            new ValoresMDS{ rho = 0.7f, s = 2, l = 1.9f },
            new ValoresMDS{ rho = 0.7f, s = 3, l = 2.5f },
            new ValoresMDS{ rho = 0.7f, s = 4, l = 3.0f },
            new ValoresMDS{ rho = 0.7f, s = 5, l = 4.0f },
            new ValoresMDS{ rho = 0.7f, s = 7, l = 6.0f },
            new ValoresMDS{ rho = 0.7f, s = 10, l = 8.0f },
            new ValoresMDS{ rho = 0.7f, s = 15, l = 11.0f },
            new ValoresMDS{ rho = 0.7f, s = 20, l = 15.0f },
            new ValoresMDS{ rho = 0.7f, s = 25, l = 16.0f },

            new ValoresMDS{ rho = 0.8f, s = 1, l = 2.0f },
            new ValoresMDS{ rho = 0.8f, s = 2, l = 3.0f },
            new ValoresMDS{ rho = 0.8f, s = 3, l = 5.0f },
            new ValoresMDS{ rho = 0.8f, s = 4, l = 6.0f },
            new ValoresMDS{ rho = 0.8f, s = 5, l = 7.0f },
            new ValoresMDS{ rho = 0.8f, s = 7, l = 9.0f },
            new ValoresMDS{ rho = 0.8f, s = 10, l = 13.0f },
            new ValoresMDS{ rho = 0.8f, s = 15, l = 15.0f },
            new ValoresMDS{ rho = 0.8f, s = 20, l = 19.0f },
            new ValoresMDS{ rho = 0.8f, s = 25, l = 20.0f },

            new ValoresMDS{ rho = 0.9f, s = 1, l = 5.0f },
            new ValoresMDS{ rho = 0.9f, s = 2, l = 7.0f },
            new ValoresMDS{ rho = 0.9f, s = 3, l = 10.0f },
            new ValoresMDS{ rho = 0.9f, s = 4, l = 13.0f },
            new ValoresMDS{ rho = 0.9f, s = 5, l = 15.0f },
            new ValoresMDS{ rho = 0.9f, s = 7, l = 17.0f },
            new ValoresMDS{ rho = 0.9f, s = 10, l = 20.0f },
            new ValoresMDS{ rho = 0.9f, s = 15, l = 25.0f },
            new ValoresMDS{ rho = 0.9f, s = 20, l = 28.0f },
            new ValoresMDS{ rho = 0.9f, s = 25, l = 30.0f },

            new ValoresMDS{ rho = 1.0f, s = 1, l = 50.0f },
            new ValoresMDS{ rho = 1.0f, s = 2, l = 60.0f },
            new ValoresMDS{ rho = 1.0f, s = 3, l = 65.0f },
            new ValoresMDS{ rho = 1.0f, s = 4, l = 70.0f },
            new ValoresMDS{ rho = 1.0f, s = 5, l = 75.0f },
            new ValoresMDS{ rho = 1.0f, s = 7, l = 80.0f },
            new ValoresMDS{ rho = 1.0f, s = 10, l = 85.0f },
            new ValoresMDS{ rho = 1.0f, s = 15, l = 90.0f },
            new ValoresMDS{ rho = 1.0f, s = 20, l = 95.0f },
            new ValoresMDS{ rho = 1.0f, s = 25, l = 100.0f },
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
