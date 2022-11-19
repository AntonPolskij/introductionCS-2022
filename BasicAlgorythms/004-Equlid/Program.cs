// Алгоритм Евклида

int a = 10, b = 15;

int GCD(int a, int b)
{
    while (a != b)
    {
        if (a > b)
            a = a - b;
        else
            b = b - a;
    }
    return a;
}

int QuickGCD(int a, int b)
{
    while (a != 0 && b != 0)
    {
        if (a > b)
            a = a % b;
        else
            b = b % a;
    }
    return a + b;
}

System.Console.WriteLine(GCD(25, 2000));

System.Console.WriteLine(QuickGCD(25, 2000));
