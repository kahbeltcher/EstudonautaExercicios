using System;

namespace M02A006
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura = 0f;
            Console.WriteLine("Qual é a sua altura em metros? ");
            float.TryParse(Console.ReadLine(), out altura);
            string status = (altura <= 1.70) ? "baixa" : "alta";
            Console.WriteLine($"Alguém com {altura:F1} é considerado uma pessoa {status}!");

        }
    }
}
