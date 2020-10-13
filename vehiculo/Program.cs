using System;

namespace vehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil();
            Console.WriteLine("Cantidad de Bateria: " + auto.cantBateria());
            auto.cargarBateria(50);
            auto.viajar("Cochabamba", "Oruro");
            Console.WriteLine("Cantidad de Bateria: " + auto.cantBateria());


        }
    }
}
