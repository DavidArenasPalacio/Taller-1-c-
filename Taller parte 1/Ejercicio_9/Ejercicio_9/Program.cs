using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el sueldo base: ");
            double sueldoBase = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la primera venta: ");
            double primerVenta = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda venta: ");
            double segundaVenta = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera venta: ");
            double terceraVenta = double.Parse(Console.ReadLine());


            //double comision = (primerVenta + segundaVenta + terceraVenta) * 0.1;

            Console.WriteLine($"El suledo base es: {sueldoBase} \nComisiones por las tres ventas que realiza en el mes es: {Comision(primerVenta, segundaVenta, terceraVenta)} \nTotal que recibirá en el mes es: {Total(sueldoBase , Comision(primerVenta, segundaVenta, terceraVenta))}");
        }

        static double Comision(double primerVenta, double segundaVenta, double terceraVenta)
        {
            return (primerVenta + segundaVenta + terceraVenta) * 0.1;
        }

        static double Total(double sueldoBase, double comision)
        {
            return sueldoBase + comision;
        }
    }
}
