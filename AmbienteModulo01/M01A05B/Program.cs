using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A05B
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarações de algumas variáveis.
            byte idade = 28;
            ushort publico = 45_294; 
            float media = 7.9F; //Todo número float vai pedir f ou F no final das declarações.
            decimal estrela = 4.59394349349M; //Todo número decimal vai pedir a letra m ou M no final das declarações.
            bool aprovado = true;

            Console.WriteLine("A média é: " + media);
            // Se você estiver com o sistema de numeração brasileiro no seu teclado ele provavelmente
            // mostrará uma virgula e não um ponto no valor média.
            Console.ReadKey();
        }
    }
}
