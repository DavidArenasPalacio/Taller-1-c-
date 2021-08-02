using System;

namespace parte1_Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inrgese la cantidad invertidad en el banco: ");
            double cantidad = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la tasa de interes: ");
            double tasa = double.Parse(Console.ReadLine());

            double interes = cantidad * tasa;

            if (interes > 7000)
            {
                Console.WriteLine("La cantidad generada por concepto de interes es: {0} supera los $7000", interes);
            }
            else
            {
                Console.WriteLine("La cantidad generada por concepto de interes es: {0} no supera los $7000", interes);
            }

            Console.WriteLine("El saldo generado en la cuenta es {0}", (cantidad + interes));
        }
    }
}
