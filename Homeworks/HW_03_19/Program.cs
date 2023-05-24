// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

string? input = Console.ReadLine();
if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Invalid input");
    return;
}

string[] inputNumbers = input.Split(',');
if (inputNumbers.Length != 1 || !int.TryParse(inputNumbers[0], out int number))
{
    Console.WriteLine("Invalid input");
    return;
}

int remainder = number % 2;
Console.Write($"{number} -> {(remainder == 0 ? "Да" : "Нет")}");
