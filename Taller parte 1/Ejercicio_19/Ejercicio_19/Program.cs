using System;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la primera nota: ");
            float notaUno = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota: ");
            float notaDos = float.Parse(Console.ReadLine());

            Console.Write("Ingrse la tercera nota: ");
            float notaTres = float.Parse(Console.ReadLine());

            Console.Write("Ingrse la cuatro nota: ");
            float notaCuatro = float.Parse(Console.ReadLine());

            Console.Write("Ingrse la cinco nota: ");
            float notaCinco = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el programa de formación: ");
            string programa = Console.ReadLine();

            Console.Write("Ingrese la ficha: ");
            int ficha = int.Parse(Console.ReadLine());



            Console.WriteLine($"Nombre: {nombre} \nPrograma: {programa} \nFicha: {ficha} \nPromedio final: {Promedio(notaUno, notaDos, notaTres, notaCuatro, notaCinco)}");


        }

        static float Promedio(float notaUno, float notaDos, float notaTres, float notaCuatro, float notaCinco)
        {
            return (notaUno + notaDos + notaTres + notaCuatro + notaCinco) / 5;
        }
    }
}
