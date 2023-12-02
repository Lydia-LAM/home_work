using System;
class Program
{
    public static void Main(string [] arg)
    {   
        int [,] array = CreateArray(2,5,0,10);
        Print(array);
        Console.WriteLine();
        int minRowIndex = FindRowWithMinSum(array);
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex + 1}");
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

    public static int FindRowWithMinSum(int [,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        int minSum = int.MaxValue; //взято из интернета, понять не смогла, но зато работает
        int minRowIndex = 0; // наверное надо -1? для случаев с ошибкой
        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < columns; j++)
            {
                rowSum += array[i, j];
            }
            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRowIndex = i;
            }
        }
        return minRowIndex;
    }
}