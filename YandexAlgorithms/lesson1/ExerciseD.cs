//Решите в целых числах уравнение:
// sqrt(ax+b)=c,
// a, b, c – данные целые числа: найдите все решения или сообщите, что решений в целых числах нет.
// 

namespace YandexAlgorithms.lesson1;

using System;
public class ExerciseD
{
    public static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        if (c < 0)
        {
            Console.WriteLine("NO SOLUTION");
        }
        else if (a == 0 && c * c == b)
        {
            Console.WriteLine("MANY SOLUTIONS");
        }
        else
        {
            if (a != 0 && (c * c - b) % a == 0)
            {
                Console.WriteLine((c * c - b) / a);
            }
            else
            {
                Console.WriteLine("NO SOLUTION");
            }
        }
    }
}