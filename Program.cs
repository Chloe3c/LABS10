using System;
using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Random random = new Random();

//        List<int> numbers = new List<int>();
//        for (int i = 0; i < 10000; i++)
//        {
//            numbers.Add(random.Next(1, 10001));
//        }

//        HashSet<int> uniqueNumbers = new HashSet<int>();

//        foreach (int number in numbers)
//        {
//            uniqueNumbers.Add(number);
//        }

//        Console.WriteLine("Количество различных чисел: " + uniqueNumbers.Count);
//    }
//}

class Program
{
    static void Main()
    {
        List<string> keys = new List<string> { "апесин", "яблоко", "дыня" };
        List<int> values = new List<int> { 1, 2, 3 };

        if (keys.Count != values.Count)
        {
            Console.WriteLine("Списки должны быть одинаковой длины.");
            return;
        }

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        for (int i = 0; i < keys.Count; i++)
        {
            dictionary[keys[i]] = values[i];
        }

        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"Ключ: {kvp.Key}, Значение: {kvp.Value}");
        }
    }
}