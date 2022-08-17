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
            int i = 0;
            for ( ; i < 3; i++)
            {
                Console.WriteLine("for_1:" + i);
            }
            for (; i < 5; i++)
            {
                Console.WriteLine("for_2:" + i);
            }
        }
    }
}
