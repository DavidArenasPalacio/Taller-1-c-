using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la distacia en KM: ");
            double KM = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tiempo en Horas: ");
            double TH = double.Parse(Console.ReadLine());

            Console.WriteLine($"La velociadad a la cual se desplazaba el auto es {Calcular(KM, TH)} km/h");
            Console.ReadKey();
        }

        static double Calcular(double KM, double TH)
        {
            return KM / TH;
        }
    }
}
