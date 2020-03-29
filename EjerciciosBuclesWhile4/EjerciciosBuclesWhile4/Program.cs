using System;

namespace EjerciciosBuclesWhile4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadPiezas, contador = 0, cantidadPiezasAptas = 0;
            float longitudPieza;
            Console.Write("Digite la cantidad de piezas a procesar: ");
            cantidadPiezas = int.Parse(Console.ReadLine());
            if(cantidadPiezas > 0)
            {
                while(contador < cantidadPiezas)
                {
                    Console.Write("Digite la longitud de la pieza {0}: ", (contador + 1));
                    longitudPieza = float.Parse(Console.ReadLine());
                    if(longitudPieza >= 1.2 && longitudPieza <= 1.3)
                    {
                        cantidadPiezasAptas++;
                    }
                    contador++;
                }
                Console.WriteLine("La cantidad piezas aptas es: {0}", cantidadPiezasAptas);
            }
            else
            {
                Console.WriteLine("El número de piezas debe ser mayor a 0");
            }
        }
    }
}
