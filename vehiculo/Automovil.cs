using System;
using System.Collections.Generic;
using System.Text;

namespace vehiculo
{
    class Automovil: Motorizado, IElectrico
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public float kilometraje { get; set; }
        public float combustible { get; set; }
        public Automovil()
        {
            combustible = 0;
        }



        public void Acelerar()
        {

        }
        public void viajar(string origen, string destino)
        {
            Arrancar();
            Console.Write("usted viajo de "+origen+" a " + destino+ "\n");
            combustible = combustible - 10;
            Apagar();

        }
        public void Frenar()
        {

        }

        public void TocarBocina()
        {

        }

        public void NumeroDePuertas()
        {

        }

        public float cantBateria()
        {
            return combustible;
        }

        public void cargarBateria(float cant)
        {
            combustible = combustible + cant;

            Console.WriteLine(" se recargo " + cant + " de bateria ");
        }
    }
}
