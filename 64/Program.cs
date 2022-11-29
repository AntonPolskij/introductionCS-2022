// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

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

void Solution(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i += 2)
    {
        for (int j = 0; j < a.GetLength(1); j += 2)
        {
            a[i, j] = Convert.ToInt32(Math.Pow(a[i, j], 2));
        }
    }
}

int[,] a = Random2DArray(min: 2, max: 2);
Print2DArray(a);
Solution(a);
System.Console.WriteLine();
Print2DArray(a);