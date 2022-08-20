// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();

int ElArray()
{
    while (true)
    {
        Console.Write("Введите количество элементов массива: ");
        int elementsTmp = int.Parse(Console.ReadLine());
        if (elementsTmp <= 0)
        {
            Console.WriteLine("Введите число больше нуля!");
            continue;
        }
        else
        {
            return elementsTmp;
        }
    }
}
int elements = ElArray();
int[] RndArray(int elem)
{
    Random rnd = new Random();
    int[] array = new int[elem];
    for (int i = 0; i < elem; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}
int[] array = RndArray(elements);
void PrintArray(int[] arr, int elem)
{
    for (int i = 0; i < elem - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }

    Console.Write($"{arr[elem - 1]} -> [");

    for (int i = 0; i < elem - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }

    Console.Write($"{arr[elem - 1]}]");
}

PrintArray(array, elements);
