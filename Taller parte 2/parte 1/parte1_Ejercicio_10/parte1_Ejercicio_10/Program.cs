using System;

namespace parte1_Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("No eres mayor de edad");
            }
        }
    }
}
