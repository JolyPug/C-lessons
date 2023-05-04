// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


double Distance(int xA, int yA, int zA, int xB, int yB, int zB)
{   
    double distanceNaN = Math.Abs((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA) + (zB - zA)*(zB - zA));
    double result = Math.Sqrt(distanceNaN);
    Console.WriteLine($"{distanceNaN}");
    return result;
}

void Print(int xA, int yA, int zA, int xB, int yB, int zB)
{
    if(Distance(xA, yA, zA, xB, yB, zB) > 0)
    {
        Console.WriteLine($"A({xA},{yA},{zA}); B({xB},{yB},{zB}) - > {Distance(xA, yA, zA, xB, yB, zB)}");
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

Print(xA, yA, zA, xB, yB, zB);
