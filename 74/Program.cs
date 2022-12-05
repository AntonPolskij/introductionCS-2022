// Найти сумму цифр числа.

int SumDigital(int n)
{
    if (n == 0) return 0;
    return SumDigital(n / 10) + n % 10;
}

System.Console.WriteLine(SumDigital(123));