// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

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

void PrintCountOddEven(int[] a)
{
    int odd = 0, even = 0;
    foreach (int el in a)
    {
        if (el % 2 == 0) even++;
        else odd++;
    }
    System.Console.WriteLine($"Четных - {even} Нечетных - {odd}");
}


int[] array = RandomIntArray(min: 100, max: 999);
Print(array);
System.Console.WriteLine();
PrintCountOddEven(array);

