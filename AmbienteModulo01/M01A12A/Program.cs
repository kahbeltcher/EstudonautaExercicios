using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A12A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá,qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá  {nome} ! Tudo bem ? ");
            Console.ReadKey();

            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;

            Console.WriteLine($"Hoje é {dia} do  mês {mes} do ano de {ano}");
            //interpolação de string 

        }
    }
}
