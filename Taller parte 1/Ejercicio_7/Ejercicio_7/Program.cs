using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una hora: ");
            int hora = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un minuto: ");
            int minuto = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un segundo: ");
            int segundo = int.Parse(Console.ReadLine());

            Console.WriteLine($"El quivalente en segundo es {SegEquivale(hora, minuto, segundo)} segundos");

            Console.ReadKey();

        }

        static int SegEquivale(int hora, int minuto, int segundo)
        {
            return hora * minuto * segundo;
        }
    }
}
