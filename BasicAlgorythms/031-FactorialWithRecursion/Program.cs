int factorial(int N)
{
    if (N == 0) return 1;
    return factorial(N - 1) * N;
}

int N = 5;
System.Console.WriteLine(factorial(N));
