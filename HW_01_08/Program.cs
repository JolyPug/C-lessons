﻿
using System;

string numbers = Console.ReadLine();
int num = Convert.ToInt32(numbers);

for(int i = 1; i < num; i++)
{
    if(i % 2 == 0)
    {
    Console.WriteLine(i);
    }
}


