using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random           gerador           new                  Random();
            //nome da classe,nome do objeto,comando instanciador,chamada para um método construtor.
            Random gerador = new Random();
            int numero = gerador.Next(100);

            Console.WriteLine("Acabei de gerar o número: " +  numero);
            Console.ReadKey();
        }
    }
}
