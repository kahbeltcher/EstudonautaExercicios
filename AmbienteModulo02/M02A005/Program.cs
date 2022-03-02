using System;

namespace M02A005
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados.
            float primeira = 0f;
            float segunda = 0f;

            Console.Write("Primeira nota: ");
            float.TryParse(Console.ReadLine(), out primeira);

            Console.Write("Segunda nota: ");
            float.TryParse(Console.ReadLine(), out segunda);

            //Cálculo da média e situações.
            float media = (primeira + segunda) / 2;

            // Saida de dados

            Console.WriteLine($"A média do aluno foi: {media:f1}");

            bool sit1 = media >= 0.0 && media < 4.0;
            bool sit2 = media >= 4.0 && media < 7.0;
            bool sit3 = media >= 7.0 && media <=10.0 ;
            if (sit1 == true)
            {
                Console.WriteLine("O aluno está Reprovado");
            }
            else if(sit2 == true)
            {
                Console.WriteLine("O aluno está em Recuperação");
            }
            else
            {
                Console.WriteLine("O aluno está Aprovado!");
            }


        }
    }
}
