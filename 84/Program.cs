// Определить являются ли введенные с клавиатуры символы правильной записью целого числа. Вычислить сумму цифр введенного числа.

bool Test(string s)
{
    foreach (char c in s)
    {
        if (!char.IsDigit(c)) return false;
    }
    return true;
}

string s = Console.ReadLine();
int sum = 0;
if (Test(s))
{
    for (int i = 0; i < s.Length; i++)
    {
        sum += (s[i] - '0');
    }
    System.Console.WriteLine("Сумма цифр: " + sum);
}
else System.Console.WriteLine("Неправильная запись целого числа");

