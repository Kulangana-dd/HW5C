/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-99, 100);
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

int SumOfNumbersInOddPositions(int[] currentArray)
{
    int result = 0;
    for (int i = 1; i < currentArray.Length; i = i + 2)
    {
        result = result + currentArray[i];
    }
    return result;
}

int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");

int sumOfNumbers = SumOfNumbersInOddPositions(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {sumOfNumbers}");
