
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число A: ");

int a = int.Parse(Console.ReadLine());

int NumberToThePower(int baseNumber, int degreeNumber)
{
    int result = baseNumber;
    for (int i = 1; i < degreeNumber; i++)
    {
        result = result * baseNumber;
    }
    return result;
}

while (true)
{
    Console.Write("Введите натуральное число B: ");
    int b = int.Parse(Console.ReadLine());
    if (b > 0)
    {
        int num = NumberToThePower(a, b);
        Console.WriteLine($"{a}, {b} -> {num}");
        break;
    }

    else
    {
        Console.WriteLine("Вы ввели не натуральное число! Повторите попытку!");
        continue;
    }

}