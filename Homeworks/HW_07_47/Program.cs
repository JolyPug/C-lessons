
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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