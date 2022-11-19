// Написать программу вычисления произведения чисел от 1 до N


int Factorial(int a)
{
    int x = 1;
    for (int i = 1; i <= a; i++)
    {
        x = x * i;
    }
    return x;
}



System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Factorial(N));