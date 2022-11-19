// Найти сумму чисел от 1 до А

int SumBeforeA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}



System.Console.Write("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumBeforeA(A));
