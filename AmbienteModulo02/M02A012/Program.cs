using System;

namespace M02A012
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 6;
            int n2 = 9;
            int n3 = n1++ + --n2;
            // n2 vai perde 1
            // n2 então passará a valer 8 por ser um pré decremento
            // após vai ser somado 8 com 6 que dará o valor 14
            // depois ele vai somar 1 no n1
            // que vai passar a valer 7     
            // o resultado ficará em 7 - 8 - 14  
            Console.WriteLine($"n1 vale {n1} ,n2 vale {n2} e n3 vale {n3}");
            

        }
    }
}
