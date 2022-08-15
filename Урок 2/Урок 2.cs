Console.WriteLine("Ввeдите первое число: : ");
double one = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввeдите второе число: : ");
double two = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( "Выбирете операцию: '+', '-', '*', '/' ");
string? action = Console.ReadLine();

switch (action)
{
    case "+":
        {
            Console.Write("Ответ =  ");
            Console.Write(one + two);
        }
        break;
    case "-":
        {
            Console.Write("Ответ =  ");
            Console.Write(one - two);
        }
        break;
    case "*":
        {
            Console.Write("Ответ =  ");
            Console.Write(one * two);
        }
        break;
    case "/":
        if (two == 0)
            Console.WriteLine("На ноль делить НЕЛЬЗЯ!");
        else
        {
            Console.Write("Ответ =  ");
            Console.Write(one / two);
        }
        break;
    default:
        Console.WriteLine("Я не знаю такого действия, попробуйте еще раз");
        break;
}
Console.ReadLine();