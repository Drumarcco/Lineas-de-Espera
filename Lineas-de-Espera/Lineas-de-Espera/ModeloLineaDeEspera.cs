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
        private float _factorUtilizacion;               // Rho
        private int _numeroServidores;                  // s
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
            set { _numeroEsperadoClientesSistema = value; }
        }

        public float numeroEsperadoClientesFila
        {
            get { return _numeroEsperadoClientesFila; }
            set { _numeroEsperadoClientesFila = value; }
        }

        public float tiempoEsperaEstimadoSistema
        {
            get { return _tiempoEsperaEstimadoSistema; }
            set { _tiempoEsperaEstimadoSistema = value; }
        }

        public float tiempoEsperaEstimadoFila
        {
            get { return _tiempoEsperaEstimadoFila; }
            set { _tiempoEsperaEstimadoFila = value; }
        }

        public int numeroServidores
        {
            get { return _numeroServidores; }
            set { _numeroServidores = value; }
        }
        public float factorUtilizacion { get; private set; }

        /// <summary>
        /// Asigna factor de utilización cuando número de servidores es 1.
        /// </summary>
        public void setFactorUtilizacion()
        {
            _factorUtilizacion = calcularFactorUtilizacion(tasaMediaTiempoLlegadaClientes, tasaMediaTiempoServicio);
        }

        /// <summary>
        /// Asigna factor de utilización cuando número de servidores es mayor que 1.
        /// </summary>
        /// <param name="numeroServidores">Numero de servidores que atienden el sistema.</param>
        public void setFactorUtilizacion(float numeroServidores)
        {
            _factorUtilizacion = calcularFactorUtilizacion(tasaMediaTiempoLlegadaClientes, tasaMediaTiempoServicio, numeroServidores);
        }

        #region Abstract Setters
        public abstract void setNumeroEsperadoClientesSistema(float factorUtilizacion);
        public abstract void setNumeroEsperadoClientesFila(float factorUtilizacion);
        public abstract void setTiempoEsperaEstimadoSistema(float tasaMediaTiempoServicio, float tasaMediaTiempoLlegadaClientes);
        public abstract void setTiempoEsperaEstimadoFila(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio);
        #endregion       
        
        #endregion

        #region Global Methods
        /// <summary>
        /// Utilizado para las formulas de 1/lambda, 1/mu.
        /// </summary>
        /// <param name="valor">Valor a invertir (lambda o mu).</param>
        /// <returns>Valor invertido</returns>
        public float invertirValor(float valor)
        {
            return 1 / valor;
        }

        private float calcularFactorUtilizacion(float lambda, float mu)
        {
            return lambda / mu;
        }

        private float calcularFactorUtilizacion(float lambda, float mu, float numeroServidores)
        {
            return lambda / (numeroServidores * mu);
        }

        /// <summary>
        /// Calcula la probabilidad de que entren N numero de clientes al sistema.
        /// </summary>
        /// <param name="factorUtilizacion">Factor de utilizacion del modelo.</param>
        /// <param name="n">Numero de clientes para el cual se quiere calcular la probabilidad.</param>
        /// <returns>Probabilidad</returns>
        public float probabilidadNClientesSistema(float factorUtilizacion, float n)
        {
            if (factorUtilizacion >= 1) throw new ArgumentException("Factor de utilizacion debe ser menor a 1.", "factorUtilizacion");
            float probabilidad;
            probabilidad = (float) ((1 - factorUtilizacion) * (Math.Pow(factorUtilizacion, n)));
            return probabilidad;
        }

        /// <summary>
        /// Probilidad P0 de que no lleguen clientes al sistema.
        /// </summary>
        /// <param name="factorUtilizacion">Factor de utilizacion del modelo.</param>
        /// <returns>Probabilidad.</returns>
        public float probabilidadCeroClientesSistema(float factorUtilizacion)
        {
            return 1 - factorUtilizacion;
        }

        /// <summary>
        /// Calcula el factorial de un numero entero.
        /// </summary>
        /// <param name="numero">Numero al cual se calcula el factorial.</param>
        /// <returns>Resultao de la operacion matematica factorial.</returns>
        public int factorial(int numero)
        {
            if (numero <= 1) return 1;
            return numero * factorial(numero - 1);
        }

        #endregion

    }
}
