// Удалить вторую цифру целого числа введенного с клавиатуры.
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99) System.Console.WriteLine(num / 100 * 10 + num % 10);
if (num < 99 && num > 10) System.Console.WriteLine(num / 10);
if (num < 10) System.Console.WriteLine(num);