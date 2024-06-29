//В данном списке из n ≤ 10^5 целых чисел найдите три числа,произведение которых максимально.
// Решение должно иметь сложность O(n), где n - размер списка.
// Выведите три искомых числа в любом порядке.


namespace YandexAlgorithms.lesson2_linear_search;

using System;
using System.Collections.Generic;
using System.Linq;
public class ExerciseH
{
    public static void Main()
    {
        var arr = Console.ReadLine()
            .Split(' ')
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .Select(int.Parse)
            .ToList();

        var ans = Func(arr);
        Console.WriteLine($"{ans[0]} {ans[1]} {ans[2]}");
    }

    private static List<int> Func(List<int> arr)
    {
        arr.Sort();
        int n = arr.Count;
        long first = (long)arr[0] * arr[1] * arr[2];
        long mid = (long)arr[0] * arr[1] * arr[n - 1];
        long last = (long)arr[n - 1] * arr[n - 2] * arr[n - 3];

        long max1 = Math.Max(first, mid);
        long max2 = Math.Max(max1, last);

        if (max2 == first)
        {
            return arr.Take(3).ToList();
        }
        else if (max2 == mid)
        {
            return new List<int> { arr[0], arr[1], arr[n - 1] };
        }
        else
        {
            return arr.Skip(n - 3).Take(3).ToList();
        }
    }
}