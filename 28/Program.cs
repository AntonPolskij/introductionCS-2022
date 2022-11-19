// Определить количество цифр в числе. Сделать подпрограмму.

//Подпрограмма
int CountDigits(int Number)
{
    Number = Math.Abs(Number);// По модулю. Отрицательное переводит в положительное.
    int count = 0;
    if (Number == 0) count = 1;
    while (Number > 0)
    {
        Number = Number / 10;
        count++;
    }
    return count;
}



//Основная программа
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(CountDigits(N));
