
int ReadAndConvert(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadAndConvert("Введите число: ");
int SecondDigit = number / 10 % 10;
bool CheckNumber(int number)
{
    if (number < 100 || number >=1000)
 {
    return true;
 }
 return false;
}
 void Print(int number, int SecondDigit)
{
    if(CheckNumber(number) == true)
    {
        Console.WriteLine($"Не трехзначное число -> {number}");
        return;
    }
    Console.WriteLine($"{number} -> {SecondDigit}");
}
Print(number, SecondDigit);