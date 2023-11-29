using System;
class Program
{
    public static void Main(string [] arg)
    {   
        int num = CreateNumber(1,100000);
        int [] newArray = ArrayFromDigit(num);
        Console.Write($"Из числа {num} получается массив цифр: ");
        PrintArray(newArray);
    }

    public static int CreateNumber(int min, int max)
    {
        int num = new Random().Next(min, max + 1);
        return num;
    }

    public static int [] ArrayFromDigit(int num)
    {
        int size = (int)Math.Log10(num) + 1;
        int[] newArray = new int[size];
        for (int i = size - 1; i >= 0; i--)
        {
            newArray[i] = num % 10;
            num /= 10;
        }
        return newArray;
    }
    static void PrintArray(int [] newArray)
    {
        foreach (int num in newArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}