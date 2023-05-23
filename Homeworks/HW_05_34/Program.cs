// Задача 34: Задайте массив заполненный случайными положительными т
// рёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

const int sizeOf = 4;
int[] numbers = new int[sizeOf];
int[] posnum = new int[sizeOf];

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

int CheckArray(int[] numbers, int[] posnum)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            posnum[i] = numbers[i];
            count++;
        }
        else continue;
    }
    Console.WriteLine($"] -> {count}");
    return count;

}

FillArray(numbers);
CheckArray(numbers, posnum);

