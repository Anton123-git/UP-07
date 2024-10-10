using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        List<(int number, int quotient)> results = new List<(int, int)>();
        int start = 1000000; // Начинаем с 10^6
        int limit = 10000000; // Устанавливаем верхний предел для поиска

        for (int i = start; i < limit; i++)
        {
            if (i % 13 == 0)
            {
                string numberStr = i.ToString();
                // Преобразуем маску в регулярное выражение
                string pattern = "^123\\d*4\\d{1}9$"; // \\d* для * и \\d{1} для ?
                if (Regex.IsMatch(numberStr, pattern))
                {
                    results.Add((i, i / 13));
                    if (results.Count >= 5) break; // Найдено 5 чисел
                }
            }
        }

        // Вывод результатов
        Console.WriteLine("Число\tЧастное от деления на 13");
        foreach (var result in results)
        {
            Console.WriteLine($"{result.number}\t{result.quotient}");
        }
    }
}
