using System;

namespace parte2_Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de la compra: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine($"El total a pagar es de {CalcularDescuento(valor)}");
            Console.ReadKey();
        }

        static double CalcularDescuento(double valorCompra)
        {
            double descuento, descTotal;

            if (valorCompra > 200000)
            {
                descuento = valorCompra * .17;
                descTotal = valorCompra - descuento;
            }
            else
            {
                descuento = valorCompra * .05;
                descTotal = valorCompra - descuento;
            }

            return descTotal;
        }
    }
}
