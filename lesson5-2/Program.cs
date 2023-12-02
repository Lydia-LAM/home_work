using System;
class Program
{
    public static void Main(string [] arg)
    {   
        int [,] array = CreateArray(5,5,0,100);
        Print(array);
        Console.WriteLine();
        ReplaceRow(array);
        Print(array);
    }

    public static int [,] CreateArray(int rows, int cols, int min, int max)
    {
        int [,] array = new int [rows, cols];
        Random random = new();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i,j] = random.Next(min, max + 1);
            }
        }
        return array;
    }

    public static void Print(int [,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void ReplaceRow(int [,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        int temp;
            for (int j = 0; j < columns; j++)
            {
                temp = array[0, j];
                array[0, j] = array[rows - 1, j];
                array[rows - 1, j] = temp;
            }
    }
}
