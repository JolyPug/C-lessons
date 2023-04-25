
string[] number = Console.ReadLine().Split(',');
int a = Convert.ToInt32(number[0]);
int d = a % 2;
bool truly;

if(d == 0)
{
    truly = true;
    Console.Write(a);
    Console.Write(" -> Да");
    
}
else
{
    Console.Write(a);
    Console.Write(" -> Нет");
}