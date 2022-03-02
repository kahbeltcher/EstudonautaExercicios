using System;

namespace M02A001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de operadores aritméticos.
            int operando1;
            int operando2;

            //Entrada de dados.
            Console.Write("Dite o primeiro operando: ");
            int.TryParse(Console.ReadLine(), out operando1);
            Console.Write("Dite o segundo operando: ");
            int.TryParse(Console.ReadLine(), out operando2);
            //Realizando as operações.
            Console.WriteLine($"Calculando +{operando1} = {+ operando1} "); // Identidade.
            Console.WriteLine($"Calculando -{operando1} = {- operando1} "); // Negação aritmética.
            Console.WriteLine($"Calculando {operando1} + {operando2} = {operando1 + operando2}"); // Adição.
            Console.WriteLine($"Calculando {operando1} - {operando2} = {operando1 - operando2}"); // Subtração.
            Console.WriteLine($"Calculando {operando1} x {operando2} = {operando1 * operando2}"); // Multiplicação.
            Console.WriteLine($"Calculando {operando1} ÷ {operando2} = {operando1 / operando2}**DIVISÃO INTEIRA**"); // Divisão (inteira).
            Console.WriteLine($"Calculando {operando1} resto {operando2} = {operando1 % operando2}"); // Resto da divisão inteira.

            Console.ReadKey();
        }
    }
}
