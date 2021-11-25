using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExerciciosM001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10,15);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("MEU");
            Thread.Sleep(2000);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("BRASIL");
           
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("BRASILEIRO");
         
            Console.ReadKey();            
        }
    }
}
