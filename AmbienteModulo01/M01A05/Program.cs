using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A05
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var n = 0;  Se você utiliza var, fica por conta da linguagem de programação decidir (( o tipo )) da variável
            * podendo ocupar mais memória.
            * byte n = 0;
            * O tipo byte ocupa bem menos memória.
            * A definição do tipo primitivo é algo muito importante.
            */

            //Declaração de variável.
            //nome = n , tipo = byte , valor = 125 . 
            byte n = 125;

            Console.WriteLine("A variável n tem o valor: " + n);
            Console.WriteLine("N é do tipo " + n.GetType());
            // Todo método tem (); ex: GetType
            Console.ReadKey();
        }
    }
}
