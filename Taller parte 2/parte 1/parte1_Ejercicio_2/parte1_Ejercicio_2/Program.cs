using System;

namespace parte1_Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double descuento, descuenTotal;
            Console.Write("Ingrese el precio de la camisa: ");
            double valorCompra = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de camisas: ");
            int cantidad = int.Parse(Console.ReadLine());

            double totalCompra = valorCompra * cantidad;

        

            if (cantidad >= 3)
            {
                Console.WriteLine("Descuento del 20%: ");
                descuento = totalCompra * 0.2;
            }else
            {
                Console.WriteLine("Descuento del 10%: ");
                descuento = totalCompra * 0.1;
            }

            descuenTotal = totalCompra - descuento;

            Console.WriteLine($"El total de la compra a pagar es {descuenTotal}");

            Console.ReadKey();
        }
    }
}
