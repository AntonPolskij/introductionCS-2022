// С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры.

int Count(int[] a)
{
    int count = 0;
    foreach (int el in a)
    {
        if (el > 0) count++;
    }
    return count;
}

void InitArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int N = Convert.ToInt32(Console.ReadLine());
int[] a = new int[N];
InitArray(a);

System.Console.WriteLine($"Количество чисел больше 0: {Count(a)}");

