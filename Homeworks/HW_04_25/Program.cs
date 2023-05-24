// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16




void Main()
{
    Console.Write("Enter two numbers: ");
    int[] numbers = Console.ReadLine().Split(',')
                                    .Select(n => Convert.ToInt32(n.Trim()))
                                    .ToArray();
    Console.WriteLine($"{numbers[0]}^{numbers[1]} = {numberPow(numbers[0], numbers[1])}");
}

int numberPow(int numberA, int numberB)
{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result *= numberA;
    }
    return result;
}
Main();
