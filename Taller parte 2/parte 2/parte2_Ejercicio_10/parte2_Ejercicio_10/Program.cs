using System;

namespace parte2_Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Dormir \n" +
                "2. Sentado");
            Console.Write("Ingrese la opción: ");
            int opcion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tiempo que realiza la actividad: ");
            int tiempo = int.Parse(Console.ReadLine());


            if (opcion == 1 || opcion == 2)
            {
                Console.WriteLine($"La cantidad de calorías que consume su cuerpo durante {tiempo} es: {Calorias(tiempo, opcion)}");
            }
            else
            {
                Console.WriteLine("La opción es incorrecta");
            }

            Console.ReadLine();
        }

        static double Calorias(int tiempo, int opcion)
        {
            double calorias = 0;

            if(opcion == 1)
            {
                calorias = tiempo * 1.08;
            }else if(opcion == 2)
            {
                calorias = tiempo * 1.66;
            }
           

            return calorias;
        }
    }
}
