using System;

namespace Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em que ano você nasceu? ");
            int nascimento = 0;
            int.TryParse(Console.ReadLine(), out nascimento );
            Console.WriteLine("-------------------------------------");
            int ano = DateTime.Now.Year;
            int idade = ano - nascimento;
            Console.WriteLine($" Estamos atualmente no ano de {ano}.");
            Console.WriteLine($" Se você nasceu em {nascimento}, então você tem {idade} anos.");
            Console.ReadKey();
        }
    }
}
