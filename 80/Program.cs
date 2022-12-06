// 80. Вывести на экран кодировку символов по ASCII(с 32 до 122).

for (char c = (char)32; c < (char)123; c++)
{
    System.Console.Write($"{c,4}");
}
