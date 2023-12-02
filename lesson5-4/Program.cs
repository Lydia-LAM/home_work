using System;
class Program
{
    public static void Main(string [] arg)
    {   
        int [,] array = CreateArray(5,10,0,100);
        Print(array);
        Console.WriteLine();
        int minElement; int minRow, minColumn;
        FindMinElementIndex(array, out minElement, out minRow, out minColumn);
        Console.WriteLine($"Наименьший элемент массива = {minElement}");
        int[,] newArray = CreateNewArray(array, minRow, minColumn);
        Print(newArray);
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

    public static void FindMinElementIndex(int [,] array, out int minElement, out int minRow, out int minColumn)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        minElement = array[0,0];
        minRow = 0;
        minColumn = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if(array[i,j] < minElement)
                {
                    minElement = array[i,j];
                    minRow = i;
                    minColumn = j;
                }
            }
        }
    }

    public static int [,] CreateNewArray(int [,] array, int rowToRemove, int columnToRemove)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int[,] newArray = new int[rows - 1, cols - 1];
        int newRow = 0;
        for (int i = 0; i < rows; i++)
        {
            if (i == rowToRemove) continue;
            int newCol = 0;
            for (int j = 0; j < cols; j++)
            {
                if (j == columnToRemove) continue;
                newArray[newRow, newCol] = array[i, j];
                newCol++;
            }
            newRow++;
        }
        return newArray;
    }
}