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
