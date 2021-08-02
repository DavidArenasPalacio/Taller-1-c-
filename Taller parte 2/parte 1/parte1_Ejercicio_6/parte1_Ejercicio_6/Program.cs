using System;

namespace parte1_Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double retencion = 0;
            double salarioTotal;
            Console.Write("Ingrese el salario bruto: ");
            double salario = double.Parse(Console.ReadLine());

            salarioTotal = salario;
            if (salario > 2000000)
            {
                retencion = salario * 0.1;
                salarioTotal =  salario - retencion;
            }
            Console.Write($"La retención es de {retencion} y eell total d salario es {salarioTotal}");

        }
    }
}
