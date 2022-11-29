// Показать двумерный массив размером m×n заполненный вещественными случайными числами.
double[,] Random2DArray(int n = 5, int m = 5, int min = 0, int max = 10)
{
    double[,] a = new double[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = Math.Round(1 + random.NextDouble(), 1);
        }
    }
    return a;
}

void Print2DArray(double[,] a)
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

double[,] a = Random2DArray();
Print2DArray(a);
