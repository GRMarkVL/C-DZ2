//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


int SecondDigit(int num)
{
    int secondDigit = (num % 100)/10;
    return secondDigit; //  возвращаемое значение
}

while (true)
{
    Console.Write($"Введите трёхзначное число: ");
    int number = int.Parse(Console.ReadLine());
    if (number > 99 && number < 1000)
    {
        Console.WriteLine($"{number} -> {SecondDigit(number)}");
        break;
    }
    else
    {
        Console.WriteLine("Число не трёхзначное, повторите попытку");
        continue;
    }
}
