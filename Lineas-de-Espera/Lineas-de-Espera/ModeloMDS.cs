using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas_de_Espera
{
    public class ModeloMDS : ModeloLineaDeEspera
    {
        List<ValoresMDS> valoresMDS = new List<ValoresMDS>()
        {
            new ValoresMDS{ rho = 0.1f, s = 1, l = 0.1f },
            new ValoresMDS{ rho = 0.1f, s = 2, l = 0.17f },
            new ValoresMDS{ rho = 0.1f, s = 3, l = 0.25f },
        };

    }
}
