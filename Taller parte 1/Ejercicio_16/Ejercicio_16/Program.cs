using System;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad ganada en un día: ");
            float cantidad = float.Parse(Console.ReadLine());

            Console.WriteLine($"La cantidad que le corresponde es: {Total(cantidad)}");

            Console.ReadLine();
        }

        static float Total(float cantidad)
        {
            float total = cantidad * .19F;

            return cantidad - total;
        }
    }
}
