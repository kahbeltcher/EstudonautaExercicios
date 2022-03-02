using System;

namespace M02A018
{
    class Program
    {
        static void Main(string[] args)
        {
            float angulo = 0;

            Console.WriteLine("Infome o ângulo em Graus: ");
            float.TryParse(Console.ReadLine(), out angulo);

            float radiano = angulo * (MathF.PI) / 180;

            Console.WriteLine($"O seno de {angulo}° é igual a {MathF.Sin(radiano):f3}");
            Console.WriteLine($"O cosseno de {angulo}° é igual a { MathF.Cos(radiano):f3}");
            Console.WriteLine($"A Tangente de {angulo}° é igual a {MathF.Tan(radiano):f3}");

        }
    }
}
