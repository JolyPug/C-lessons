// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpiralArray(int[,] array)
{
    int n = array.GetLength(0);
    int value = 1;
    int rowStart = 0;
    int rowEnd = n - 1;
    int colStart = 0;
    int colEnd = n - 1;

    while (value <= n * n)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = value;
            value++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = value;
            value++;
        }
        colEnd--;

        for (int i = colEnd; i >= colStart; i--)
        {
            array[rowEnd, i] = value;
            value++;
        }
        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            array[i, colStart] = value;
            value++;
        }
        colStart++;
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j].ToString("D2") + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
FillSpiralArray(array);

Console.WriteLine("Спиральный массив 4x4:");
PrintArray(array);