using System;

namespace parte2_Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int nUno = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int nDos = int.Parse(Console.ReadLine());

            Console.WriteLine("Orden ascendente: ");

            if (nUno < nDos)
            {
                Console.WriteLine($"{nUno}, {nDos}");
            }else
            {
                Console.WriteLine($"{nDos}, {nUno}");
            }

        }
    }
}
