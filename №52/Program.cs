// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
void FillArray(double[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            array[i, j] = new Random().Next(-99, 100); 
        }

    }
}

void PrintArray(double[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("введите число строк двумерно массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов двумерно массива n:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] new_array = new double[m, n]; 
FillArray(new_array); 
Console.WriteLine($"Двумерный массива размера m={m} на n={n} имеет вид: ");
PrintArray(new_array); 


for (int i = 0; i < n; i++) 
{
  double sredArifmStolbec = 0;
   for (int j = 0; j < m; j++) 
   {
     sredArifmStolbec = sredArifmStolbec + new_array[j, i];
   }
  sredArifmStolbec = Math.Round(sredArifmStolbec / m, 1); 
   
   Console.WriteLine($"Сред.арифметическое столбца {i+1} = {sredArifmStolbec}");
 }
Console.WriteLine();

for (int i = 0; i < m; i++) 
{
  double sredArifmStroka = 0;
  for (int j = 0; j < n; j++) 
  {
    sredArifmStroka = sredArifmStroka + new_array[i, j];
  }

  sredArifmStroka = Math.Round(sredArifmStroka / n, 1);
  Console.WriteLine($"Сред.арифметическое строки {i+1} = {sredArifmStroka}");
}