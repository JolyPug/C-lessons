// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] SetRandomNumbers(int m, int n)
{

    double[,] array = new double[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.NextDouble();
        }
    }
    return array;

}
void PrintArray(double[,] array, int m, int n)
{
    int count_i = 0;
    int count_j = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j].ToString("F2")}   ");
            count_j++;
        }
        count_i++;
    }
}
int m = 3, n = 4;
double[,] array = SetRandomNumbers(m, n);
PrintArray(array, m, n);




// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void SetAndCheckArray(int m, int n, int number, int min_rand_number, int max_rand_number)
{
    double[,] array = new double[m, n];
    Random rand = new Random();
    bool found = false;
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(min_rand_number, max_rand_number);
            Console.Write($"{array[i, j]}, ");
            if (array[i, j] == number)
            {
                found = true;
                count++;
            }
        }
    }
    Console.WriteLine();
    if (found)
        Console.WriteLine($"{number} -> такое число встречается {count} раз");
    else
        Console.WriteLine($"{number} -> такого числа нет");
}

int m = 3, n = 4, number = 17;
int min_rand_number = 0;
int max_rand_number = number + 1;
if (m == 0 || n == 0)
    Console.WriteLine("Числа m или n не должны быть равны нулю");
else
    SetAndCheckArray(m, n, number, min_rand_number, max_rand_number);





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
