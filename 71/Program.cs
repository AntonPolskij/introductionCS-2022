// Показать натуральные числа от N до 1, N задано.

void ShowNums(int N)
{
    if (N >= 1)
    {
        System.Console.Write($"{N,4}");
        ShowNums(--N);
    }
}


int N = 10;
ShowNums(N);
