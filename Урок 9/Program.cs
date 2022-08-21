using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_9
{ // массивы
    internal class Program
    {
        static void Main(string[] args)
        {/*
            int[] myArray; // объявление массива
            myArray = new int[5]; // выделение памяти в массиве
           
            myArray[1] = 3; // помещает данные в массив
            myArray[0] = 10;

            int a = myArray[0]; // можно присвоить каждому индексу переменную

                                // myArray.Length // длина масива
            
            Console.WriteLine(a);
           */

            // int[] myArray = new [] { 5, 2, 7, 9, 1 }; // элементы содержащтеся в масстве
            // создается массив на столько элементов, сколько указано в фигурных скобках

            int[] myArray = Enumerable.Repeat(5, 10).ToArray();  // он повторяет количество элементов определенное кол-во раз
                                                                 // элемент 5, повторений 10.

           // int[] myArray = Enumerable.Range(4, 5).ToArray(); // сщздаем массив из 5 элементов, которые будут содердать цифры 4,5,6,7,8. 
        }
    }
}
