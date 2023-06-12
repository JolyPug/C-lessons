// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void PrintNumbers(int n)
{
    if (n == 0)
    {
        return;
    }
    else
    {
        Console.Write(n + ", ");
        PrintNumbers(n - 1);
    }
}
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbers(n);

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

// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));
    else
        return -1;
}
Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
int res = Ackermann(m,n);
Console.WriteLine(res);