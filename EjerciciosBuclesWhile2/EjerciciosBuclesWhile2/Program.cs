using System;

namespace EjerciciosBuclesWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 1;
            Console.Write("Digite un numero entero positivo: ");
            numero = int.Parse(Console.ReadLine());
            if(numero > 0)
            {
                while(contador <= numero)
                {
                    Console.WriteLine(contador);
                    contador++;
                }
            } else
            {
                Console.WriteLine("El numero ingresado, no es entero positivo");
            }
        }
    }
}
