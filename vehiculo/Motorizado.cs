using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculo
{
    public abstract class Motorizado
    {
        protected string tipo;
        protected void Arrancar()
        {
            Console.WriteLine(" arrancando ...... \n");
        }

        protected void Apagar()
        {
            Console.WriteLine(" apagando ......\n");
        }


    }

    
}
