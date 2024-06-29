//Телефонные номера в адресной книге мобильного телефона имеют один из следующих форматов: +7<код><номер>,
//8<код><номер>, <номер>, где <номер> — это семь цифр, а <код> — это три цифры или три цифры в круглых скобках.
//Если код не указан, то считается, что он равен 495. Кроме того, в записи телефонного номера может стоять знак
//“-” между любыми двумя цифрами (см. пример). На данный момент в адресной книге телефона Васи записано всего три
//телефонных номера, и он хочет записать туда еще один. Но он не может понять, не записан ли уже такой номер в
//телефонной книге. Помогите ему! Два телефонных номера совпадают, если у них равны коды и равны номера.
//Например, +7(916)0123456 и 89160123456 — это один и тот же номер.

namespace YandexAlgorithms.lesson1;

public static class ExerciseC
{
    public static void Main()
    {
        int n = 4;
        string[] notes = new string[n];

        for (int i = 0; i < n; i++)
        {
            notes[i] = Console.ReadLine();
        }

        string normalizedNumber = notes[0].NormalizeNumber();

        for (int i = 1; i < n; i++)
        {
            if (normalizedNumber.Equals(notes[i].NormalizeNumber()))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }

    private static string NormalizeNumber(this string number)
    {
        number = number.Replace("-", "").Replace("(", "").Replace(")", "");
        if (number.Length > 7)
        {
            return number.Substring(number.Length - 10);
        }
        else
        {
            return "495" + number.Substring(number.Length - 7);
        }
    }
}