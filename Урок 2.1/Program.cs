using System;


namespace Урок_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool asd = true;
            while (asd)
            {
                Console.Clear();
                double one, two;
                try
                {
                    Console.WriteLine("Ввeдите первое число: : ");
                    one = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ввeдите второе число: : ");
                    two = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вы ввели не правильное значение, повторите попытку.");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Выбирете операцию: '+', '-', '*', '/' ");
                string action = Console.ReadLine();
                if (action == "+")
                    Console.WriteLine(one + two);
                if (action == "-")
                    Console.WriteLine(one - two);
                if (action == "*")
                    Console.WriteLine(one * two);
                if (action == "/")
                    if (two == 0)
                        Console.WriteLine("ОШИБКА! На 0 делить НЕЛЬЗЯ!");
                    else
                        Console.WriteLine(one / two);
                else
                    Console.WriteLine("Я не знаю такого действия, попробуйте еще раз");
            
   
            }    

        }
    }
}
