using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A12C
{
    class Program
    {
        static void Main(string[] args)
        {
            float salário = 0;
            Console.Write("Qual é o seu salário ? ");
            float.TryParse(Console.ReadLine(), out salário);
            Console.WriteLine($"Você ganha {salário:C} por mês");
            Console.ReadKey();
        }
    }
}
