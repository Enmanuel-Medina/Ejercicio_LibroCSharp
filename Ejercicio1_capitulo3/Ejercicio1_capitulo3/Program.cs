using System;

namespace Ejercicio1_capitulo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero entero ");
            double num = double.Parse(Console.ReadLine());

            
            if (num % 2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");

            Console.ReadKey();


        }
    }
}
