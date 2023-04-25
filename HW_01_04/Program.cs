using System;

Console.Write("Numbers = ");
string[] numbers = Console.ReadLine().Split(',');
int a = Convert.ToInt32(numbers[0]);
int b = Convert.ToInt32(numbers[1]);
int c = Convert.ToInt32(numbers[2]);
int max = 0;

if(a>max)
{
    max = a;
}
if(b>max)
{
    max = b;
}
if(c>max)
{
    max = c;
}
Console.Write("max -> ");
Console.Write(max);