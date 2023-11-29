using System;
class Program
{
    public static void Main(string [] arg)
    {   
        while (true)
        {
            Console.WriteLine("Чтобы продолжить введите число. Для выхода нажмите q.");
            string input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена"); 
                break;
            }
            int number = Int32.Parse(input);
            if (EvelSum(number))
            {
                Console.WriteLine($"Сумма цифр числа {number} нечетная. Программа завершена"); 
                break;
            }
            else
            {
                 Console.WriteLine($"Сумма цифр числа {number} четная.");
            }
        }
    }
    public static bool EvelSum (int number)
    {
        int sum = 0;
        number = Math.Abs(number);
        while (number > 0)
        {
            sum += number % 10; // Получаем последнюю цифру числа и добавляем её к сумме
            number /= 10; // Убираем последнюю цифру числа
        }
        return sum % 2 != 0;
    }
}