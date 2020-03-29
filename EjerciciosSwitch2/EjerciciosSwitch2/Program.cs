using System;

namespace EjerciciosSwitch2
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            Console.Write("Digite un número en castellano entre uno y cinco: ");
            numero = Console.ReadLine();
            switch(numero)
            {
                case "UNO":
                    Console.WriteLine(1);
                    break;
                case "DOS":
                    Console.WriteLine(2);
                    break;
                case "TRES":
                    Console.WriteLine(3);
                    break;
                case "CUATRO":
                    Console.WriteLine(4);
                    break;
                case "CINCO":
                    Console.WriteLine(5);
                    break;
                default:
                    Console.WriteLine("El número no se encuntra dentro del rango permitido");
                    break;
            }
        }
    }
}
