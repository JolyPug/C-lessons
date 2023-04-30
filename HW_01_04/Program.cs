using System;

Console.Write("Numbers = ");
string[] numbers = Console.ReadLine().Split(',');
int max = 0;

if (numbers.Length >= 3 && int.TryParse(numbers[0], out int a) && int.TryParse(numbers[1], out int b) && int.TryParse(numbers[2], out int c))
{
    max = (a > b) ? (a > c ? a : c) : (b > c ? b : c);
    Console.WriteLine($"max -> {max}");
}
else
{
    Console.WriteLine("Invalid input");
}
