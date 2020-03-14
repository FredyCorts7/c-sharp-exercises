using System;

namespace EjerciciosBucles4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            float count = 0, i = 0, length = 0;
            Console.WriteLine("Digite la cantidad de piezas");
            n = int.Parse(Console.ReadLine());
            while(i < n)
            {
                Console.WriteLine("Digite la longitud de la pieza {0}", (i + 1));
                length = float.Parse(Console.ReadLine());
                if(length >= 1.2 && length <= 1.3)
                {
                    count += 1;
                }
                i += 1;
            }
            Console.WriteLine("La cantidad de piezas son {0} y las piezas que cumplen son {1}", i, count);
        }
    }
}
