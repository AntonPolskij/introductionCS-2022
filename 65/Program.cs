//  Написать подпрограмму, поиска элемента в двумерном массиве, подпрограмма возвращает позицию числа. Если элемент отсутствует, подпрограмма возвращает -1.

bool LinearSearch2DArray(int[,] a, int find, out int i, out int j)
{
    for (i = 0; i < a.GetLength(0); i++)
    {
        for (j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] == find)
            {
                return true;
            }
        }
    }
    j = -1;//?
    return false;
}

int[,] Random2DArray(int n = 5, int m = 5, int min = 0, int max = 10)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.Next(min, max + 1);
        }
    }
    return a;
}


int[,] a = Random2DArray();
int find = 20;
// a[2, 2] = 20;
int i, j;

if (LinearSearch2DArray(a, find, out i, out j)) System.Console.WriteLine($"Element {find} find in position {i},{j}");
else System.Console.WriteLine("Element not found");
