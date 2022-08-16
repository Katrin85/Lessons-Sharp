// Программа будет подсчитывать количество четных и нечетных числ, и считает их сумму в заданном пользователем диапозоне.

uint evenNumbers = 0; // четные числа
uint oddNumbers = 0;  // нечетне числа
int sumEven = 0;
int sumOdd = 0;


Console.WriteLine("Введите первое число диапозона");
int current = int.Parse(Console.ReadLine()); // начальное число, от которого будем считать

Console.WriteLine("Введите последнее число диапозона");
int limit = int.Parse(Console.ReadLine());  // до какого числа будем подсчитывать
while (current <= limit)
{
    if (current % 2 == 0)
    {
        evenNumbers++;
        sumEven += current;
    }
    else
    {
        oddNumbers++;
        sumOdd = sumOdd + current;
    }
    current++;
}



Console.WriteLine("Количество четных чисел: " + oddNumbers);
Console.WriteLine("Сумма четных чисел в диапозоне = " + sumEven);
Console.WriteLine("Количество нечетных чисел " + evenNumbers);
Console.WriteLine("Сумма нечетных чисел в диапозоне = " + sumOdd);
Console.ReadLine();