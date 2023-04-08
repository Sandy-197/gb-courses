int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? "";
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    // if ( weekDay > 5 )  // с 11 - 15 строку их код.
    // {
    //     return true;
    // }
    // return false;

    return ( weekDay > 5 ); // мой вараинт
}

bool ValidateWeekday(int number)
{
    // if ( number > 0 && number < 8 )  // c 22 - 27 строку их код.
    // {
    //    return true;
    // }
    // Console.WriteLine("Это не день недели!");
    // return false;

    return ( number > 0 && number < 8 ); // мой вараинт
}

int weekDay = Prompt("Введите день недели >");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Наконец-то выходной");
    }
    else
    {
        Console.WriteLine("Придется поработать");
    }
}
else   // при моем варианте сообщение выводиться здесь, если их вараиант то с 44 - 47 строки нужно закоментить.
{
    Console.WriteLine("Это не день недели!");
}