using System;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el año de nacimiento: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la dirección: ");
            string direccion = Console.ReadLine();

            Console.WriteLine($"\nAño de nacimiento: {year} \nNombre: {nombre} \nDireccion: {direccion} \nLa edad es: {Calculo(year)}");
        }

        static int Calculo(int yearNaci)
        {
            int year = int.Parse(DateTime.Now.ToString("yyyy"));
            int edad =  year - yearNaci;
            return edad;
        }
    }
}
