using System;

namespace M02A007
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.Write("Digite um número inteiro: ");
            int.TryParse(Console.ReadLine(), out numero);

            Console.WriteLine($"O número que você digitou é " +
                             $"{((numero % 2 == 0)? "Par":"Impar" )}");
        }
    }
}
