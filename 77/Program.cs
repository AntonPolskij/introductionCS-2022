//Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности 0 и 1.

int fibonnaci(int N)
{
    if (N == 0) return 0;
    if (N == 1) return 1;
    return (fibonnaci(N - 1) + fibonnaci(N - 2));
}

int N = 10;
for (int i = 0; i < N; i++)
{
    System.Console.Write($"{fibonnaci(i),4}");
}