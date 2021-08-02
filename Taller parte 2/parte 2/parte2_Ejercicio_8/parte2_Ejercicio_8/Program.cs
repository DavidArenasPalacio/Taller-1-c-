using System;

namespace parte2_Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tipo de genero (F/M): ");
            char genero = char.Parse(Console.ReadLine());

            Console.WriteLine($"El número de pulsaciones es {NumPulsaciones(edad, genero)}");

            Console.ReadLine();
               
        }

        static double NumPulsaciones(int edad, char genero)
        {
            double numPulsaciones = 0;

            if(genero == 'F')
            {
                numPulsaciones = (220 - edad) / 10;
            }else if (genero == 'M')
            {
                numPulsaciones = (210 - edad) / 10;
            }

            return numPulsaciones;
        }
    }
}
