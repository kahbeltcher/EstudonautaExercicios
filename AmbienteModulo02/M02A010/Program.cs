using System;


namespace M02A010
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 4;
            int c = 7;

            a = b = c;

            Console.WriteLine($"RESPOSTA: {a}{b}{c}");
        }
    }
}
