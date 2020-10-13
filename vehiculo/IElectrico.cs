using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculo
{
    interface IElectrico
    {
        float cantBateria();
        void cargarBateria(float cant);
    }
}
