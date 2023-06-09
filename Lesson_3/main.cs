// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


bool checkNumber(string number)
{
    int len = number.Length;

    if (len == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
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
    if (len == 5)
    {
        if (checkNumber(number) == true)
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
        Console.WriteLine($"{number} -> не является пятизначным");
    }
}
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
Print(number);





// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


double CalculateDistance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double distanceSquared = Math.Abs(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
    double result = Math.Sqrt(distanceSquared);
    return result;
}

void PrintDistance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double distance = CalculateDistance(xA, yA, zA, xB, yB, zB);
    if (distance > 0)
    {
        Console.WriteLine($"A({xA},{yA},{zA}); B({xB},{yB},{zB}) - > {distance}");
    }
    else Console.WriteLine($"Невозможно посчитать расстояние");
}

Console.WriteLine("Введите координаты точки A: ");
string[] numberA = Console.ReadLine().Split(',');
int xA = Convert.ToInt32(numberA[0]);
int yA = Convert.ToInt32(numberA[1]);
int zA = Convert.ToInt32(numberA[2]);

Console.WriteLine("Введите координаты точки B: ");
string[] numberB = Console.ReadLine().Split(',');
int xB = Convert.ToInt32(numberB[0]);
int yB = Convert.ToInt32(numberB[1]);
int zB = Convert.ToInt32(numberB[2]);

PrintDistance(xA, yA, zA, xB, yB, zB);





// Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void PrintCubes(int number)
{
    Console.Write($"{number} -> ");
    for (int i = 1; i <= number; i++)
    {
        Console.Write(Math.Pow(i, 3) + ",");
        if (i != number)
            Console.Write(", ");
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintCubes(number);