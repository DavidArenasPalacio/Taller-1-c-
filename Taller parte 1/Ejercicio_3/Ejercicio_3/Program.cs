using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Ingrese la primira nota: ");
            float notaUno = float.Parse(Console.ReadLine());
            Console.Write("2. Ingrese la segunda nota: ");
            float notaDos = float.Parse(Console.ReadLine());
            Console.Write("3. Ingrese la tercera nota: ");
            float notaTres = float.Parse(Console.ReadLine());

            Console.WriteLine($"La nota definitiva es: {NotaFinal(notaUno,notaDos,notaTres)}");
        }

        static float NotaFinal(float notaUno, float notaDos, float notaTres)
        {
            return notaUno + notaDos + notaTres;
        }
    }
}
