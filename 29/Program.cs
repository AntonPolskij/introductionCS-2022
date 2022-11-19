// Подсчитать сумму цифр в числе. Сделать подпрограмму.

int SumOfNumbers(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}


System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumOfNumbers(N));