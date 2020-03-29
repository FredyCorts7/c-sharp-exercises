using System;

namespace EjerciciosCondicionales3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeropositivo, digitos;
            Console.Write("Digite el número positivo: ");
            numeropositivo = int.Parse(Console.ReadLine());
            digitos = numeropositivo.ToString().Length;
            if (digitos < 2)
            {
                if(digitos == 1)
                {
                    Console.WriteLine("El número tiene 1 dígito");
                } else
                {
                    Console.WriteLine("El número tiene 2 dígitos");
                }
            } else
            {
                Console.WriteLine("El número tiene más de 2 dígitos");
            }
        }
    }
}
