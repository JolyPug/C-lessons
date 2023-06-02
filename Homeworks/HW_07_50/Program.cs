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