using System;

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de la matricula: ");
            double valor = double.Parse(Console.ReadLine());

            double priCuota = Math.Abs((valor * .40) - valor);
            double segCouta = Math.Abs((priCuota * .25) - priCuota);
            double terCuota = Math.Abs((segCouta * .20) - segCouta);
            double cuartCuota = Math.Abs((terCuota * .15) - terCuota);


            Console.WriteLine($"Primera cuota: 40% - {priCuota} \nSegunda cuota: 25% - {segCouta} \nTercera cuota: 20%  - {terCuota} \nCuarta cuota: 15% - {cuartCuota}");
        }
    }
}
