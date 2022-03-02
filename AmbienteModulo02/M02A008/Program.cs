using System;

namespace M02A008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            //int n1 = 0b_10010; binário 
            //int n2 = 0x_8abf; hexadecimal 

            Console.WriteLine("Digite um número: ");
            int.TryParse(Console.ReadLine(), out numero);

            Console.WriteLine($"O número {numero} corresponde a " +
            $"{Convert.ToString(numero,toBase:2)} na base binária");

            Console.WriteLine($"O número {numero} corresponde a " +
            $"{Convert.ToString(numero, toBase: 8)} na base Octal");

            Console.WriteLine($"O número {numero} corresponde a " +
            $"{Convert.ToString(numero, toBase: 16)} na base Hexadecimal");
        }
    }
}
