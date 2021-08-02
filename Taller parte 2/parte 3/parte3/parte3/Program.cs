using System;

namespace parte3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            bool salir = true;

            while (salir)
            {
                Console.WriteLine("1. números primos\n" +
                    "2. Suldo máximo\n" +
                    "3. Número escrito \n" +
                    "4. Abecedario\n" +
                    "5. Salir");
                Console.Write("Ingrese una opción: ");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("---- Números primos ----");
                    Console.Write("Ingrese un número: ");
                    int num = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Cantidad de números primos es: {CantidadPrimo(num)}");

                    Console.WriteLine();
                }
                else if (opcion == 2)
                {
                    Console.WriteLine();

                    Console.WriteLine("------ Saldo máximo ------");
                    Console.Write("Ingrese un número: ");
                    int num = int.Parse(Console.ReadLine());

                    Console.WriteLine($"El sueldo máximo es de {sueldoMaximo(num)}");

                    Console.WriteLine();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("----- Número escrito -----");
                    int num;
                    do
                    {
                        Console.Write("Ingrese un número entre 0 y 99: ");
                        num = int.Parse(Console.ReadLine());
                    } while (num > 99);

                    Console.WriteLine($"El número es: {NumeroEscrito(num)}");
                    Console.WriteLine();
                }
                else if (opcion == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("---- Vocal o Consonante ---- ");

                    Console.Write("Ingrese una letra: ");
                    char letra = char.Parse(Console.ReadLine());

                    Console.WriteLine(VocalConsonante(letra));

                    Console.WriteLine();
                }
                else if (opcion == 5)
                {
                    salir = false;
                }
                else
                {
                    Console.WriteLine("La opción ingresado no existe");
                }
            }
        }

        static int CantidadPrimo(int num)
        {
            int contPrimo = 0, cont = 0;
            int n = 2;

            while (n <= num)
            {

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        contPrimo++;
                }

                if (contPrimo < 3)
                    cont++;

                contPrimo = 0;
                n++;
            }

            return cont;
        }

        static double sueldoMaximo(int num)
        {
            double sueldoMaximo = int.MinValue;
            int n = 0;
            while (n < num)
            {
                Console.Write($"Ingrese  el  sueldo {n + 1}: ");
                double saldo = double.Parse(Console.ReadLine());

                if (saldo > sueldoMaximo)
                    sueldoMaximo = saldo;

                n++;
            }
            return sueldoMaximo;

        }

        static string NumeroEscrito(int num)
        {
            string resultado = "", decena = "";
            int unidades, decenas;

            unidades = num % 10;
            decenas = num / 10;

            if (unidades == 0)
                resultado = "cero";
            else if (unidades == 1)
                resultado = "uno";
            else if (unidades == 2)
                resultado = "dos";
            else if (unidades == 3)
                resultado = "tres";
            else if (unidades == 4)
                resultado = "cuatro";
            else if (unidades == 5)
                resultado = "cinco";
            else if (unidades == 6)
                resultado = "seis";
            else if (unidades == 7)
                resultado = "siete";
            else if (unidades == 8)
                resultado = "ocho";
            else if (unidades == 9)
                resultado = "nueve";


            if (decenas == 1 && unidades == 0)
                resultado = "diez";
            else if (decenas == 1 && unidades == 1)
                resultado = "once";
            else if (decenas == 1 && unidades == 2)
                resultado = "doce";
            else if (decenas == 1 && unidades == 3)
                resultado = "trece";
            else if (decenas == 1 && unidades == 4)
                resultado = "catorce";
            else if (decenas == 1 && unidades == 5)
                resultado = "quince";
            else if (decenas == 1 && unidades == 6)
                resultado = "dieciseis";
            else if (decenas == 1 && unidades == 7)
                resultado = "diecisiete";
            else if (decenas == 1 && unidades == 8)
                resultado = "dieciocho";
            else if (decenas == 1 && unidades == 9)
                resultado = "diecinueve";

            if (decenas == 2)
                decena = "veinte";
            else if (decenas == 3)
                decena = "treinta";
            else if (decenas == 4)
                decena = "cuarenta";
            else if (decenas == 5)
                decena = "cincuenta";
            else if (decenas == 6)
                decena = "sesenta";
            else if (decenas == 7)
                decena = "setenta";
            else if (decenas == 8)
                decena = "ochenta";
            else if (decenas == 9)
                decena = "noventa";

            if ((resultado != "" && resultado != "cero") && decena != "")
            {
                resultado = $"{decena} y {resultado}";
            }
            else
            {
                if (decena != "")
                {
                    resultado = decena;
                }
            }

            return resultado;
        }

        static string VocalConsonante(char letra)
        {
            string resultado;
            if ((letra == 'a' || letra == 'A') || (letra == 'e' || letra == 'E') || (letra == 'i' || letra == 'I') || (letra == 'o' || letra == 'O') || (letra == 'u' || letra == 'U'))
            {
                resultado = $"La letra {letra} es una vocal";
            }
            else
            {
                resultado = $"La letra {letra} es una consonante";
            }

            return resultado;
        }
    }
}
