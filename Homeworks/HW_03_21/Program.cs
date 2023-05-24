// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

class Program
{
    static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double distanceSquared = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2);
        return Math.Sqrt(distanceSquared);
    }

    static void PrintDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);
        if(distance > 0)
        {
            Console.WriteLine($"Distance between Point 1 ({x1},{y1},{z1}) and Point 2 ({x2},{y2},{z2}) is {distance:F2}");
        }
        else Console.WriteLine($"Unable to calculate distance");
    }

    static void Main()
    {
        Console.WriteLine("Enter Point 1 coordinates (x,y,z): ");
        string[] point1Coordinates = Console.ReadLine()?.Split(',');
        double x1, y1, z1;
        if (!double.TryParse(point1Coordinates[0], out x1) || !double.TryParse(point1Coordinates[1], out y1) || !double.TryParse(point1Coordinates[2], out z1))
        {
            Console.WriteLine("Invalid input for Point 1 coordinates");
            return;
        }

        Console.WriteLine("Enter Point 2 coordinates (x,y,z): ");
        string[] point2Coordinates = Console.ReadLine()?.Split(',');
        double x2, y2, z2;
        if (!double.TryParse(point2Coordinates[0], out x2) || !double.TryParse(point2Coordinates[1], out y2) || !double.TryParse(point2Coordinates[2], out z2))
        {
            Console.WriteLine("Invalid input for Point 2 coordinates");
            return;
        }

        PrintDistance(x1, y1, z1, x2, y2, z2);
    }
}
