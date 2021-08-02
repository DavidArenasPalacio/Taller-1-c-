using System;

namespace parte2_Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el salario bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine());

            Console.Write("El salario del empleado es {0}", Salario(salarioBruto));

            Console.ReadLine();
        }

        static double Salario(double salarioBruto)
        {
            double retencion, salarioTotal;

            if (salarioBruto >= 2000000)
                retencion = salarioBruto * 0.1;
            else
                retencion = salarioBruto * 0.3;


            salarioTotal = salarioBruto - retencion;

            return salarioTotal;
        }
    }
}
