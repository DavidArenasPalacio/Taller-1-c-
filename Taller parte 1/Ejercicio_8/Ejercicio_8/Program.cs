using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese la capital invertido: ");
            double capital = double.Parse(Console.ReadLine());

            double razonMensual = capital * .02;

            Console.WriteLine($"La ganancia es de: {razonMensual} \nLa valor total es de: {ValorTotal(razonMensual, capital)}");
        }

        static double ValorTotal(double razonMensual, double capital)
        {
            return capital + razonMensual;
        }
    }
}
