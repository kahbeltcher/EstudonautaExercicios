using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08E
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.Write("Digite um número:");
            int.TryParse(Console.ReadLine(),out numero);
            /* 
             * Tente converter e se tudo der certo coloque o valor dentro de número. 
             * Se não conseguir número irá receber o valor 0.
            */
            int dobro = numero * 2;
            Console.WriteLine("O dobro de " + numero + " é " + dobro);
            Console.ReadKey();

        }
    }
}
