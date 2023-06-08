// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




int[,,] GenerateArray()
{
    int[,,] array = new int[2, 2, 2];
    int[] usedNumbers = new int[100];
    Random random = new Random();

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                int number;
                do
                {
                    number = random.Next(10, 100);
                } while (usedNumbers[number] == 1);

                array[i, j, k] = number;
                usedNumbers[number] = 1;
            }
        }
    }

    return array;
}

void PrintArray(int[,,] array)
{
    int dim1 = array.GetLength(0);
    int dim2 = array.GetLength(1);
    int dim3 = array.GetLength(2);

    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
    }
}


int[,,] array = GenerateArray();

Console.WriteLine("Трехмерный массив:");
PrintArray(array);