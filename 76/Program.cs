// Написать программу возведения числа А в целую положительную степень B.

int Pow(int a, int b)
{
    if (b == 0) return 1;
    return Pow(a, (Math.Abs(b) - 1)) * a;
}

System.Console.WriteLine(Pow(2, -2));