/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/


void FillArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-99, 100);
        index++;
    }
}

void PrintArray(double[] finalArray)
{
    int count = finalArray.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(finalArray[position]);
        Console.Write(" ");
        position++;
    }
}

double DiffMaxMin(double[] currentArray)
{
    double min = currentArray[0];
    double max = currentArray[0];
    for (int i = 1; i < currentArray.Length; i = i + 1)
    {
        if (currentArray[i] < min)
        {
            min = currentArray[i];
        }
        if (currentArray[i] > max)
        {
            max = currentArray[i];
        }
    }
    return max - min;
}

double[] array = new double[5];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");

double diff = DiffMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {diff}");