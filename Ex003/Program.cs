using System;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Digite um numero: ");
            float num = 0;
            float.TryParse(Console.ReadLine(), out num);
            float n1 =(int) num;
            int n2 = Convert.ToInt16(num);

            Console.WriteLine("--------------------------------");
            Console.WriteLine($" Você digitou o valor: {num:F3}");
            Console.WriteLine($" A parte inteiro do número é: {n1}");
            Console.WriteLine($" Arredondando,temos o número: {n2}");


            Console.ReadKey();
        }
    }
}
