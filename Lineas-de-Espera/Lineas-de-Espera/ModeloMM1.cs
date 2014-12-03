﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas_de_Espera
{
    class ModeloMM1 : ModeloLineaDeEspera
    {
        public ModeloMM1(float tasaMediaTiempoLlegadaClientes, float tasaMediaTiempoServicio )
        {
            this.numeroServidores = 1;
            this.tasaMediaTiempoLlegadaClientes = tasaMediaTiempoLlegadaClientes;
            this.tasaMediaTiempoServicio = tasaMediaTiempoServicio;
            setFactorUtilizacion();
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
