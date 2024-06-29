// Даны три натуральных числа. Возможно ли построить треугольник с такими сторонами.
// Если это возможно, выведите строку YES, иначе выведите строку NO.
// Треугольник — это три точки, не лежащие на одной прямой.

namespace YandexAlgorithms.lesson1;
using System;
public class ExerciseB
{
    static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("NO");
        }
        else if ((a + b > c) && (b + c > a) && (a + c > b))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}