//  Задайте массив вещественных чисел.
//   Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max-min)+ min),1);
    }
    return array;
}
double DiffMaxMinElem(double[] array)
{
    double maxelem = array[0]; 
    double minelem = array[0];

    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > maxelem) maxelem = array[i];
       if (array[i] < minelem) minelem = array[i];
    }

    double diffmaxmin = maxelem - minelem;

    return diffmaxmin;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

double[] arr = CreateArrayRndDouble(10, 1, 99);
double diffMaxMinElem = DiffMaxMinElem(arr);

PrintArray(arr);
Console.Write($" -> {Math.Round(diffMaxMinElem,1)}");
Console.WriteLine();