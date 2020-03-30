using System;

namespace EjerciciosBuclesFor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int aprobados = 0, reprobados = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Digite la {0} nota: ", (i + 1));
                if(float.Parse(Console.ReadLine()) >= 7)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }
            Console.WriteLine("La cantidad de alumnos aprobados es: {0}", aprobados);
            Console.WriteLine("La cantidad de alumnos reprobados es: {0}", reprobados);
        }
    }
}
