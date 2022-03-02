using System;

namespace M02A011
{
    class Program
    {
        static void Main(string[] args)
        {
            int lotaçao = 30;
            int total = 0;
            int grupo = 0;

            Console.WriteLine("Quantas pessoas ? ");
            int.TryParse(Console.ReadLine(), out grupo);
            total += grupo;

            Console.Write($"Chegando um grupo de {grupo} pessoas,agora temos {total} pessoas na festa\n");

            Console.Write($"Lotou a balada? {total >= lotaçao}");

            Console.ReadKey();
        }
    }
}
