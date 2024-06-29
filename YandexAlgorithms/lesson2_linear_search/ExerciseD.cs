//Дан список чисел. Определите, сколько в этом списке элементов, которые больше двух своих соседей и выведите количество таких элементов.
// Формат ввода
// 
// Вводится список чисел. Все числа списка находятся на одной строке.

namespace YandexAlgorithms.lesson2_linear_search;

using System;
using System.Collections.Generic;
public class ExerciseD
{
    public static void Main()
    {
        List<int> list = new List<int>();
        int cnt = 0;

        string[] input = Console.ReadLine().Split();
        foreach (string s in input)
        {
            list.Add(int.Parse(s));
        }

        if (list.Count > 2)
        {
            for (int i = 1; i < list.Count - 1; i++)
            {
                if (list[i] > list[i - 1] && list[i] > list[i + 1])
                {
                    cnt++;
                }
            }
        }

        Console.WriteLine(cnt);
    }
}