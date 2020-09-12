using System;

namespace Ejercicio1_capitulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            float perimetro = 0.0f;
            float Apotema = 0.0f;
            float area = 0.0f;
            string valor = "";

            Console.WriteLine("Digite el valor del perimetro");
            valor = Console.ReadLine();

            perimetro = Convert.ToSingle(valor);

            Console.WriteLine("Digite el valor del apotema");
            valor = Console.ReadLine();

            Apotema = Convert.ToSingle(valor);

            area = perimetro * Apotema / 2;

            Console.WriteLine("El area es:"+ area);

        }
    }
}
