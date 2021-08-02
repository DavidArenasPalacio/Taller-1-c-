using System;

namespace parte2_Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int total;
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine()); 

            if(num >= 10)
            {
                total = num * 3;
                Console.Write($"El triple del número {num} es: {total}");
            }
            else
            {
                total = num / 4;
                Console.Write($"La cuarta parte del número {num} es: {total} ");
            }

            Console.ReadLine();
        }
    }
}
