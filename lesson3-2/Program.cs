class Program
{
    public static void Main(string [] arg)
    {   
        int [] array = CreateArray(10,-100,100);
        Console.WriteLine(Print(array));
        int countNum = FindEvenElement(array);
        Console.WriteLine($"Количество четных чисел в массиве = {countNum}");
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

    public static int FindEvenElement(int [] array)
    {
        int count = 0;
        foreach(int item in array)
        {
            if (item % 2 == 0)
            {
                count++;
            }
        }
        return(count);
    }
}
