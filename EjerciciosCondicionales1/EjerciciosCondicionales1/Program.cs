using System;

namespace EjerciciosCondicionales1
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;
            Console.Write("Digite el primer número: ");
            numero1 = float.Parse(Console.ReadLine());
            Console.Write("\nDigite el segundo número: ");
            numero2 = float.Parse(Console.ReadLine());
            if(numero1 > numero2)
            {
                Console.WriteLine("La suma de ambos números es: {0}", (numero1 + numero2));
                Console.WriteLine("La diferencia de ambos números es: {0}", (numero1 - numero2));
            } else
            {
                Console.WriteLine("El producto de ambos números es: {0}", (numero1 * numero2));
                Console.WriteLine("La división de ambos números es: {0}", (numero1 / numero2));
            }
        }
    }
}
