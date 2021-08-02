using System;

namespace Ejercicio_11
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


            float prom = (notaUno + notaDos + notaTres) / 3;

            float totalProm = prom * .55F;

            Console.Write("Ingrese la calificación del examen final: ");
            float examenFinal = float.Parse(Console.ReadLine());

            float totalExamenFinal = examenFinal * .3F;

            Console.Write("Ingrese la calificación del ultimo trabajo: ");
            float caliUltTrabajo = float.Parse(Console.ReadLine());

            float totalCaliUltTrabajo = caliUltTrabajo * .15F;

          

            Console.WriteLine($"La calificación final de la materia de algoritmos es: {CaliFinal(totalProm, totalExamenFinal, totalCaliUltTrabajo)}");

            Console.ReadLine();
        }

        static float CaliFinal(float totalProm, float totalExamenFinal, float totalCaliUltTrabajo)
        {
            return totalProm + totalExamenFinal + totalCaliUltTrabajo;
        }
    }
}
