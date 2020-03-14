using System;

namespace AppIfConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, calificacion;
            Console.Write("Digite su primer nota: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite su segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.Write("Digite su tercer nota: ");
            nota3 = float.Parse(Console.ReadLine());
            calificacion = (nota1 + nota2 + nota3) / 3;
            if(calificacion > 3)
            {
                Console.WriteLine("Promocionado");
            }
        }
    }
}
