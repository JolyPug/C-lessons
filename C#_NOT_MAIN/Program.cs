using System;

class EightQueens
{
    private const int NumOfQueens = 8;

    static void Main(string[] args)
    {
        int[] positions = new int[NumOfQueens];
        PlaceQueens(positions, 0);
    }

    static void PlaceQueens(int[] positions, int row)
    {
        if (row == NumOfQueens)
        {
            PrintBoard(positions);
            return;
        }

        for (int col = 0; col < NumOfQueens; col++)
        {
            positions[row] = col;
            if (IsValidPosition(positions, row))
            {
                PlaceQueens(positions, row + 1);
            }
        }
    }

    static bool IsValidPosition(int[] positions, int row)
    {
        for (int i = 0; i < row; i++)
        {
            if (positions[i] == positions[row]
                || positions[i] - positions[row] == row - i
                || positions[row] - positions[i] == row - i)
            {
                return false;
            }
        }
        return true;
    }

    static void PrintBoard(int[] positions)
    {
        Console.Write("  ");
        for (int i = 0; i < NumOfQueens; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < NumOfQueens; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < NumOfQueens; j++)
            {
                if (positions[i] == j)
                {
                    Console.Write("Q ");
                }
                else
                {
                    Console.Write("- ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
