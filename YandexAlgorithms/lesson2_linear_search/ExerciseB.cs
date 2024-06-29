//По последовательности чисел во входных данных определите ее вид:
// CONSTANT – последовательность состоит из одинаковых значений
// ASCENDING – последовательность является строго возрастающей
// WEAKLY ASCENDING – последовательность является нестрого возрастающей
// DESCENDING – последовательность является строго убывающей
// WEAKLY DESCENDING – последовательность является нестрого убывающей
// RANDOM – последовательность не принадлежит ни к одному из вышеупомянутых типов


namespace YandexAlgorithms.lesson2_linear_search;

using System;
public class ExerciseB
{
    public static void Main()
    {
        bool isConstant = true;
        bool isAscending = true;
        bool isWeaklyAscending = true;
        bool isDescending = true;
        bool isWeaklyDescending = true;

        int prev = int.Parse(Console.ReadLine()); 

        while (true)
        {
            int current = int.Parse(Console.ReadLine());
            if (current == -2000000000)
            {
                break;
            }
            if (prev != current)
            {
                isConstant = false;
            }
            if (current < prev)
            {
                isAscending = false;
                isWeaklyAscending = false;
            }
            if (current <= prev)
            {
                isAscending = false;
            }
            if (current > prev)
            {
                isDescending = false;
                isWeaklyDescending = false;
            }
            if (current >= prev)
            {
                isDescending = false;
            }
            prev = current;
        }

        if (isConstant)
        {
            Console.WriteLine("CONSTANT");
        }
        else if (isAscending)
        {
            Console.WriteLine("ASCENDING");
        }
        else if (isWeaklyAscending)
        {
            Console.WriteLine("WEAKLY ASCENDING");
        }
        else if (isDescending)
        {
            Console.WriteLine("DESCENDING");
        }
        else if (isWeaklyDescending)
        {
            Console.WriteLine("WEAKLY DESCENDING");
        }
        else
        {
            Console.WriteLine("RANDOM");
        }
    }
}