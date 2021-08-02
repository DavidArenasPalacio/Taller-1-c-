using System;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto de la venta: ");
            double montoVenta = double.Parse(Console.ReadLine());

            double iva = montoVenta * 0.19;

            Console.WriteLine("El iva es {0}", iva);

            double totalPagar = montoVenta + iva;

            Console.WriteLine("Total a pagar {0}", totalPagar);

            Console.Write("Ingrese la cantidad a pagar (solo efectivo): ");
            double cantidad = double.Parse(Console.ReadLine());

            Console.WriteLine("El cambio es de {0}", Cambio(cantidad, totalPagar));
        }

        static double Cambio(double cantidad, double totalPagar)
        {
            return cantidad - totalPagar;
        }
    }
}
