// Показать натуральные числа от 1 до N, N задано.

void ShowNums(int N, int i)
{
    if (i <= N)
    {
        System.Console.Write($"{i,4}");
        ShowNums(N, ++i);
    }
}


int N = 10;
ShowNums(N, 1);