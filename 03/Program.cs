//С клавиатуры вводятся два числа a и b. Найти максимальное из них.

System.Console.Write("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a < b) max = b;
System.Console.WriteLine($"Max = {max}");