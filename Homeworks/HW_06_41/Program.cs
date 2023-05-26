// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void CountPositiveNumbers(int[] numbers_int)
{
    int counter = 0;
    for (int i = 0; i < numbers_int.Length; i++)
    {
        if (numbers_int[i] > 0)
            {counter++;}
        Console.Write($"{numbers_int[i]},");
    }
Console.Write($" -> {counter}");
}

Console.Write("Numbers = ");
string[] numbers_string = Console.ReadLine().Split(',');
int[] numbers_int = numbers_string.Select(int.Parse).ToArray();

CountPositiveNumbers(numbers_int);