using System;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese las horas trabajadas: ");
            int HT = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor por hora: ");
            int VH = int.Parse(Console.ReadLine());


            Console.WriteLine($"Su salario es: {Salario(HT,VH)}");
        }

        static int Salario(int HT, int VH)
        {
            return HT * VH;
        }
    }
}
