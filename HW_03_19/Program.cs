// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool checkNumber(string number)
{
    int len = number.Length;
    
    if(len == 5)
    {
        if(number[0] == number[4] && number[1] == number[3])
            {
                return true; 
            }
        else
            return false;
    }
    else return false;
}

void Print(string number)
{
    int len = number.Length;
    if(len == 5)
    {
        if(checkNumber(number) == true)
        {
            Console.WriteLine($"{number} ->  да");
        }
        else
        {
            Console.WriteLine($"{number} ->  нет");
        }
    }
    else
    {
        Console.WriteLine( $"{number} -> не является пятизначным");
    }
}
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
Print(number);