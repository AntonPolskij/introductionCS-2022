
void Swap(ref int x, ref int y)// reference - ссылка
{
    int t = x;
    x = y;
    y = t;
}

void Calculator(int a, int b, out int sum, out int multi)
{
    sum = a + b;
    multi = a * b;
}

int a = 3, b = 5;
System.Console.WriteLine($"a = {a} b = {b}");
Swap(ref a, ref b);
System.Console.WriteLine($"a = {a} b = {b}");

int sum, multi;
Calculator(a, b, out sum, out multi);
System.Console.WriteLine($"{sum}  {multi}");


bool flag;
do
{
    flag = int.TryParse("123123", out a);
    if (flag == false) System.Console.WriteLine("Введите целое число");
}
while (flag == false);