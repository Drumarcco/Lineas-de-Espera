using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas_de_Espera
{
    public class ModeloLineaDeEspera
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
        public float factorUtilizacion { get { return _factorUtilizacion; } set { _factorUtilizacion = value; } }


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

        /// <summary>
        /// Calcula factor de utilizacion para sistemas de un solo servidor
        /// </summary>
        /// <param name="lambda">tasaMediaTiempoLlegadaClientes</param>
        /// <param name="mu">tasaMediaTiempoServicio</param>
        /// <returns></returns>
        private float calcularFactorUtilizacion(float lambda, float mu)
        {
            return lambda / mu;
        }

       /// <summary>
       /// Calcula factor de utilizacion para sistemas de mas de un servidor
       /// </summary>
       /// <param name="lambda">tasaMediaTiempoLlegadaClientes</param>
       /// <param name="mu">tasaMediaTiempoServicio</param>
       /// <param name="numeroServidores">Numero de servidores que atienden el sistema.</param>
       /// <returns></returns>
        private float calcularFactorUtilizacion(float lambda, float mu, float numeroServidores)
        {
            return lambda / (numeroServidores * mu);
        }


        public float calcularProbabilidadTiempoEsperaSistemaExcedente(float tasaMediaTiempoServicio, float factorUtilizacion, 
            float tiempo)
        {
            float probabilidad =(float) Math.Exp(-tasaMediaTiempoServicio * (1 - factorUtilizacion) * tiempo);
            return probabilidad;
        }

        public float calcularProbabilidadTiempoEsperaFilaExcedente(float factorUtilizacion, float tasaMediaTiempoServicio,
            float tiempo)
        {
            float probabilidad = (float) (factorUtilizacion * Math.Exp(-tasaMediaTiempoServicio * (1 - factorUtilizacion) * tiempo));
            return probabilidad;
        }

        /// <summary>
        /// Calcula la probabilidad de que entren 0 o N numero de clientes al sistema de un servidor.
        /// </summary>
        /// <param name="factorUtilizacion">Factor de utilizacion del modelo.</param>
        /// <param name="n">Numero de clientes para el cual se quiere calcular la probabilidad.</param>
        /// <returns>Probabilidad</returns>
        public float calcularProbabilidadNClientesSistema(float factorUtilizacion, float n)
        {
            if (factorUtilizacion >= 1) throw new ArgumentException("Factor de utilizacion debe ser menor a 1.", "factorUtilizacion");
            if (n == 0) return 1 - factorUtilizacion;
            
            float probabilidad;
            probabilidad = (float) ((1 - factorUtilizacion) * (Math.Pow(factorUtilizacion, n)));
            return probabilidad;
        }

        /// <summary>
        /// Generar lista de probabilidades de llegada de clientes para sistemas de un servidor.
        /// </summary>
        /// <param name="factorUtilizacion">Factor de utilizacion del sistema</param>
        /// <returns>Lista de strings</returns>
        public List<string> generarListaProbabilidadesClientes(float factorUtilizacion)
        {
            List<string> listaProbabilidades = new List<string>();
            for (int i = 0; i <= 50; i++)
            {
                float probabilidad = calcularProbabilidadNClientesSistema(factorUtilizacion, i);
                string enunciado = "P" + i + "=" + probabilidad;
                listaProbabilidades.Add(enunciado);
            }
            return listaProbabilidades;
        }

        /// <summary>
        /// Generar lista de probabilidades de llegada de clientes para sistemas multi-servidor.
        /// </summary>
        /// <param name="tasaMediaTiempoLlegadaClientes">Lambda</param>
        /// <param name="tasaMediaTiempoServicio">Mu</param>
        /// <param name="numeroServidores">Numero de servidores en el sistema</param>
        /// <returns></returns>
        public List<string> generarListaProbabilidadesClientes(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio, int numeroServidores)
        {
            List<string> listaProbabilidades = new List<string>();
            for (int i = 0; i <= 50; i++)
            {
                float probabilidad = calcularProbabilidadNClientesSistema(tasaMediaTiempoLlegadaClientes, tasaMediaTiempoServicio, i, numeroServidores);
                string enunciado = "P" + i + "=" + probabilidad;
                listaProbabilidades.Add(enunciado);
            }
            return listaProbabilidades;
        }

        /// <summary>
        /// Calcula la probabilidad de que entren 0 o N numero de clientes al sistema de multiples servidores.
        /// </summary>
        /// <param name="tasaMediaTiempoLlegadaClientes">Lambda</param>
        /// <param name="tasaMediaTiempoServicio">Mu</param>
        /// <param name="numeroClientes">Numero de clientes n</param>
        /// <param name="numeroServidores">Numero de servidores s</param>
        /// <returns>Probabilidad</returns>
        public float calcularProbabilidadNClientesSistema(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio,
            int numeroClientes, int numeroServidores)
        {
            float divisor = calcularSumatoriaDivisoraProbabilidadCero(tasaMediaTiempoLlegadaClientes, tasaMediaTiempoServicio, numeroServidores);
            float probabilidadCeroClientes = 1 / divisor;

            if (numeroClientes == 0) return probabilidadCeroClientes;
            if (numeroClientes <= numeroServidores)
            {
                return calcularProbabilidadNMenorS(tasaMediaTiempoLlegadaClientes, tasaMediaTiempoServicio,
                    numeroClientes, probabilidadCeroClientes);
            }
            else
            {
                return calcularProbabilidadNMayorS(tasaMediaTiempoLlegadaClientes, tasaMediaTiempoServicio, numeroClientes,
                    numeroServidores, probabilidadCeroClientes);
            }

        }

        /// <summary>
        /// Calcula probabilidad de que haya menos clientes que servidores en el sistema.
        /// </summary>
        /// <param name="tasaMediaTiempoLlegadaClientes">lambda</param>
        /// <param name="tasaMediaTiempoServicio">mu</param>
        /// <param name="numeroClientes">Numero de clientes</param>
        /// <param name="probabilidadCero">Probabilidad de que haya cero clientes</param>
        /// <returns></returns>
        private float calcularProbabilidadNMenorS(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio, 
            int numeroClientes, float probabilidadCero)
        {
            float factorialN = factorial(numeroClientes);
            float probabilidad = (float) ((Math.Pow(tasaMediaTiempoLlegadaClientes / tasaMediaTiempoServicio, numeroClientes) * probabilidadCero) / 
                factorialN);

            return probabilidad;
        }

        /// <summary>
        /// Calcula probabilidad de que haya mas clientes que servidores en el sistema.
        /// </summary>
        /// <param name="tasaMediaTiempoLlegadaClientes">lambda</param>
        /// <param name="tasaMediaTiempoServicio">mu</param>
        /// <param name="numeroClientes">N</param>
        /// <param name="numeroServidores">S</param>
        /// <param name="probabilidadCero">P0</param>
        /// <returns></returns>
        private float calcularProbabilidadNMayorS(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio, 
            int numeroClientes, int numeroServidores, float probabilidadCero)
        {
            float factorialS = factorial(numeroServidores);
            float probabilidad = (float) ((Math.Pow(tasaMediaTiempoLlegadaClientes / tasaMediaTiempoServicio, numeroClientes) * probabilidadCero) /
                (factorialS * Math.Pow(numeroServidores, numeroClientes - numeroServidores)));
            return probabilidad;
        }

        /// <summary>
        /// Calcula el divisor de la ecuacion de P0 para modelo de varios servidores.
        /// </summary>
        /// <returns>Sumatoria del divisor</returns>
        private float calcularSumatoriaDivisoraProbabilidadCero(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio, int numeroServidores)
        {
            float sumatoria = 0;
            float factorialS = factorial(numeroServidores);
            for (int n = 0; n < numeroServidores; n++)
            {
                float monomio1 = (float) Math.Pow(tasaMediaTiempoLlegadaClientes / tasaMediaTiempoServicio, n) / factorial(n);
                float monomio2 = (float) Math.Pow(tasaMediaTiempoLlegadaClientes / tasaMediaTiempoServicio, numeroServidores) / factorialS;
                float monomio3 = (float) 1 / (1 - tasaMediaTiempoLlegadaClientes / (numeroServidores * tasaMediaTiempoServicio));

                sumatoria += monomio1 + monomio2 * monomio3;
            }
            return sumatoria;
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
