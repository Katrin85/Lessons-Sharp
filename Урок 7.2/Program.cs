using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_7._2
{
    internal class Program
    {
        static int[,] GetRandomArrya (int rows, int colums)
        {
            Random random = new Random();
            var result = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                    result[i, j] = random.Next(100);
            }
            return result;
        }
        static void Main(string[] args)
        {
            int rows = 10;
            int colums = 5;
            var myArrya = GetRandomArrya(rows, colums);

            for (int i = 0; i < rows; i++)
            {
               for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{myArrya[i, j]}\t");
                }
               Console.WriteLine();
            }


        }
    }
}
