// Задача 34: Задайте массив заполненный случайными положительными т
// рёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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

const int sizeOf = 4;
int[] numbers = new int[sizeOf];
int[] posnum = new int[sizeOf];
FillArray(numbers);
CheckArray(numbers, posnum);





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




// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


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
int Magnitude(int[] numbers)
{
    int max = numbers[0], min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
            max = numbers[i];
        else if (numbers[i] < min)
            min = numbers[i];
    }
    int diff = max - min;
    return diff;
}

const int sizeOf = 4;
int[] numbers = new int[sizeOf];
FillArray(numbers);
int difference = Magnitude(numbers);

Console.Write($" -> {difference}");
