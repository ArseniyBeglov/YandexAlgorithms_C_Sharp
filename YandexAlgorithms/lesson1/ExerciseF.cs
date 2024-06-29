//В школе решили на один прямоугольный стол поставить
//два прямоугольных ноутбука. Ноутбуки нужно поставить так,
//чтобы их стороны были параллельны сторонам стола. Определите, какие размеры должен иметь стол, чтобы оба ноутбука
//на него поместились, и площадь стола была минимальна.

namespace YandexAlgorithms.lesson1;

using System;
public class ExerciseF
{
    public static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        var a = int.Parse(inputs[0]);
        var b = int.Parse(inputs[1]);
        var c = int.Parse(inputs[2]);
        var d = int.Parse(inputs[3]);

        int[] l = new int[4];
        l[0] = Math.Max(a, c) * (b + d);
        l[1] = Math.Max(a, d) * (b + c);
        l[2] = Math.Max(b, c) * (a + d);
        l[3] = Math.Max(b, d) * (a + c);

        int minValue = int.MaxValue;
        int minIndex = 0;
        for (int i = 0; i < l.Length; i++)
        {
            if (l[i] < minValue)
            {
                minValue = l[i];
                minIndex = i;
            }
        }

        switch (minIndex)
        {
            case 0:
                Console.WriteLine(Math.Max(a, c) + " " + (b + d));
                break;
            case 1:
                Console.WriteLine(Math.Max(a, d) + " " + (b + c));
                break;
            case 2:
                Console.WriteLine(Math.Max(b, c) + " " + (a + d));
                break;
            case 3:
                Console.WriteLine(Math.Max(b, d) + " " + (a + c));
                break;
        }
    }
}