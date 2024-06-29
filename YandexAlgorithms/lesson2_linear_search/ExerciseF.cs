//Последовательность чисел назовем симметричной, если она одинаково читается как слева направо, так и справа налево. Например, следующие последовательности являются симметричными:
// 1 2 3 4 5 4 3 2 1
// 1 2 1 2 2 1 2 1
// Вашей программе будет дана последовательность чисел. Требуется определить, какое минимальное количество и каких чисел надо приписать в конец этой последовательности, чтобы она стала симметричной.
// Формат ввода
// 
// Сначала вводится число N — количество элементов исходной последовательности (1 ≤ N ≤ 100). Далее идут N чисел — элементы этой последовательности, натуральные числа от 1 до 9.
// Формат вывода
// 
// Выведите сначала число M — минимальное количество элементов, которое надо дописать к последовательности, а потом M чисел (каждое — от 1 до 9) — числа, которые надо дописать к последовательности.

namespace YandexAlgorithms.lesson2_linear_search;

using System;
using System.Collections.Generic;
public class ExerciseF
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var seq = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

        var ans = Slow(seq);
        Console.WriteLine(ans.Count);
        for (var i = 0; i < ans.Count; i++)
        {
            Console.Write(ans[i] + " ");
        }
    }

    private static List<int> Slow(int[] seq)
    {
        for (var start = 0; start < seq.Length; start++)
        {
            var i = start;
            var j = seq.Length - 1;
            while (i < seq.Length && j >= 0 && seq[i] == seq[j] && i <= j)
            {
                i++;
                j--;
            }

            if (i > j)
            {
                var ans = new List<int>();
                for (var k = start - 1; k >= 0; k--)
                {
                    ans.Add(seq[k]);
                }

                return ans;
            }
        }

        return new List<int>();
    }
}