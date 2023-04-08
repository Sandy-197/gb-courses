/***Задача 67:**Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

int Prompt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int Sum(int num)
{
    int dig = num / 10;
    int ost = num % 10;
    return (num == dig ) ? num : ost + Sum(dig);
}

int digit = Prompt("Введите цисло: ");
Console.Write (Sum (digit));
