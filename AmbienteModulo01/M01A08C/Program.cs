using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int primeiroNumero = Convert.ToInt16(Console.ReadLine());
            int segundoNumero = primeiroNumero * 2;
            Console.WriteLine("O dobro de " + primeiroNumero + " é " + segundoNumero);
            Console.ReadKey();
        }
    }
}
