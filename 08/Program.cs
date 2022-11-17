// Вывести на экран числа от -N до N
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = -N; i <= N; i++)
{
    System.Console.Write($"{i} ");
}