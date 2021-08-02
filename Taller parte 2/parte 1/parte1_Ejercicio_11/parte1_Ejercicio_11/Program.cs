using System;

namespace parte1_Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la primera nota: ");
            float notaUno = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota: ");
            float notaDos = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera nota: ");
            float notaTres = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la cuarta nota: ");
            float notaCuatro = float.Parse(Console.ReadLine());

            float promedio = (notaUno + notaDos + notaTres + notaCuatro) / 4;

            if (promedio < 3.5)
            {
                Console.Write("Reprobo la materia con el promedio de {0} ", promedio);
            }
        }
    }
}
