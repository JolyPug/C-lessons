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
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > max)
            max = numbers[i];
        else if(numbers[i] < min)
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