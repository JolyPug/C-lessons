// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] FillArray(int[] numbers)
{
    Console.Write("[");
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(100, 999);
        if (i == numbers.Length - 1)
            Console.Write($"{numbers[i]}");
        else
            Console.Write($"{numbers[i]}, ");

    }
    return numbers;
}
int CheckArray(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 != 0)
            sum += numbers[i];
        else continue;
    }
    Console.WriteLine($"] -> {sum}");
    return sum;

}
const int sizeOf = 4;
int[] numbers = new int[sizeOf];
FillArray(numbers);
CheckArray(numbers);
