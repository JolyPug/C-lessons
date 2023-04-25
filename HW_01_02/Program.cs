using System;

Console.Write("Numbers = ");
string[] numbers = Console.ReadLine().Split(',');
int a = Convert.ToInt32(numbers[0]);
int b = Convert.ToInt32(numbers[1]);
int max = 0;

if(a>b)
{
    max = a;
}
else
{ 
    max  = b;
}
Console.Write("max -> ");
Console.WriteLine(max);