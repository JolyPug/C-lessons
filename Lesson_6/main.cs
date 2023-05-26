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





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



void findCoords(double[] numbers_int)
{
    double b1 = numbers_int[0];
    double k1 = numbers_int[1];
    double b2 = numbers_int[2];
    double k2 = numbers_int[3];
    double y = b2 + (((k2 * b1) - (k2 * b2)) / (-k1 + k2));
    double x = (b1 - b2) / (-k1 + k2);
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}
    Console.WriteLine("1. y = k1 * x + b1\n2. y = k2 * x + b2");
    Console.Write("Введите числа через запятую: b1, k1, b2, k2 = ");
    string[] numbers_string = Console.ReadLine().Split(',');
    double[] numbers_int = numbers_string.Select(double.Parse).ToArray();
findCoords(numbers_int);




