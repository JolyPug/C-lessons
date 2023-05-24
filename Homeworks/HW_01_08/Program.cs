using System;

string? numberString = Console.ReadLine();
if (!int.TryParse(numberString, out int number))
{
    Console.WriteLine("Invalid input");
}
else
{
    for (int i = 2; i <= number; i += 2)
    {
        Console.WriteLine(i);
    }
}
