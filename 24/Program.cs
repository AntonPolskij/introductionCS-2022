// Вывести на экран таблицу квадратов чисел от 1 до N

void SquareTable(int a)
{
    int count = 1;
    while (count <= a)
    {
        System.Console.WriteLine($"{count} - {count * count}");
        count++;
    }
}

System.Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
SquareTable(N);
