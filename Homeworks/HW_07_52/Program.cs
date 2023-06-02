// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] SetArray(int m, int n)
{
    Random rnd = new Random();
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
            Console.Write("{0,3}", array[i, j]);
        }
        Console.WriteLine();
    }

    return array;
}

void CalculateColumnAverage(double[,] array, int m, int n)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double columnSum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            columnSum += array[j, i];
        }
        double columnAvg = columnSum / array.GetLength(0);
        Console.WriteLine($"Среднее значение {i + 1}-го столбца: {columnAvg:F2}");
    }
}

int m = 3, n = 4;
double[,] array = SetArray(m, n);
CalculateColumnAverage(array, m, n);
