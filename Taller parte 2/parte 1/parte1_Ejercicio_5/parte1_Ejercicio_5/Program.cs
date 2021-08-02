using System;

namespace parte1_Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double descunto;
            double compraTotal;
            Console.Write("Ingrese el valor de la compra: ");
            double valorCompra = double.Parse(Console.ReadLine());

            if (valorCompra > 100000)
            {
                descunto = valorCompra * .2;
                compraTotal = valorCompra - descunto;
                Console.Write("La cantidad a pagar con descuento es: {0}", compraTotal);
            }
            else
            {
                Console.Write("La cantidad a pagar sin descuento es {0}", valorCompra);
            }
        }
    }
}
