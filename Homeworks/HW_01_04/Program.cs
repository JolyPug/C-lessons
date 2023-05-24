Console.Write("Numbers = ");
string[]? numbers = Console.ReadLine()?.Split(',');
int a, b, c = 0, max = 0;

if (numbers == null || numbers.Length != 3 || 
    !int.TryParse(numbers[0], out a) || 
    !int.TryParse(numbers[1], out b) || 
    !int.TryParse(numbers[2], out c))
{
    Console.WriteLine("Invalid input. Please enter 3 integers separated by commas.");
}
else
{
    max = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
    Console.WriteLine($"max -> {max}");
}
