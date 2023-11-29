using System;
class Program
{
    public static void Main(string [] arg)
    {   
        double [] array = CreateArray(10,-100,100);
        Console.WriteLine(Print(array));
        double difference = FindDiff(array);
        Console.WriteLine($"Разница меду максимальным и минимальным значением массива = {difference}");
    }

    public static double [] CreateArray(int size, double min, double max)
    {
        double [] array = new double [size];
        Random random = new();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next((int)min, (int)max + 1) + random.NextDouble(); //не понимаю как сделать конкретное количество цифр после точки
        }
        return array;
    }

    public static string Print(double [] array)
    {
        string result = string.Join(", ", array);
        return result;
    }

    public static double FindDiff(double [] array)
    {
        double max = array[0];
        double min = array[0];
        foreach (double num in array)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
        double difference = max - min;
        return difference;
    }
}