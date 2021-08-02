using System;

namespace parte1_Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 5 == 0)
            {
                Console.WriteLine("El numero {0} es multiplo de 5", num);
            }
            else
            {
                Console.WriteLine("El numero {0}  no es multiplo de 5", num);
            }
        }
    }
}
