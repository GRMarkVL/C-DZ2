//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void WeekDay() // метод ничего не возвращает
{
    string[] weekDay = { "1 -> Понедельник", "2 -> Вторник", "3 -> Среда", "4 -> Четверг", "5 -> Пятница", "6 -> Суббота", "7 -> Воскресенье" };
    foreach (string number in weekDay)
    {
        Console.WriteLine(number);
    }
}

WeekDay();

while(true)
 {
    Console.Write("Введите цифру : ");
    int number = int.Parse(Console.ReadLine());
    if (number > 0 && number < 8)
    {
        if (number < 6) Console.WriteLine($"{number} -> Будний день");
        else Console.WriteLine($"{number} -> Выходной день");
        break;
    }
    else
    {
        Console.WriteLine("В недели всего 7 дней, попробуйте еще раз!");
        continue;
    }
 }