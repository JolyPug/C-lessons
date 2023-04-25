
using System;

string numbers = Console.ReadLine();
int num = Convert.ToInt32(numbers);
int[] nums = new int[num];

for(int i = 0; i < num;i++) // заполнение массива
{
    nums[i] = i;
}
for(int i = 1; i < num; i++)
{
    if(i % 2 == 0)
    {
    Console.WriteLine(nums[i]);
    }
}


