
int ReadAndConvert(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
int GetThirdDigit(int number)
{
    while(number > 999)
        number /=10;
    return number % 10;
}
bool CheckNumber(int number)
{
    if(number < 100)
        return false;
    return true;
}
void Print(int number)
{
    if(CheckNumber(number))
        Console.WriteLine($"{number} -> {GetThirdDigit(number)}");
    else 
        Console.WriteLine($"{number} -> нет третьей цифры");
}
int number = ReadAndConvert("Введите число:");
Print(number);