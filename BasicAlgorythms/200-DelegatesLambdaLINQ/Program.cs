//Подсчитать сумму цифр встречающихся в строке.

//Делегаты


// int CountDigits(string s)
// {
//     int count = 0;
//     foreach (char c in s)
//     {
//         if (char.IsDigit(c))
//         {
//             count++;
//         }
//         return count;
//     }
// }

// int CountLatin(string s)
// {
//     int count = 0;
//     foreach (char c in s)
//     {
//         if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
//         {
//             count++;
//         }
//         return count;
//     }
// }

// int CountRus(string s)
// {
//     int count = 0;
//     foreach (char c in s)
//     {
//         if (c >= 'А' && c <= 'Я' || c >= 'а' && с <= 'я' || с == 'Ё' || с == 'ё')
//         {
//             count++;
//         }
//         return count;
//     }
// }

using System.Linq;

class Program
{
    static int CountChars(string s, Func<char, bool> isChar)
    {
        int count = 0;
        foreach (char c in s)
        {
            if (isChar(c))
            {
                count++;
            }
        }
        return count;
    }

    static bool IsLatin(char c)
    {
        return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');
    }
    static bool IsRus(char c)
    {
        return (c >= 'А' && c <= 'Я' || c >= 'а' && c <= 'я' || c == 'Ё' || c == 'ё');
    }
    static bool IsDigit(char c)
    {
        return (char.IsDigit(c));
    }

    static void Main()
    {

        // Action click;
        // click = new Action(выделение);
        // click = new Action(заливка);
        // click;
        string s = "Это строка содержит latinskie буквы и цифры(123)";


        //Linq!
        var query = (from c in s where (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z') select c).ToArray().Count();
        var sum = (from c in s where char.IsDigit(c) select char.GetNumericValue(c)).Sum();


        System.Console.WriteLine(sum);
        System.Console.WriteLine(CountChars(s, delegate (char c)//анонимный делегат
{
    return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');
}));
        System.Console.WriteLine(CountChars(s, IsRus));
        System.Console.WriteLine(CountChars(s, IsDigit));
        //=> Лямбда выражения
        System.Console.WriteLine(CountChars(s, (c) =>
{
    return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z');//лямбда-выражение многострочное
}));
        System.Console.WriteLine(CountChars(s, (c) => c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z'
));//лямбда-выражение однострочное
    }
}
