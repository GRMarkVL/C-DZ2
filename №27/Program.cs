//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());
int SumDig(int num)
{
    int sum = 0;
    if (num == 0) return 1;
    if (num < 0) num = -num;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;

    }
    return sum;
}
int sumdigit = SumDig(number);

Console.WriteLine($"{number} -> {sumdigit}");