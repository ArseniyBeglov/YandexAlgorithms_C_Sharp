//На некоторых кросс-платформенных станциях метро (как, например, «Третьяковская») на разные стороны платформы приходят поезда разных направлений. Таня договорилась встретиться с подругой на такой станции, но поскольку подруга приехала из другого часового пояса, то из-за джетлага сильно проспала, и Тане пришлось долго её ждать. Поезда всегда ходят точно по расписанию, и Таня знает, что поезд стоит на платформе ровно одну минуту, а интервал между поездами (время, в течение которого поезда у платформы нет) составляет a минут для поездов на первом пути и b минут для поездов на втором пути. То есть на первый путь приезжает поезд и стоит одну минуту, затем в течение a минут поезда у платформы нет, затем в течение одной минуты у платформы стоит следующий поезд и т. д.
// Пока Таня стояла на платформе, она насчитала n поездов на первом пути и m поездов на втором пути. Определите минимальное и максимальное время, которое Таня могла провести на платформе, или сообщите, что она точно сбилась со счёта.
// Все поезда, которые видела Таня, она наблюдала в течение всей минуты, то есть Таня не приходит и не уходит с платформы посередине той минуты, когда поезд стоит на платформе.

namespace YandexAlgorithms.lesson1;

using System;
public class ExerciseH
{
    public static void Main()
    {
        var input = new string[4];
        for (int j = 0; j < 4; j++)
        {
            input[j] = Console.ReadLine();
        }
        // Определяем переменные с использованием var
        var a = int.Parse(input[0]);
        var b = int.Parse(input[1]);
        var n = int.Parse(input[2]);
        var m = int.Parse(input[3]);

        // Вычисляем минимальные и максимальные значения
        var min1 = (n - 1) * (a + 1) + 1;
        var min2 = (m - 1) * (b + 1) + 1;
        var max1 = min1 + 2 * a;
        var max2 = min2 + 2 * b;

        // Проверяем условие и выводим результаты
        if (Math.Max(min1, min2) > Math.Min(max1, max2))
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(Math.Max(min1, min2));
            Console.WriteLine(Math.Min(max1, max2));
        }
    }
}