using System;
using System.Threading;

namespace Ex007
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("SORTEANDO NÚMERO");
            Console.WriteLine("-------------------------------");
            int inicio,fim;

            Console.WriteLine("INICIO: ");
            int.TryParse(Console.ReadLine(), out inicio);
            Console.WriteLine("FIM: ");
            int.TryParse(Console.ReadLine(), out fim);
            Console.WriteLine("-------------------------------");


            Console.WriteLine("SORTEANDO...");
            Thread.Sleep(2000);

            Random ger = new Random ();
            int numero = ger.Next(inicio,fim + 1);
            Console.SetCursorPosition(0, 7);

            Console.WriteLine($"O número sorteado foi: {numero}");

            Console.ReadKey();
        }
    }
}
