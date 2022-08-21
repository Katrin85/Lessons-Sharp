using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_8
{
    internal class Program
    {  // тернарный оператор или замена if_else
        static void Main(string[] args)
        {
            bool accessAllowed;
            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();

            //if (enteredPassword == storedPassword)
            //{
            //    accessAllowed = true;
            //}
            //else
            //{
            //    accessAllowed = false;
            //}
            //Console.WriteLine(accessAllowed);

            //Console.ReadLine();

            accessAllowed = enteredPassword == storedPassword?  true: false;
               
            Console.WriteLine(accessAllowed);
        }
    }
}
