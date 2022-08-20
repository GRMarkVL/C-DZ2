//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 


Console.Clear();

int[] CreateArrayRndInt(int size,int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] GetSumPosNegElem(int[] array)
{
    int sumPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
      if (i % 2 != 0) sumPos += array[i];
    }

    return new int[] {sumPos};
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int[] arr = CreateArrayRndInt(4,-99,99);

PrintArray(arr);
int[] sumPosNegElem = GetSumPosNegElem(arr);
Console.WriteLine($"Cумма стоящих на нечётных позициях (индексах): {sumPosNegElem[0]}");