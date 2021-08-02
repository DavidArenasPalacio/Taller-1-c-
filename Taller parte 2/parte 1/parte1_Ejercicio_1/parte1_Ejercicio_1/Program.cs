using System;

namespace parte1_Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"El número {num} es par");
            }
            else
            {
                Console.WriteLine($"El número {num} no es par");
            }
            Console.ReadKey();
        }
    }
}
