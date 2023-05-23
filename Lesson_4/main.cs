// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16




void numberPow(int numberA, int numberB)
{
    int numberC = 1;
    for (int i = 0; i < numberB; i++)
        numberC = numberC * numberA;
    Console.Write($"{numberA}, {numberB} -> {numberC}");
}

Console.Write("Числа:  ");
string[] numbers = Console.ReadLine().Split(',');
int numberA = Convert.ToInt32(numbers[0]);
int numberB = Convert.ToInt32(numbers[1]);
numberPow(numberA, numberB);




// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// // 9012 -> 12
Console.WriteLine("Введите число: ");
string numbers = Console.ReadLine();
int digit = Convert.ToInt32(numbers);
int digitalNumber = digit;

void summaryOfNumbers(int digit, int digitalNumber)
{
    int length = 1;
    int result = 0;
    for (int j = 1; j < numbers.Length; j++)
    {
        length *= 10;
    }

    for (int i = 0; i < numbers.Length; i++)
    {
        int newNum = digit / length;
        digit = digit - newNum * length;
        length /= 10;
        result += newNum;

    }
    Console.WriteLine($"{digitalNumber} -> {result}");
}

summaryOfNumbers(digit, digitalNumber);





// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int[] FillArray(int length)
{
    int[] arr = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rand.Next(1, 10);
    }
    return arr;
}

void Print(int[] arr)
{
    Console.Write(string.Join(", ", arr));
    Console.WriteLine();
}

int length = 8;
int[] arr = FillArray(length);
Print(arr);

