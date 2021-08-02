using System;

namespace parte2_Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el ingreso del comprador: ");
            double ingreso = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de la vivienda: ");
            double valorVivienda = double.Parse(Console.ReadLine());

            CuotaPagar(ingreso, valorVivienda);
        }

        static void CuotaPagar(double ingreso, double valorVivienda)
        {
            double cuotaInicial, resto, cuotaMensual, interes;

            if (ingreso >= 1200000)
            {
                cuotaInicial = valorVivienda * .15;
                resto = valorVivienda - cuotaInicial;
                cuotaMensual = resto / 120;
                interes = cuotaMensual * 0.02;
                cuotaMensual += interes;
                
            }
            else
            {
                cuotaInicial = valorVivienda * .30;
                resto = valorVivienda - cuotaInicial;
                cuotaMensual = resto / 84;
                interes = cuotaMensual * 0.01;
                cuotaMensual += interes;
            }

            Console.WriteLine("La cuota inicial a pagar es de {0} \nLa cuota mensual a pagar es de {1}", cuotaInicial, cuotaMensual);
        }
    }
}
