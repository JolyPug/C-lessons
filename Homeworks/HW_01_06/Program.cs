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
