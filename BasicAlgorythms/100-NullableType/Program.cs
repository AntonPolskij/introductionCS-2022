
int? a = 10;
// a = null;
Nullable<int> b;
System.Console.WriteLine(a.HasValue + " " + a.Value);

int? Test()
{
    return null;
}