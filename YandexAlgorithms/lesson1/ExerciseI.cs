//За многие годы заточения узник замка Иф проделал в стене прямоугольное отверстие размером D × E. Замок Иф сложен
//из кирпичей, размером A × B × C. Определите, сможет ли узник выбрасывать кирпичи в море через это отверстие,
//если стороны кирпича должны быть параллельны сторонам отверстия.

namespace YandexAlgorithms.lesson1;

using System;
public class ExerciseI
{
    public static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());
        var d = int.Parse(Console.ReadLine());
        var e = int.Parse(Console.ReadLine());
        var arr1 = new int[] { a, b, c };
        var arr2 = new int[] { d, e };
        arr1 = BubbleSort(arr1);
        arr2 = BubbleSort(arr2);
        if (arr1[0] <= arr2[0] && arr1[1] <= arr2[1])
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    public static int[] BubbleSort(int[] arr)
    {
        var n = arr.Length;
        for (var i = 0; i < n - 1; i++)
        {
            for (var j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Обмен местами элементов
                    var temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        return arr;
    }
}