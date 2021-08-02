using System;

namespace parte2_Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 10)
            {
                Console.WriteLine("El triple es {0}", Triple(num));
            }

            Console.ReadKey();
        }

        static int Triple(int num)
        {
            return num * 3;
        }
      
    }
}
