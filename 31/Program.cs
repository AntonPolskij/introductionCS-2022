﻿//Сгенерировать 10 случайных чисел. Показать кубы тех чисел, которые заканчиваются на четную цифру.

bool Test(int a)
{
    // if (a % 2 == 0)
    //     return true;
    // else return false;
    return a % 2 == 0;
}


Random random = new Random();
for (int i = 0; i < 10; i++)
{
    int a = random.Next(1, 100);
    // int b = Convert.ToInt32(Math.Pow(a, 3));
    int b = (int)Math.Pow(a, 3);//(int) явное приведение типов

    if (Test(b))
        System.Console.WriteLine($"{a}, {b}");
}
