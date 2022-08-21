using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Урок_14
{ // как работать с массивами в с#
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] myArray = { 111, 10, 4, 99, 64, 77, 4, 42, 5 };

            // int result = myArray.Min(); // найти минимальное значение в массиве
            // Console.WriteLine(myArray.Min());
            //  int sum = myArray.Sum(); // найти сумму всех элементов массива
            // Console.WriteLine(myArray.Sum());

            // int where = myArray.Where(i => i % 2 == 0).Sum(); // сумма всех четных элементов массива
            //Console.WriteLine(where);

            //  int minNechet = myArray.Where(i => i % 2 != 0).Min(); // самое маленькое не четное число массива
            //    Console.WriteLine(minNechet);

            ////int[] myArray = { 111, 10, 4, 99, 64, 10, 4, 111, 64 };
            ////int[] resalt = myArray.Distinct().ToArray(); // найти уникальный элемент массива и поместить его в новый массив
            ////Console.WriteLine(resalt);

            int[] myArray1 = { 111, 10, 4, 99, 64, 10, 4, 111, 64 };  // отсортировка массива
            //int[] result = myArray1.OrderBy(i => i).ToArray();
            //Console.WriteLine(result);
        }
    }
}
