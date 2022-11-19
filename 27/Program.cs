// Возведите число А в натуральную степень B используя цикл

int MyPow(int a, int b)
{
    int pow = a;
    for (int i = 1; i < b; i++)
    {
        pow *= a;
    }
    return pow;
}

int A = 2;
int B = 14;

System.Console.WriteLine(MyPow(A, B));