using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A13A
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Karen";
            float salário = 2890.23f;
            int idade = 28;
            Console.WriteLine($"A {nome,-5}  tem {idade,-5:D3} anos e ganha {salário, 10:C} por mês !!!");
            int numero = 13;
            Console.WriteLine($"O valor escolhido foi: {numero:X}");
            float valor = 112.003f;
            Console.WriteLine($"O preço pago foi {valor:N2}");
            Console.WriteLine($"Com o valor científico de: {valor:E}");
            Console.ReadKey();
            /*dentro da interpolação o número que vem depois
            é a quantidade de espaço a ser preenchido
            :C = valor monetário
            :D = valor decimal
            :X = valor hexadecimal
            :N = valor real
            :E = valor científico
            */


        }
    }
}
