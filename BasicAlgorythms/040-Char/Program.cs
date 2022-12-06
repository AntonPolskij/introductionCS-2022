char c = 'a';
c = '\x64';
c = '\u0064';
char b = '1';
System.Console.WriteLine((int)b);
System.Console.WriteLine(c + b);
System.Console.WriteLine(c.ToString() + b.ToString());
if (b >= '0' && b <= '9') System.Console.WriteLine("It's digit");
if (b >= 'A' && b <= 'Z') System.Console.WriteLine("It's big Latin");
if (b >= 'a' && b <= 'z') System.Console.WriteLine("It's small Latin");
if (b >= 'a' && b <= 'z' || b >= 'A' && b <= 'Z') System.Console.WriteLine("It's Latin");

if (Char.IsDigit(b)) System.Console.WriteLine("It's digit");

