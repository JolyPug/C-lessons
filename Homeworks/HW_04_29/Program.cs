// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int[] FillArray(int length)
{   
    int[] arr = new int[length]; // corrected syntax for creating an array with 'length' elements
    Random rand = new Random(); // moved outside of the loop to avoid repeating the creation of a new Random object
    for(int i = 0; i < length; i++)
    {
        arr[i] = rand.Next(1,10);
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
