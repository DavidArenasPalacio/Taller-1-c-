using System;

namespace parte1_Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la estatura: ");
            double estatura = double.Parse(Console.ReadLine());

            if (estatura > 1.70)
            {
                Console.WriteLine("Es alta");
            }
        }
    }
}
