//Вывести на экран кубы чисел от 1 до N

System.Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

int count = 1;
while (count <= N)
{
    System.Console.WriteLine($"{count} - {Math.Pow(count, 3)}");
    count++;
}