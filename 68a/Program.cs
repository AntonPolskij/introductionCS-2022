// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int MinRow(int[,] a)
{
    int[] m = new int[a.GetLength(0)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            m[i] += a[i, j];
        }
    }
    int minIndex = 0;
    int minRow = m[0];
    for (int k = 1; k < m.Length; k++)
    {
        if (m[k] < minRow)
        {
            minRow = m[k];
            minIndex = k;
        };
    }
    return minIndex;
}

int[,] a = Random2DArray(5, 3);
Print2DArray(a);
System.Console.WriteLine($"Cтрока с наименьшей суммой элементов: {MinRow(a) + 1}");
