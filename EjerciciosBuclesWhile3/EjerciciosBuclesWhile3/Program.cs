using System;

namespace EjerciciosBuclesWhile3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadValores, contador = 0;
            float suma = 0;
            Console.Write("Digite la cantidad de valores que desea manejar: ");
            cantidadValores = int.Parse(Console.ReadLine());
            if (cantidadValores > 0)
            {
                while(contador < cantidadValores)
                {
                    Console.Write("Digite el valor {0}:", (contador + 1));
                    suma += float.Parse(Console.ReadLine());
                    contador++;
                }
                Console.WriteLine("La suma de los valores ingresados es: {0}", suma);
                Console.WriteLine("El promedio de los valores ingresados es: {0}", (suma / cantidadValores));
            }
            else
            {
                Console.WriteLine("El número de valores debe mayor a 0");
            }
        }
    }
}
