// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Make3FirstDigitValue(int num)
{
    if ( num < 1000 && num > -1000 )
        { return num; }
    else
        { return Make3FirstDigitValue(num/10); }
    // while (num >= 1000)
    //   {
    //        num /= 10;
    //    }
}

Console.Clear();
Console.Write("Введите любое целое число > 0: ");
int num = int.Parse(Console.ReadLine() ?? "0");

if ( num < 100 && num > -100 ) 
{
    Console.WriteLine($"В числе {num} третьей цифры нет.");
}
else 
{
    // Console.Write($"В числе {num} третья цифра ");
    // while (num >= 1000)
    //   {
    //        num /= 10;
    //    }
    //Console.WriteLine($" {num % 10}.");
    Console.WriteLine($"В числе { num } третья цифра { Math.Abs(Make3FirstDigitValue(num) % 10) }.");
}