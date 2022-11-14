//По заданному с клавиатуры номеру дня недели вывести его название
System.Console.Write("Введите номер дня недели: ");
int input = Convert.ToInt32(Console.ReadLine());
string mon = "Понедельник", tue = "Вторник", wed = "Среда", thu = "Четверг", fri = "Пятница", sat = "Суббота", sun = "Воскресенье";
if (input > 7 || input < 1)
{
    System.Console.WriteLine("Вы ввели некорректное значение");
}
if (input == 1) System.Console.WriteLine(mon);
if (input == 2) System.Console.WriteLine(tue);
if (input == 3) System.Console.WriteLine(wed);
if (input == 4) System.Console.WriteLine(thu);
if (input == 5) System.Console.WriteLine(fri);
if (input == 6) System.Console.WriteLine(sat);
if (input == 7) System.Console.WriteLine(sun);