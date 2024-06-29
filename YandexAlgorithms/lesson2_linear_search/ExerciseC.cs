//Напишите программу, которая находит в массиве элемент, самый близкий по величине к  данному числу.
// Формат ввода
// 
// В первой строке задается одно натуральное число N, не превосходящее 1000 – размер массива. Во второй строке содержатся N чисел – элементы массива (целые числа, не превосходящие по модулю 1000). В третьей строке вводится одно целое число x, не превосходящее по модулю 1000.
// Формат вывода
// 
// Вывести значение элемента массива, ближайшее к x. Если таких чисел несколько, выведите любое из них.

using Microsoft.VisualBasic;

namespace YandexAlgorithms.lesson2_linear_search;

using System;
using System.Collections.Generic;
using System.Linq;
public class ExerciseC
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>(Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse));;
        var x = int.Parse(Console.ReadLine());
        List<int> list2 = new List<int>();
        foreach (int num in list)
        {
            list2.Add(Math.Abs(num - x));
        }

        Console.WriteLine(list[list2.IndexOf(list2.Min())]);
    }
}