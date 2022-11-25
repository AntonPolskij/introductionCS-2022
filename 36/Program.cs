// Определить, присутствует ли в заданном массиве, некоторое число

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
}

int LinearSearch(int[] a, int find)
{
    int i = 0;
    while (i < a.Length && a[i] != find) i++;
    if (i == a.Length)
        return -1;
    else
        return i;
}


int[] n = RandomIntArray(max: 10);
Print(n);
System.Console.WriteLine();
int find = 5;
int i = LinearSearch(n, find);
if (i == -1) System.Console.WriteLine($"Element {find} not found");
else System.Console.WriteLine($"Element {find} found at {i}");