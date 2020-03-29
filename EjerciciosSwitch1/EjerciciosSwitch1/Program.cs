using System;

namespace EjerciciosSwitch1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.Write("Digite un número ente 1 y 5: ");
            valor = int.Parse(Console.ReadLine());
            switch(valor)
            {
                case 1:
                    Console.WriteLine("UNO");
                    break;
                case 2:
                    Console.WriteLine("DOS");
                    break;
                case 3:
                    Console.WriteLine("TRES");
                    break;
                case 4:
                    Console.WriteLine("CUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
                default:
                    Console.Write("El valor no se encuentra en el rango [1, 5]");
                    break;
            }
        }
    }
}
