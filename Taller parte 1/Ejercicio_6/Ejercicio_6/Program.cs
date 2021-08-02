using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad  de dinero correspondiente a una compra: ");
            double cantidad = double.Parse(Console.ReadLine());


            Console.Write("Autorizar descuento (S/N): ");
            char opcion = char.Parse(Console.ReadLine());

            double desc = (opcion == 'S') ? cantidad * .10 : 0;

            double desctTotal = (desc > 0) ? cantidad - desc : 0;

            double desctIva = (desc > 0) ? desctTotal * 0.19 : cantidad * .19;

            double iva = cantidad * .19;
            //double ValorFactura = (desc > 0) ? desctTotal + iva : cantidad + iva;

            Console.WriteLine($"El valor total del iva es: {iva}  \nEl descuento es: {desc} \nValor total de la factura es: {ValorFactura(desc, desctTotal, desctIva, cantidad)}");
            Console.ReadKey();
        }

        static double ValorFactura(double desc, double desctTotal, double iva, double cantidad)
        {
            return (desc > 0) ? desctTotal + iva : cantidad + iva;
        }

    }
}
