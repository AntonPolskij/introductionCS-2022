// Бинарный поиск в массиве

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

int BinSearch(int[] a, int find)
{
    int i;
    int left = 0;
    int right = a.Length - 1;
    i = left + (right - left) / 2;
    if (find == a[right]) return right;
    while (a[i] != find && left < right)
    {
        if (find > a[i])
        {
            left = i;
        }
        else
        {
            right = i;
        }
        i = left + (right - left) / 2;
    }
    if (a[i] != find)
        return -1;
    else
        return i;
}


int find = 20;
int[] a = RandomIntArray(10, 0, 10);
a[6] = find;
Array.Sort(a);
Print(a);
System.Console.WriteLine(BinSearch(a, find)
);