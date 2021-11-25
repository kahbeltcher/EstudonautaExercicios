using System;

namespace Ex009
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstPrice, secondPrice;

            //LENDO PRODUTO 1
            Console.Write("Produto 1: ");

            string firstProduct = Console.ReadLine().Trim();
            Console.Write("Preço: ");

            float.TryParse(Console.ReadLine(), out firstPrice);
            //LENDO PRODUTO 2
            Console.Write("Produto 2: ");
            string secondProduct = Console.ReadLine().Trim();

            Console.Write("Preço: ");
            float.TryParse(Console.ReadLine(), out secondPrice);

            //RESULTADO
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine($"{"PRODUTO",-20} {"PREÇO",13}");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;

            Console.WriteLine($"{firstProduct,-20} {firstPrice,13:C2}");
            Console.WriteLine($"{secondProduct,-20} {secondPrice,13:C2}");

            Console.ReadKey();
            //TRIM função para tirar os espaços





        }
    }
}
