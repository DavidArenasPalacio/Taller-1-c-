using System;

namespace parte2_Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(parImpar(num));

            Console.ReadLine();
        }

        static string parImpar(int num)
        {
            string mensaje = "";
            if(num % 2 == 0)
            {
                mensaje += $"El número {num} es par";
            }
            else
            {
                mensaje += $"El número {num} es impar";
            }

            return mensaje;
        }
    }
}
