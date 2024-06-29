//Дан список. Определите, является ли он монотонно возрастающим(то есть верно ли, что каждый элемент этого списка больше предыдущего).
// Выведите YES, если массив монотонно возрастает и NO в противном случае.

namespace YandexAlgorithms.lesson2_linear_search;

using System;
using System.Collections.Generic;
public class ExerciseA
{
    public static void Main()
    {
        var list = new List<int>(Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse));
        

        var isIncreasing = true;
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] <= list[i - 1])
            {
                isIncreasing = false;
                break;
            }
        }

        if (isIncreasing)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}