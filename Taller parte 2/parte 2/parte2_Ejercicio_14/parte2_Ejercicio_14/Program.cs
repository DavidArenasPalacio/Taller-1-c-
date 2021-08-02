using System;

namespace parte2_Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(ParImpar(num));

            Console.ReadKey();
        }

        static string ParImpar(double num)
        {
            return (num % 2 == 0) ? $"El cubo del número {num} es {Math.Pow(num, 3)}"  : $"El triple del número {num} es {num*3}";
        }
    }
}
