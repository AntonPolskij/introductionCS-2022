// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
System.Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)
{
    System.Console.WriteLine("Число a кратно числу b");
}
else
{
    System.Console.WriteLine($"Остаток от деления a на b = {a % b}");
}
