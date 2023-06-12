// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumOfNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        return m + SumOfNumbers(m + 1, n);
    }
}
Console.WriteLine("Введите число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());
int res = SumOfNumbers(m, n);
Console.WriteLine(res);