using System;

namespace parte2_Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la horas trabajadas: ");
            int hora = int.Parse(Console.ReadLine());

            Console.WriteLine($"Su salario semanal es de {SalarioSemanal(hora)}");

            Console.ReadLine();
        }

        static double SalarioSemanal(int hora)
        {
            double salario = 0;
            int horas_extras;

            if (hora > 0)
            {
                if (hora <= 40)
                {
                    salario = hora * 10000;
                }
                else
                {
                    horas_extras = hora - 40;
                    salario = (40 * 10000) + (horas_extras * 15000);
                }
            }

            return salario;
        }
    }
}
