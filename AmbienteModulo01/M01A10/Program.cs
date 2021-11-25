using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A10
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day; // Dia atual.
            int mes = DateTime.Now.Month; // Mês atual.
            int ano = DateTime.Now.Year; // Ano atual.
            int hora = DateTime.Now.Hour; // Hora atual.
            int minutos = DateTime.Now.Minute; // Minuto atual.
            int segundos = DateTime.Now.Second; // Segundo atual.

            Console.WriteLine(" DATA - "+ dia + "/" + mes + "/" + ano );
            Console.WriteLine(" HORA - " + hora + ":" + minutos + ":" + segundos);
            Console.ReadKey();
        }
    }
}
