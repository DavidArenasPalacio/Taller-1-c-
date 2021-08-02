using System;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el precio unitario de un producto: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de compra de dicho producto: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el descuento de la compra: ");
            int descuento = int.Parse(Console.ReadLine());

            Console.WriteLine(Calcular(precio,cantidad,descuento));
        }
        
        static string Calcular(double precio, int cantidad, int descuento)
        {
            double valorCompra = precio * cantidad;
            double desc = (valorCompra * descuento) / 100;
            double subTotal = valorCompra - desc;
            double iva = subTotal * .21;
            double precioNeto = subTotal + iva;

            return $"Subtotal: {subTotal} \nIva: {iva} \nPrecio neto: {precioNeto}";
        }
        

        
    }
}
