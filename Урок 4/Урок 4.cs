using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Урок 4

            //    int i = 0;
            //    for (; i < 3; i++)
            //    {
            //        Console.WriteLine("for_1:" + i);
            //    }
            //    for (; i < 5; i++)
            //    {
            //        Console.WriteLine("for_2:" + i);
            //    }

            //for (int i = 0, j = 5; i < 10 && j < 12; i++, j++)
            //{
            //    Console.WriteLine("i: " + i);
            //    Console.WriteLine("j:" + j);
            //}

            //int i = int.Parse(Console.ReadLine());

            //for (; i >= 0; i--)  // цикл for в обратную сторону
            //{
            //  Console.WriteLine(i);
            //}

            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            for (; i >= 0; i--, j++)                        // цикл for в обратную сторону
            {
                Console.WriteLine(i);
                Console.WriteLine(j);
            }
        }
    }
}
