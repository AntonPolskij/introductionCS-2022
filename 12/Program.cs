// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
System.Console.WriteLine("Введите число от 1 до 99");
int num = Convert.ToInt32(Console.ReadLine());
int a, b;
a = num / 10;
b = num % 10;
if (a > b)
{
    System.Console.WriteLine(a);
}
else
{
    System.Console.WriteLine(b);
}
