using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M01A11A
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            Console.Write("Today is ");
            Thread.Sleep(2000);
            Console.Write(day);
            Thread.Sleep(2000);
            Console.Write(" Of the month ");
            Thread.Sleep(2000);
            Console.Write(month);
            Console.ReadKey();
        }
    }
}
