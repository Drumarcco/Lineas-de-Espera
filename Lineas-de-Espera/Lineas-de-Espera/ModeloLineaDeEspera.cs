using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas_de_Espera
{
    abstract class ModeloLineaDeEspera
    {
        #region Member Variables
        private float _tasaMediaTiempoLlegadaClientes;  // Lambda λ
        private float _tasaMediaTiempoServicio;         // Mu μ
        private float _numeroEsperadoClientesSistema;   // L
        private float _numeroEsperadoClientesFila;      // Lq
        private float _tiempoEsperaEstimadoSistema;     // W
        private float _tiempoEsperaEstimadoFila;        // Wq
        private float _numeroServidores;                // s
        private float _factorUtilizacion;               // Rho
        #endregion

        #region Getters & Setters
        public float tasaMediaTiempoLlegadaClientes 
        { 
            get { return _tasaMediaTiempoLlegadaClientes; }
            set { _tasaMediaTiempoLlegadaClientes = value; }
        }   
        public float tasaMediaTiempoServicio 
        {
            get { return _tasaMediaTiempoServicio; }
            set { _tasaMediaTiempoServicio = value; }
        }
        public float numeroEsperadoClientesSistema
        {
            get { return _numeroEsperadoClientesSistema; }
            set;
        }

        public float numeroEsperadoClientesFila
        {
            get { return _numeroEsperadoClientesFila; }
            set;
        }

        public float tiempoEsperaEstimadoSistema
        {
            get { return _tiempoEsperaEstimadoSistema; }
            set;
        }

        public float tiempoEsperaEstimadoFila
        {
            get { return _tiempoEsperaEstimadoFila; }
            set;
        }

        public float numeroServidores
        {
            get { return _numeroServidores; }
            set { _numeroServidores = value; }
        }

        public float factorUtilizacion { get; private set; }

        public void setFactorUtilizacion()
        {
            _factorUtilizacion = calcularFactorUtilizacion(_tasaMediaTiempoLlegadaClientes, tasaMediaTiempoServicio);
        }

        #region Abstract Setters
        public abstract void setNumeroEsperadoClientesSistema(float factorUtilizacion);
        public abstract void setNumeroEsperadoClientesFila(float factorUtilizacion);
        public abstract void setTiempoEsperaEstimadoSistema(float tasaMediaTiempoServicio, float tasaMediaTiempoLlegadaClientes);
        public abstract void setTiempoEsperaEstimadoFila(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio);
        #endregion       
        
        #endregion

        #region Global Methods
        public float invertirValor(float valor)
        {
            return 1 / valor;
        }

        private float calcularFactorUtilizacion(float lambda, float mu)
        {
            return lambda / mu;
        }
        #endregion

    }
}
