using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de hombres: ");
            float hombres = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de mujeres: ");
            float mujeres = float.Parse(Console.ReadLine());

            float total = Total(hombres, mujeres);

            Console.WriteLine($"El porcentaje de hombres es: {PorceH(hombres, total)}% \n El porcentaje de mujeres es: {PorceM(mujeres, total)}%");
        }

        static float Total(float hombres, float mujeres)
        {
            return hombres + mujeres;
        }

        static float PorceH(float hombres, float total)
        {
            return (hombres / total) * 100;
        }

        static float PorceM(float mujeres, float total)
        {
            return (mujeres / total) * 100;
        }


    }
}
