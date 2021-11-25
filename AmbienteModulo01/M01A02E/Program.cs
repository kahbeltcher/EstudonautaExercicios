using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A02E
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(20, 5); // muda a posição.
            Console.ForegroundColor = ConsoleColor.Yellow; //muda a cor das letras.
            Console.BackgroundColor = ConsoleColor.Cyan; //muda a cor de fundo.
            Console.WriteLine("Olá,querido(a) aluna !");//escreve algo na tela.
            Console.ResetColor(); //Define as cores do console de primeiro e segundo planos com os padrões.
            Console.ReadKey(); // aguarda a proxima ação do usúario.
            Console.Clear(); //limpa o terminal.

            Console.SetCursorPosition(40, 15);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Bem-vindo(a) a Digital Innovation One");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.SetCursorPosition(76, 21);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Que Agora é,Dio.me ! ");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.SetCursorPosition(80, 4);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Se você quer aprender C# ");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.SetCursorPosition(30, 25);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Você está no lugar certo !");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.SetCursorPosition(45, 12);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Sem mais delongas,bora começar ;) ");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

        }
    }
}
