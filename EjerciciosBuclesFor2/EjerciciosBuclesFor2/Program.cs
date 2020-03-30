using System;

namespace EjerciciosBuclesFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadValores;
            float suma = 0;
            Console.Write("Digite la cantidad de valores que desea: ");
            cantidadValores = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidadValores; i++)
            {
                Console.Write("Digite el valor {0}: ", (i + 1));
                suma += float.Parse(Console.ReadLine());
            }
            Console.WriteLine("La suma de todos los valores es: {0}", suma);
            Console.WriteLine("El promedio de todos los valores es: {0}", (suma / cantidadValores));
        }
    }
}
