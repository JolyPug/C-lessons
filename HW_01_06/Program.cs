string[] number = Console.ReadLine().Split(',');
if (number.Length >= 1 && int.TryParse(number[0], out int a))
{
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
}
else
{
    Console.WriteLine("Invalid input");
}
