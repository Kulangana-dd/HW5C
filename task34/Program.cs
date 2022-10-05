/* Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/


void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] finalArray)
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

int CountOfEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

int countOfEvenNumbers = CountOfEvenNumbers(array);
Console.WriteLine(" ");
Console.WriteLine($"Количество четных чисел в массиве: {countOfEvenNumbers}");
