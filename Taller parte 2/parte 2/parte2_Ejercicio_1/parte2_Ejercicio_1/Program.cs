using System;

namespace parte2_Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double descuento = 0;
            double descuentoTotal; 
            Console.Write("Ingrese el nombre de un artículo: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la clave: ");
            string clave = Console.ReadLine();

            Console.Write("Ingree el precio: ");
            double precio = double.Parse(Console.ReadLine());

            if (clave.Equals("01"))
            {
                descuento = precio * 0.1;
            }else if (clave.Equals("02"))
            {
                descuento = precio * 0.2;
            }else
            {
                Console.WriteLine("La clave no existe, no tienes descuento");
            }

            if (descuento > 0)
            {
                descuentoTotal = precio - descuento;
                Console.WriteLine("nombre del articulo es {0} precio total con descuento es {1}", nombre, descuentoTotal);
            }

            Console.ReadKey();
        }
    }
}
