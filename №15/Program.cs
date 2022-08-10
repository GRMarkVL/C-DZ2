
void WeekDay()
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
    Console.Write("Введите цифру соответствующую дню недели: ");
    int number = int.Parse(Console.ReadLine());
    if (number > 0 && number < 8)
    {
        if (number < 6) Console.WriteLine($"{number} -> Будний день");
        else Console.WriteLine($"{number} -> Выходной день");
        break;
    }
    else
    {
        Console.WriteLine("Вы ввели не соответсвующий цифру, попробуйте еще раз!");
        continue;
    }
 }