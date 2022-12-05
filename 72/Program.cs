// Показать натуральные числа от M до N, N и M заданы.

void ShowNums(int M, int N)
{
    if (M <= N)
    {
        System.Console.Write($"{M,4}");
        ShowNums(++M, N);
    }
}


int N = 10;
int M = 5;
ShowNums(M, N);
