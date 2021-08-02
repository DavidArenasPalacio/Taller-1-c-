using System;

namespace parte1_Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 10)
            {
                Console.WriteLine($"El cubo de {num} es de {Math.Pow(num, 3)}");
            }
        }
    }
}
