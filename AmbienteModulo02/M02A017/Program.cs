using System;

namespace M02A017
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = 0;
            Console.WriteLine("Digite um número: ");
            float.TryParse(Console.ReadLine(), out num);

            Console.WriteLine($"O valor arredondamento para cima é: {Math.Ceiling(num)}");// arredondamento para cima
            Console.WriteLine($"O valor arredondamento para baixo é: {Math.Floor(num)}");// arredondamento para baixo
            Console.WriteLine($"O valor arredondamento aritmético é: {Math.Round(num)}"); // arredondamento aritmético
            Console.WriteLine($"Usando Truncate temos o valor : {Math.Truncate(num)}");//corte decimal
            Console.ReadKey();

        }
    }
}
