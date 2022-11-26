// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

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


int[] array = RandomIntArray(123);
int s = 0;
foreach (int el in array)
{
    if (el >= 10 && el <= 99)
    {
        s++;
    }
}
System.Console.WriteLine($"Количество элементов в промежутке [10,99] - {s}");