using System;


namespace open_bootcamp_introducion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int puertas;
            Console.WriteLine("Ingrese cantidad de puertas del auto: ");
            puertas = int.Parse(Console.ReadLine());
            Auto auto = new Auto(puertas); 
            Console.WriteLine("Las puertas de este auto son: "+ auto.getPuertas());
            Console.WriteLine("Ingrese cantidad de puertas a agregar al auto: ");
            auto.aumentarPuertas();
            Console.WriteLine("Las puertas de este auto son: " + auto.getPuertas());
        }
    }
}