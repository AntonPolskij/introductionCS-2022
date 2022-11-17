// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
Console.Write("Введите число N: ");
double N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Convert.ToInt32(N / 10 % 1 * 10));
