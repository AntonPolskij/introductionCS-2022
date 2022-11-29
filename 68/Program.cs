// Написать программу, которая обменивает элементы первой строки и последней строки.
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

void ChangeFirstAndLastRows(int[,] a)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        int temp = a[0, j];
        a[0, j] = a[a.GetLength(0) - 1, j];
        a[a.GetLength(0) - 1, j] = temp;
    }
}

int[,] a = Random2DArray();
Print2DArray(a);
System.Console.WriteLine();
ChangeFirstAndLastRows(a);
Print2DArray(a);