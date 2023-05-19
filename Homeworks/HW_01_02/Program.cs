int a, b, max;
Console.Write("Numbers = ");
string[] numbers = Console.ReadLine().Split(',');
if (numbers == null || numbers.Length != 2 || !int.TryParse(numbers[0], out a) || !int.TryParse(numbers[1], out b))
{
    Console.WriteLine("Invalid input");
}
else
{
    max = a > b ? a : b;
    Console.WriteLine($"max -> {max}");
}
