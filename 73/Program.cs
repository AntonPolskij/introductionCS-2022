// Найти сумму элементов от M до N, N и M заданы.

int Sum(int M, int N)
{
    if (M == N) return M;
    return Sum(M + 1, N) + M;
}

System.Console.WriteLine(Sum(2, 4));
System.Console.WriteLine((2 + 4) * 3 / 2);