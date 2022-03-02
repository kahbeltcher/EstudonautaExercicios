using System;

namespace M02A016
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota = 0;
            Console.WriteLine("Digite a nota do aluno: ");
            float.TryParse(Console.ReadLine(), out nota);

            float valor = Math.Clamp(nota, 0, 10);
            Console.WriteLine($"A nota digitada foi: {nota} e o valor foi: {valor}");
            // não será permitido valor acima de 10 e valores abaixo de 0.
        }
    }
}
