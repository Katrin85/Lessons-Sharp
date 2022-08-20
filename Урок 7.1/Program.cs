using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника: ");
            int Widht = int.Parse(Console.ReadLine());

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < Widht; i++)
                
                    Console.Write("+");
                
             Console.WriteLine();
            }
        }
    }
}
