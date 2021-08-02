using System;

namespace parte2_Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la distancia a recorrer: ");
            int distancia = int.Parse(Console.ReadLine());

            Console.Write($"El precio de un pasaje de ida y vuelta por avión es {PrecioPasaje(distancia)}");
        } 


        static double PrecioPasaje(int distancia)
        {
            double descuento, precio;

            precio = distancia * 150;

            if (distancia > 1000)
            {
                descuento = precio * 0.3;
                precio -= descuento;
            }   

            return precio;
        }

    }
}
