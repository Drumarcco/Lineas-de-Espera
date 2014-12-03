using System;
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

        public override void setNumeroEsperadoClientesSistema()
        {
            throw new NotImplementedException();
        }

        public override float calcularNumeroEsperadoClientesSistema(float factorUtilizacion)
        {
            float numeroEsperadoClientesSistema;
            numeroEsperadoClientesSistema = factorUtilizacion / (1 - factorUtilizacion);
            return numeroEsperadoClientesSistema;
        }


    }
}
