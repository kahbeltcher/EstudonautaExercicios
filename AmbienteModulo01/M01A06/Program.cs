using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constantes são variáveis que não variam.
            // Normalmente constante são colocadas com letras maiúsculas para facilitar a visualização.

            const string INSTITUIÇÃO = "Digital Innovation one";
            const float PI = 3.1415f;
            //string instituição = "Dio.me"; // Comando dá erro!
            
            Console.WriteLine("Eu estudo na " + INSTITUIÇÃO); // Esse + não é de soma e sim de concatenação (ligação).
            Console.WriteLine("O valor de Pi é " + PI);
            Console.WriteLine("O tipo de Pi no meu programa é " + PI.GetType());
            Console.WriteLine("O valor oficial de Pi é " + Math.PI);
            Console.WriteLine("O tipo de Pi em Math é " + Math.PI.GetType());
            Console.ReadKey();
            
        }
    }
}
