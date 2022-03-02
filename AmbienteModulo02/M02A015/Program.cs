using System;

namespace M02A015
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 8;
            int numero2 = 10;
            Console.WriteLine($"O maior valor entre {numero1} e {numero2} é {Math.Max(numero1, numero2)}");
            Console.WriteLine($"O menor valor entre {numero1} e {numero2} é {Math.Min(numero1, numero2)}");

        }
    }
}
