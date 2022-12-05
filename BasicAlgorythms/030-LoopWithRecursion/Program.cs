// Вывести числа от 1 до N. Без использования цикла.

void Loop(int N, int i)
{
    if (i <= N)
    {
        System.Console.WriteLine(i);
        Loop(N, i + 1);
    }
}


int N = 5;
int i = 1;
Loop(N, i);



