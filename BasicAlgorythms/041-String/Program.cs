string s = "asdf";
//immutable string(не изменяемые строки)
for (int i = 0; i < s.Length; i++)
{
    System.Console.Write(s[i] + "\t");
}
//s[0]='S'; - в c# так не работает.
char[] cc = s.ToCharArray();
cc[0] = 'S';
s = new String(cc);
System.Console.WriteLine(s);

System.Text.StringBuilder sb = new System.Text.StringBuilder("asda");// Эффективней чем через ToCharArray, если операций со строкой большое кол-во.

sb[0] = 's';

s = sb.ToString();
System.Console.WriteLine(s);

// for (int i = 0; i < 100000; i++)
// {
//     s = s + "1";// Создается новая строка!!
// }
for (int i = 0; i < 100000; i++)
{
    sb.Append("1");
}

string s1 = "Hello";
string s2 = "Hello";
System.Console.WriteLine(s1 == s2);// Хоть строка ссылочный тип данных, но для них в c# сделано исключение. У них сравниваются не адреса, а значения!
System.Console.WriteLine(s1.CompareTo(s2));
System.Console.WriteLine(String.Compare(s1, s2));

// s1.Length - длина
s2 = s1.Substring(2, 3);
System.Console.WriteLine(s1.IndexOf("as"));
s2 = s1.Replace('a', 'b');
s3 = s1.Replace("ab", "ba");


/*string s = Console.Readline();
string[] ss = s.Split(' ');
int[] n = new int[ss.Length];
for (int i = 0; i < ss.Length; i++)
{
    n[i] = Convert.ToInt32(ss[i]);
}
int a = n[0];
int b = n[1];
int c = n[2];*/

string[] ss = Console.Readline().Split(' ');
int[] n = new int[ss.Length];
Array.ConvertAll<string, int>(ss, Convert.ToInt32);//обобщенные типы и параметризированные методы.
int a = n[0];
int b = n[1];
int c = n[2];
