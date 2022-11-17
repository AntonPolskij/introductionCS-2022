// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
System.Console.Write("Введите координату X: ");
int X = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
bool condition1 = X > 0 && Y > 0;
bool condition2 = X < 0 && Y > 0;
bool condition3 = X < 0 && Y < 0;
bool condition4 = X > 0 && Y < 0;

if (X == 0 || Y == 0) System.Console.WriteLine("X и Y - не должны быть равны 0");
if (condition1) System.Console.WriteLine("Точка находиться в 1ой плоскости");
if (condition2) System.Console.WriteLine("Точка находиться во 2ой плоскости");
if (condition3) System.Console.WriteLine("Точка находиться в 3ей плоскости");
if (condition4) System.Console.WriteLine("Точка находиться в 4ой плоскости");