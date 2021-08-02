using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.Ingrese un número: ");
            int numeroUno = int.Parse(Console.ReadLine());

            Console.Write("2.Ingrese un número: ");
            int numeroDos = int.Parse(Console.ReadLine());

            Console.Write("3.Ingrese un número: ");
            int numeroTres = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de los tres numeros es: " + Suma(numeroUno, numeroDos, numeroTres));
            Console.ReadKey();
        }

        static int Suma(int numUno, int numDos, int numTres)
        {
            return numUno + numDos + numTres;
        }
    }
}
