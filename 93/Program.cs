/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

int[,] Random2DArray(int n, int m, int min = 0, int max = 10)
{
    int[,] matrix = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(min, max + 1);
    }
    return matrix;
}

int[,] MatrixMulti(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixMulti = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

    for (int i = 0; i < matrixMulti.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMulti.GetLength(1); j++)
        {
            matrixMulti[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return matrixMulti;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            System.Console.Write(matrix[i, j] + "\t");
        System.Console.WriteLine();
    }
}

int n = 2;
int m = 5;
int[,] matrix1 = Random2DArray(n, m);
int[,] matrix2 = Random2DArray(n, m);
Print2DArray(matrix1);
System.Console.WriteLine("***************************************");
Print2DArray(matrix2);
System.Console.WriteLine("***************************************");
Print2DArray(MatrixMulti(matrix1, matrix2));
