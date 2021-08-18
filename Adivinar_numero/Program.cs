using System;

namespace Adivinar_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numero = rnd.Next(0, 100);
            System.Console.WriteLine("Ingresa un número");
            int numero_ingresado;
            numero_ingresado = Console.Read();
            if (numero==numero_ingresado)
            {
                System.Console.WriteLine("Correcto");
            }
            else
            {
                System.Console.WriteLine("Equivocado, el numero era {0}",numero);
            }

        }
    }
}
