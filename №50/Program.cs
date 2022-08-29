// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.Clear();

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

void CheckPositiionMatrix(int rowPosition,int columPosition, int[,] array)
{
    try
    {
        Console.WriteLine($"{rowPosition}, {columPosition} -> {array[rowPosition-1,columPosition-1]}");
    }
    catch
    {
        Console.WriteLine($"{rowPosition}, {columPosition} -> такого элемента в массиве нет");
    }
}

int[,] CreateMatrixRndInt(int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rnd.Next(2,10),rnd.Next(2,10)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min,max);
        }
    }

    return matrix;
}

int RowNumber()
{
    while (true)
    {
        try
        {
            Console.Write("Введите номер строки: ");
            int mTmp = int.Parse(Console.ReadLine());

            if (mTmp <= 0)
            {
                Console.WriteLine("Пожалуйста, введите значение больше нуля!");
                Console.WriteLine();
                continue;
            }
            else return mTmp;
        }
        catch 
        {
            Console.WriteLine("Ошибка! Некорректный формат! Повторите попытку!");
            Console.WriteLine();
            continue;
        }
    }
}

int ColumNumber()
{
    while (true)
    {
        try
        {
            Console.Write("Введите номер столбца: ");
            int nTmp = int.Parse(Console.ReadLine());

            if (nTmp <= 0)
            {
                Console.WriteLine("Пожалуйста, введите значение больше нуля!");
                Console.WriteLine();
                continue;
            }
            else return nTmp;
        }
        catch 
        {
            Console.WriteLine("Ошибка! Некорректный формат! Повторите попытку!");
            Console.WriteLine();
            continue;
        }
    }
}

System.Console.WriteLine("Введите позиции элемента: ");

Console.WriteLine();

int rowPos = RowNumber();

int columPos = ColumNumber();

Console.WriteLine();

int[,] array2d = CreateMatrixRndInt(1, 10);

PrintMatrix(array2d);

Console.WriteLine();

CheckPositiionMatrix(rowPos,columPos,array2d);

Console.WriteLine();