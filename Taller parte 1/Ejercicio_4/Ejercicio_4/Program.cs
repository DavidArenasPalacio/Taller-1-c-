using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Ingrese la primera nota: ");
            float notaUno = float.Parse(Console.ReadLine());
            Console.Write("1. Ingrese la segunda nota: ");
            float notaDos = float.Parse(Console.ReadLine());
            Console.Write("1. Ingrese la tercera nota: ");
            float notaTres = float.Parse(Console.ReadLine());

            float PNU = notaUno * .2F;
            float PND = notaDos * .3F;
            float PNT = notaTres * .5F;

            Console.WriteLine($"La nota definitiva es: {NotaFinal(PNU, PND, PNT)}");

            Console.ReadKey();
        } 

        static float NotaFinal(float PNU, float PND, float PNT)
        {
            return PNU + PND + PNT;
        }



    }
}
