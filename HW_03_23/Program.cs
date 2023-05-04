// Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void Init(int number)
{
    Console.Write($"{number} -> ");
    int power = 3;
    for(int i = 0; i < number; i++)
    {
        Console.Write(Math.Pow(i, power) + ",");
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Init(number);