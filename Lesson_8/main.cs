using System;
// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
int[,] SortByDescending(int[,] array)
{
    int rowCount = array.GetLength(0);
    int columnCount = array.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount - 1; j++)
        {
            for (int k = j + 1; k < columnCount; k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
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

int m = 4;
int n = 4;

int[,] array = new int[m, n];

SetRandomArray(array);
PrintArray(array);
SortByDescending(array);
Console.WriteLine("Sorted array: ");
PrintArray(array);




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




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] GenerateRandomMatrix(int rows, int cols)
{
    Random random = new Random();
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            matrix[i, j] = random.Next(1, 10);
    }
    return matrix;
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);


    int[,] result = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            for (int k = 0; k < cols1; k++)
                result[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
    return result;
}
void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
}

int rows1 = 2;
int cols1Rows2 = 2;
int cols2 = 2;

int[,] matrix1 = GenerateRandomMatrix(rows1, cols1Rows2);
int[,] matrix2 = GenerateRandomMatrix(cols1Rows2, cols2);

Console.WriteLine("Первая матрица:");
PrintMatrix(matrix1);

Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix2);

int[,] result = MultiplyMatrices(matrix1, matrix2);

Console.WriteLine("Результирующая матрица:");
PrintMatrix(result);


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




int[,,] GenerateArray()
{
    int[,,] array = new int[2, 2, 2];
    int[] usedNumbers = new int[100];
    Random random = new Random();

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                int number;
                do
                {
                    number = random.Next(10, 100);
                } while (usedNumbers[number] == 1);

                array[i, j, k] = number;
                usedNumbers[number] = 1;
            }
        }
    }

    return array;
}

void PrintArray(int[,,] array)
{
    int dim1 = array.GetLength(0);
    int dim2 = array.GetLength(1);
    int dim3 = array.GetLength(2);

    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
    }
}


int[,,] array = GenerateArray();

Console.WriteLine("Трехмерный массив:");
PrintArray(array);



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