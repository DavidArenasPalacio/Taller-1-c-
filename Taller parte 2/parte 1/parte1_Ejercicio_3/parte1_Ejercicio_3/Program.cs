using System;

namespace parte1_Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double descuento;
            double descTotal;
            double ivaTotal;
            double totalPagar;
            Console.Write("Ingrese el precio de la computadora: ");
            double precio = double.Parse(Console.ReadLine());

            ivaTotal = precio * 0.19;
            totalPagar = precio + ivaTotal;

            if (precio >= 1000000)
            {
                descuento = precio * 0.1;
                descTotal = precio - descuento;
                ivaTotal = descTotal * .19;
                totalPagar = descTotal + ivaTotal;
            }

            Console.WriteLine($"El total a pagar es de {totalPagar}");
        }
    }
}
