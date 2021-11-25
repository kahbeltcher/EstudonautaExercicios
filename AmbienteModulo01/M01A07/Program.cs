using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A07
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            * Conversão Implícita int -> float
            * int a = 20;
            * float b = a;
            */

            /* 
            * Conversão Explícita float -> int
            * float a = 20;
            * int b = a; 
            * Dá erro por causa do tipo.
            */

            /*
            * float a = 20.943f;
            * int b = (int) a; 
            * Para essa atribuição ele vai pegar só a parte inteira de a.
            * typecast
            */

            //Conversão por classes auxiliares 

            float a = 20.9f;
            int b = Convert.ToInt16(a); // faz o arredondamento mais aproximado.

            Console.WriteLine("O valor de a é " + a + " o tipo é " + a.GetType());
            Console.WriteLine("O valor de b é " + b + " o tipo é " + b.GetType());
            Console.ReadKey();
        }
    }
}
