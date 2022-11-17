// Программа проверяет пятизначное число на палиндромом.

int num = 10101;
int palindr = 0;
int temp = num;
while (temp > 0)
{
    palindr = palindr * 10 + temp % 10;
    temp = temp / 10;
}

if (num == palindr) System.Console.WriteLine($"Число {num} - палиндром"); else System.Console.WriteLine("NO");