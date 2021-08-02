using System;

namespace parte1_Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.Write($"El número {num} es negativo");
            }
        }

    }
}
