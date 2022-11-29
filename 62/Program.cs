// В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]).

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
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] % 2 == 0) a[i, j] = -a[i, j];
        }
    }
}

int n = 3, k = 5;
int[,] a = Random2DArray(n, k);
Print2DArray(a);
Solution(a);
System.Console.WriteLine();
Print2DArray(a);