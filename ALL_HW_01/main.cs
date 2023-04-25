// задание №2
void zad2()
{
    Console.Write("Numbers = ");
    string[] numbers = Console.ReadLine().Split(',');
    int a = Convert.ToInt32(numbers[0]);
    int b = Convert.ToInt32(numbers[1]);
    int max = 0;

    if(a>b)
    {
        max = a;
    }
    else
    { 
        max  = b;
    }
    Console.Write("max -> ");
    Console.WriteLine(max);    
}

// задание №4
void zad4()
{
    Console.Write("Numbers = ");
    string[] numbers = Console.ReadLine().Split(',');
    int a = Convert.ToInt32(numbers[0]);
    int b = Convert.ToInt32(numbers[1]);
    int c = Convert.ToInt32(numbers[2]);
    int max = 0;

    if(a>max)
    {
        max = a;
    }
    if(b>max)
    {
        max = b;
    }
    if(c>max)
    {
        max = c;
    }
    Console.Write("max -> ");
    Console.Write(max);
}
// задание №6

void zad6()
{
    
    string[] number = Console.ReadLine().Split(',');
    int a = Convert.ToInt32(number[0]);
    int d = a % 2;

    if(d == 0)
    {
        Console.Write(a);
        Console.Write(" -> Да");
        
    }
    else
    {
        Console.Write(a);
        Console.Write(" -> Нет");
    }
}
// задание №8
void zad8()
{

    string numbers = Console.ReadLine();
    int num = Convert.ToInt32(numbers);

    for(int i = 1; i < num; i++)
    {
        if(i % 2 == 0)
        {
        Console.WriteLine(i);
        }
    }

}