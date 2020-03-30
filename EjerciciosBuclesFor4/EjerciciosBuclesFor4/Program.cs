using System;

namespace EjerciciosBuclesFor4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros, contador = 0;
            Console.Write("Digite la cantidad de numero enteros que deseas: ");
            cantidadNumeros = int.Parse(Console.ReadLine());
            for(int i = 0; i < cantidadNumeros; i++)
            {
                Console.Write("Digite el valor {0}: ", (i + 1));
                if(int.Parse(Console.ReadLine()) >= 1000)
                {
                    contador++;
                }
            }
            Console.WriteLine("La cantidad de valores positivos que igualan o superan a 1000 es: {0}", contador);
        }
    }
}
