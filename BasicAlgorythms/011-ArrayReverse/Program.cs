// Переворот массива

int[] RandomIntArray(int size = 10, int min = 0, int max = 100)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        a[i] = random.Next(min, max);
    }
    return a;
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a[i],5}");
    }
    System.Console.WriteLine();
}

void Swap(ref int a, ref int b)
{
    int t = a;
    a = b;
    b = t;
}

void Reverse(int[] a)
{
    for (int i = 0; i < a.Length / 2; i++)
    {
        Swap(ref a[i], ref a[(a.Length - 1) - i]);
    }
}

int[] a = RandomIntArray(5);
Print(a);
Reverse(a);
Print(a);