/* Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
56*/


// double[] x, y;
// x = new double[10];
// y = new double[10];
// x[0] = 0;
// y[0] = 0;

//Структура


class Program
{

    struct Point
    {
        public double x, y;
    }


    static double Distance(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
    }
    static void Main()
    {
        Point a, b;
        a.x = 0;
        a.x = 0;
        b.x = 2;
        b.y = 3;
        System.Console.WriteLine(Distance(a, b));

        Point[] figure = new Point[3];
        double k = 2;
        for (int i = 0; i < figure.Length; i++)
        {
            figure[i].x = figure[i].x * k;
            figure[i].y *= k;
        }
    }

}




