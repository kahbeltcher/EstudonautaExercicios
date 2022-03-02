using System;

namespace M02A014
{
    class Program
    {
        static void Main(string[] args)
        {
            int base1 = 5;
            int pot = 2;
            double resp = Math.Pow(base1, pot);

            Console.WriteLine($"O resultado de {base1} elevado a {pot} é igual a {resp}");
        }
    }
}
