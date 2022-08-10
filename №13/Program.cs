// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int thirdDigit = num % 10;
    return thirdDigit;
}

while (true)
{
    Console.Write($"Введите число: ");
    int number = int.Parse(Console.ReadLine());
    if (number > 99)
    {
        Console.WriteLine($"{number} -> {ThirdDigit(number)}");
        break;
    }
    else
    {
        Console.WriteLine($"{number} -> третьей цифры нет");
        continue;
    }
}