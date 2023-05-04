// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Numbers = ");
string[] numbers = Console.ReadLine().Split(',');
int a = Convert.ToInt32(numbers[0]);
int b = Convert.ToInt32(numbers[1]);
int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
Console.Write("max -> ");
Console.WriteLine(max);





// Задача 4: Напишите программу, которая принимает на 
// вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Numbers = ");
string[] numbers = Console.ReadLine().Split(',');
int a = Convert.ToInt32(numbers[0]);
int b = Convert.ToInt32(numbers[1]);
int c = Convert.ToInt32(numbers[2]);
int max = 0;

if (a > max)
{
    max = a;
}
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.Write("max -> ");
Console.Write(max);





// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


string[] number = Console.ReadLine().Split(',');
int a = Convert.ToInt32(number[0]);
int d = a % 2;

if (d == 0)
{

    Console.Write(a);
    Console.Write(" -> Да");

}
else
{
    Console.Write(a);
    Console.Write(" -> Нет");
}





// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


string numbers = Console.ReadLine();
int num = Convert.ToInt32(numbers);

for (int i = 1; i < num; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}



