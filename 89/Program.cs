// Подсчитать сумму цифр, встречающихся в строке.

int SumDigits(string s)
{
    int sum = 0;
    foreach (char c in s)
    {
        if (char.IsDigit(c)) sum += (c - '0');
    }
    return sum;
}

string str = "a25d1sgere4";
System.Console.WriteLine(SumDigits(str));