using System;
class Program
{
    public static void Main(string [] arg)
    {   
        int [,] array = CreateArray(5,5,0,100);
        Print(array);
        Console.WriteLine("Введите номер строки: ");
        int row = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.WriteLine("Введите номер столбца: ");
        int column = Convert.ToInt32(Console.ReadLine()) - 1;
        PlaceExist(array, row, column);
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

    public static void PlaceExist(int [,] array, int row, int column)
    {
        if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
        {
            Console.WriteLine($"Элемент на позиции ({row + 1}, {column + 1}): {array[row, column]}");
        }
        else
        {
            Console.WriteLine("Такого элемента не существует.");
        }
    }
}
