//Дан список, заполненный произвольными целыми числами. Найдите в этом списке два числа, произведение которых максимально. Выведите эти числа в порядке неубывания.
// Список содержит не менее двух элементов. Числа подобраны так, что ответ однозначен.
// Решение должно иметь сложность O(n), где n - размер списка.

namespace YandexAlgorithms.lesson2_linear_search;

using System;
using System.Collections.Generic;
using System.Linq;
public class ExerciseG
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(" ").Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
        var arr = new List<int>(Array.ConvertAll(input, int.Parse));

        List<int> ans = Func(arr);
        Console.WriteLine($"{ans[0]} {ans[1]}");
    }

    private static List<int> Func(List<int> arr)
    {
        arr.Sort();
        int n = arr.Count;
        long first = (long)arr[0] * arr[1];
        long last = (long)arr[n - 1] * arr[n - 2];
        return (first > last) ? new List<int> { arr[0], arr[1] } : new List<int> { arr[n - 2], arr[n - 1] };
    }
}