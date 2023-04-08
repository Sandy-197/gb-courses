// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool IsWeekend(int num)
{
    if ( num > 5 ) 
        {
            return true;
        }
        else 
        {
            return false;
        }
}

Console.Clear();
Console.Write("Введите любую цифру, обозначающую день недели 1 - 7: ");
int num = int.Parse(Console.ReadLine() ?? "0");
if ( num >= 1 && num <= 7 )  
    {   
        if (IsWeekend(num))
            {
                Console.WriteLine("Да. Сегодня выходной день.");
            }
        else 
            {
                Console.WriteLine("Нет. Сегодня рабочий день.");
            }
        // if ( num > 5 ) 
        //   {
        //        Console.WriteLine("Да. Сегодня выходной день.");
        //    }
        //    else 
        //    {
        //        Console.WriteLine("Нет. Сегодня рабочий день.");
        //    }
    }
else 
    {
        Console.WriteLine($"Вы ввели {num} не верный номер недели, требуется 1 - 7.");
    }
