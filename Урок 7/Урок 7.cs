using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_7
{
    internal class Program
    {
        static void Main(string[] args)
            // Вложенные циклы
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Цикл 1 итерация №: " + i);

                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("\tЦикл 2 итерация №: " + j);

                    for (int k = 0; k <= 2; k++)
                        Console.WriteLine("\t\tЦикл 3 итерация №: " + k);
                }
            }
        }
    }
}
