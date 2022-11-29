// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int[,] Random2DArray(int n = 5, int m = 5, int min = 0, int max = 10)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.Next(min, max + 1);
        }
    }
    return a;
}

void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i, j],4}");
        }
        System.Console.WriteLine();
    }
}

int[] Solution(int[,] a)
{
    int[] m = new int[a.GetLength(1)];
    for (int j = 0; j < a.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            sum += a[i, j];
        }
        m[j] = sum / a.GetLength(0);
    }
    return m;
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.WriteLine($"Среднее арифметическое столбца {i} - {a[i]}");
    }
}

int[,] a = Random2DArray(2, 5);
Print2DArray(a);
System.Console.WriteLine();
Print(Solution(a));