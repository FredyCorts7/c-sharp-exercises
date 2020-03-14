using System;

namespace AppBucleFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 10;
            float valor = 0;
            for(int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el valor {0}: ", (i + 1));
                valor += float.Parse(Console.ReadLine());
            }
            Console.WriteLine("La suma total de los valores ingresados es {0}", valor);
            Console.WriteLine("El promedio de los valores ingresados es {0}", (valor / cantidad));
        }
    }
}
