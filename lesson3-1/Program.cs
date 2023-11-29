using System;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main(string [] arg)
    {   
        int [] array = CreateArray(10,1,100);
        Console.WriteLine(Print(array));
        int countNum = FindElement(array,20,90);
        Console.WriteLine($"Количество элементов массива, значения которых лежат искомом отрезке = {countNum}");
    }

    public static int [] CreateArray(int size, int min, int max)
    {
        int [] array = new int [size];
        Random random = new();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(min, max + 1);
        }
        return array;
    }

    public static string Print(int [] array)
    {
        string result = string.Join(", ", array);
        return result;
    }

    public static int FindElement(int [] array, int minRange, int maxRange)
    {
        int count = 0;
        foreach(int item in array)
        {
            if (item <= maxRange && item >= minRange)
            {
                count++;
            }
        }
        return(count);
    }
}
