using System;

namespace M02A009
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1 = 0;
            int p2 = 0;

            Console.WriteLine("OPERADORES BITWISE");
            Console.WriteLine("------------------");

            Console.Write("Ditige o primeiro número inteiro: ");
            int.TryParse(Console.ReadLine(), out p1);

            Console.Write("Digite o segundo número inteiro: ");
            int.TryParse(Console.ReadLine(), out p2);

            Console.WriteLine($"O valor de {p1} & {p2} = {p1 & p2}");
            Console.WriteLine($"O valor de {p1} | {p2} = {p1 | p2}");
            Console.WriteLine($"O valor de {p1} ^ {p2} = {p1 ^ p2}");
            Console.WriteLine($"O valor de ~ {p1} = {~ p1}");
            Console.WriteLine($"O valor de {p1} << {p2} = {p1 << p2}");
            Console.WriteLine($"O valor de {p1} >> {p2} = {p1 >> p2}");




        }
    }
}
