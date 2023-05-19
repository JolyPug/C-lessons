// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16




void numberPow(int numberA, int numberB)
{
    int numberC = 1;
    for(int i = 0; i < numberB; i++)
        numberC = numberC * numberA;
    Console.Write($"{numberA}, {numberB} -> {numberC}");
}

Console.Write("Числа:  ");
string[] numbers = Console.ReadLine().Split(',');
int numberA = Convert.ToInt32(numbers[0]);
int numberB = Convert.ToInt32(numbers[1]);
numberPow(numberA, numberB);
