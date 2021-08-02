using System;

namespace parte1_Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int numUno = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int numDos = int.Parse(Console.ReadLine());

            if (numUno > numDos)
            {
                Console.Write($"La suma de los dos números es: {Suma(numUno, numDos)}");
            }
        }

        static int Suma(int numUno, int numDos)
        {
            return numUno + numDos;
        }
    }
}
