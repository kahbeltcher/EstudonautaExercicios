using System;

namespace M02A002
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            Console.Write("Numerador: ");
            int.TryParse(Console.ReadLine(), out firstNumber);

            Console.Write("Denominador: ");
            int.TryParse(Console.ReadLine(), out secondNumber);

            Console.WriteLine($"Divisão inteira: {firstNumber} ÷ {secondNumber} = {firstNumber/secondNumber}");
            Console.WriteLine($"Divisão real: {firstNumber} ÷ {secondNumber} = {(float)firstNumber / secondNumber:F2}");

            Console.ReadKey();
        }
    }
}
