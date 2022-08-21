using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_11
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

            Console.WriteLine("\nВывод массива: ");
            for (int i = myArray.Length - 1; i >= 0; i--)  // вывод элементов массива на консоль в обратном порядке
            {
                Console.WriteLine(myArray[i]);
            }


        }
    }
}
