// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] SetRandomArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
        }
    }

    return array;
}
void PrintArray(int[,] array)
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
void SummarizeNumbers(int[,] array)
{
    int rowCount = array.GetLength(0);
    int colCount = array.GetLength(1);

    int minSum = 0;
    for (int j = 0; j < colCount; j++)
    {
        minSum += array[0, j];
    }

    int minIndex = 0;

    for (int i = 1; i < rowCount; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < colCount; j++)
        {
            rowSum += array[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minIndex = i;
        }
    }

    Console.WriteLine($"Строка с наименьшей суммой элементов: {minIndex + 1} строка");
}

int m = 4;
int n = 4;
int[,] array = new int[m, n];
SetRandomArray(array);
PrintArray(array);
SummarizeNumbers(array);