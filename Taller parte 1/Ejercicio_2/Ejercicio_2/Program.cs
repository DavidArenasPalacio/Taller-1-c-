using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.Ingrese un número: ");
            int numUno = int.Parse(Console.ReadLine());
            Console.Write("2.Ingrese un número: ");
            int numDos = int.Parse(Console.ReadLine());
            Console.WriteLine($"La suma es: {Suma(numUno, numDos)} \nLa resta es: {Resta(numUno, numDos)} \nLa multiplicación es: {Multiplicacion(numUno, numDos)} \nLa división es: {Division(numUno, numDos)}");

            Console.ReadKey();
        }

        static int Suma(int numUno, int numDos)
        {
            return numUno + numDos;
        }

        static int Resta(int numUno, int numDos)
        {
            return (numUno < numDos) ? numDos - numUno : numUno - numDos;
        }
        static int Multiplicacion(int numUno, int numDos)
        {
            return numUno * numDos;
        }

        static int Division(int numUno, int numDos)
        {
            return numUno / numDos;
        }
    }
}
