// Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

int Count(string s, char find)
{
    s = s.ToLower();
    int count = 0;
    foreach (char c in s)
    {
        if (c == find) count++;
    }
    return count;
}
char find = 'a';
string s = "asdasrqwAEWasd";
System.Console.WriteLine($"Символ: {find} встречается в строке '{s}'  {Count(s, find)} раз");
