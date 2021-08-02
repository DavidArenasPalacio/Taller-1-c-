using System;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int baldeDos = 3;
            int baldeTres = 5;

            double tBaldeDos = baldeDos * 90;
            double tBaldeTres = baldeTres * 90;

            double minBaldeDos = tBaldeDos / 60;
            double minBadeTres = tBaldeTres / 60;

            string[] horasMinutosBaldeDos = minBaldeDos.ToString().Split(",");

            string minutoBaldeDos = "0,"+ horasMinutosBaldeDos[1];

            double resultMinBaldeDos = double.Parse(minutoBaldeDos) * 60;


            string[] horasMinutosBaldeTres = minBadeTres.ToString().Split(",");

            string minutoBaldeTres = "0," + horasMinutosBaldeTres[1];

            double resultMinBaldeTres = double.Parse(minutoBaldeTres) * 60;

            Console.WriteLine($"El balde de {baldeDos} litros se tardara en llenarse en {horasMinutosBaldeDos[0]}hr {resultMinBaldeDos}min \nEl balde de {baldeTres} litros se tardara en llenarse en {horasMinutosBaldeTres[0]}hr {resultMinBaldeTres}min");

            Console.ReadKey();
        }
    }
}
