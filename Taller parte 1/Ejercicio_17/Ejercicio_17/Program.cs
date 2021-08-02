using System;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el salario del empleado: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de ahorro mensual programado: ");
            double AMP = double.Parse(Console.ReadLine());

            double totalRecibir = salario - AMP;
            Console.WriteLine(totalRecibir);

            double eps = (totalRecibir * 12.5) / 100;
            Console.WriteLine(eps);
            

            double fp = totalRecibir * .16;
           


            Console.WriteLine($"\nEl salario del Empleado es: ${salario} \nEl valor de ahorro mensual programado es: ${AMP} \nLa suma a deducir por aporte a la Salud (EPS) 12,5 % es: {eps} \nLa suma a deducir por aporte al Fondo de Pensiones  16% es: {fp} \nTotal a recibir es: {TotalRecibir(totalRecibir, eps, fp)}");

            Console.ReadKey();
        }

        static double TotalRecibir(double totalRecibir, double eps, double fp)
        {
            totalRecibir -= eps;
            totalRecibir -= fp;
            return totalRecibir;
        }
    }
}
