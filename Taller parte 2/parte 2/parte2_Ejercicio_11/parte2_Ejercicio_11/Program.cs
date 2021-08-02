using System;

namespace parte2_Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de la pieza: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de pizas: ");
            int cantiad = int.Parse(Console.ReadLine());

            CompraTotal(valor, cantiad);

            Console.ReadLine();
        }

        static void CompraTotal(double valorPieza, int numPiezas)
        {
            double recursosPropios, prestBanco = 0, creditoFrab, interes;
            double valorCompra = valorPieza * numPiezas;

            if (valorCompra >= 5000000)
            {
                recursosPropios = valorCompra * .55;
                prestBanco = valorCompra * .30;
                creditoFrab = valorCompra * .15;
            }
            else
            {
                recursosPropios = valorCompra * .70;
                creditoFrab = valorCompra * .30;
            }

            interes = creditoFrab * .15;

            Console.WriteLine("La capacidad de pagar con recursos propios es de " + recursosPropios);
            Console.WriteLine("La cantidad de prestamo al banco es de " + prestBanco);
            Console.WriteLine("La cantidad de credito apagar al fabricante es " + creditoFrab);
            Console.WriteLine("El interes del fabricante sobre la cantidad de credito apagar es " + interes);
        }
    }
}
