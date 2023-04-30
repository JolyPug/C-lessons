// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


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

// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


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

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int ReadAndConvert(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
int CheckNumber(int number)
{
    if (number > 7)
        return 0;
    else 
    return number;
}
bool IsWeekend(int number)
{
    if(number < 5)
        return false;
    else
        return true;
}
void Print(int number)
{   
    if(CheckNumber(number) == 0)
    {
        Console.WriteLine($"Чило {number} не является днем недели");
        return;
    }
    if(IsWeekend(number) == true)
        Console.WriteLine($"{number} -> да");
    else
        Console.WriteLine($"{number} -> нет");
}
int number = ReadAndConvert("Введите день недели:");
Print(number);

// конец


