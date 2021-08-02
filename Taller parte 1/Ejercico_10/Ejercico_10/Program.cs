using System;

namespace Ejercico_10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el valor de la compra: ");
            double valorCompra = double.Parse(Console.ReadLine());

            double desc = valorCompra * 0.15;


            Console.Write($"El descuento es de: {desc} \nEl valor total a pagar es de: {valorCompraTotal(valorCompra, desc)}");

        }


        static double valorCompraTotal(double valorCompra, double desc)
        {
            return valorCompra - desc;
        }
    }
}
