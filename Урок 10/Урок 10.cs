using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t ");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"\nВведите элемент массива под индексом {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());

            }


            Console.WriteLine("Ввывод массива: ");
            for (int i = 0; i < myArray.Length; i++)  // вывод элементов массива на консоль
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
