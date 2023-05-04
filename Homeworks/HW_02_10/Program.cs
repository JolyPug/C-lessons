
int ReadAndConvert(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Print(int number)
{
    if (number < 100 || number >= 1000)
    {
        Console.WriteLine($"Ошибка: {number} не является трехзначным числом.");
        return;
    }

    int secondDigit = number / 10 % 10;
    Console.WriteLine($"{number} -> {secondDigit}");
}

int number = ReadAndConvert("Введите число: ");
Print(number);