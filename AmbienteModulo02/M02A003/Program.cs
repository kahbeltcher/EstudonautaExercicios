using System;

namespace M02A003
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados.
            int primeiro = 0;
            int segundo = 0;
            Console.WriteLine("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(),out primeiro);

            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out segundo);

            //Saida de dados.
            Console.WriteLine($" {primeiro} = {segundo} ? [{primeiro == segundo}]");
            Console.WriteLine($" {primeiro} != {segundo} ? [{primeiro != segundo}]");
            Console.WriteLine($" {primeiro} > {segundo} ? [{primeiro > segundo}]");
            Console.WriteLine($" {primeiro} < {segundo} ? [{primeiro < segundo}]");
            Console.WriteLine($" {primeiro} >= {segundo} ? [{primeiro >= segundo}]");
            Console.WriteLine($" {primeiro} <= {segundo} ? [{primeiro <= segundo}]");

        }
    }
}
