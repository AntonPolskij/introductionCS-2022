// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    System.Console.WriteLine(Convert.ToString(num)[2]);
}
else
{
    System.Console.WriteLine("NO");
}