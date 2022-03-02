using System;

namespace M02A004
{
    class Program
    {
        static void Main(string[] args)
        {
            bool V = true;
            bool F = false;

            Console.WriteLine($"não {V} = {!V}"); //Operador lógico NÃO 
            Console.WriteLine($"não {V} e {F} = {V && F}"); //Operador lógico E
            Console.WriteLine($"não {V} ou {F} = {V || F}"); //Operador lógico OU



        }
    }
}
