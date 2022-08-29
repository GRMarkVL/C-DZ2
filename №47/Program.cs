// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();

double[,] CreateMatrixRndDouble(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }
    }

    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],5} ,");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}

int Rows()
{
    while (true)
    {
        try
        {
            Console.Write("Введите количество строк: ");
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

int Colums()
{
    while (true)
    {
        try
        {
            Console.Write("Введите количество столбцов: ");
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

int m = Rows();

int n = Colums();

Console.WriteLine();

Console.WriteLine($"m = {m}, n = {n}");

double[,] array2d = CreateMatrixRndDouble(m, n, -10, 10);

PrintMatrixDouble(array2d);