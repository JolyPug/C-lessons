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
    for(int j = 1; j < numbers.Length; j++)
    {
        length *= 10;
    }

    for(int i = 0; i < numbers.Length; i++)
    {
        int newNum = digit / length;
        digit = digit - newNum * length;
        length /= 10;
        result += newNum;
        
    }   
    Console.WriteLine($"{digitalNumber} -> {result}");
}

summaryOfNumbers(digit, digitalNumber);
