using System;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de la compra: ");
            float valorCompra = float.Parse(Console.ReadLine());

            float valorArt = valorCompra * 4;

            float iva = valorArt * .19F;

            Console.WriteLine($"El valor del articulo es: {valorArt} \nEl iva es: {iva} \nPrecio total del articulo es: {Total(valorArt, iva)}");

            Console.ReadLine();
        }

        static float Total(float valorArt, float iva)
        {
            return valorArt + iva;
        }
    }
}
