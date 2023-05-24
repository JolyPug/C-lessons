int a, b, max;

Console.Write("Enter two numbers separated by a comma: ");
string[]? numbers = Console.ReadLine()?.Split(',');
if (numbers == null || numbers.Length != 2 || !int.TryParse(numbers[0], out a) || !int.TryParse(numbers[1], out b))
{
    Console.WriteLine("Invalid input");
}
else
{
    max = Math.Max(a, b);

    Console.WriteLine($"The maximum of {a} and {b} is {max}");
}
