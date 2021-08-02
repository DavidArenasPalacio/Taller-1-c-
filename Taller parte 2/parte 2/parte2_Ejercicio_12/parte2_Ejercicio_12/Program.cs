using System;

namespace parte2_Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de cuadernos a llevar: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("El valor total a pagar es {0}", ValorTotal(cantidad));
            Console.ReadKey();
        }

        static double ValorTotal(int numCuadernos)
        {
            double valorTotal;

            if (numCuadernos >= 5)
            {
                valorTotal = numCuadernos * 2000;
            }
            else
            {
                valorTotal = numCuadernos * 2500;
            }

            return valorTotal;
        }
    }
}
