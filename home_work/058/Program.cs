void FillMatrix(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],-5}");
        }
        Console.WriteLine();
    }
}

void MatrixMultiplication(int[,] matrix_a, int[,] matrix_b)
{
    if (matrix_a.GetLength(1) != matrix_b.GetLength(0)) 
    {
        Console.WriteLine("Multiplication is impossible");
    }

    int[,] matrix_c = new int[matrix_a.GetLength(0), matrix_b.GetLength(1)];
    for (int i = 0; i < matrix_a.GetLength(0); i++)
    {
        for (int j = 0; j < matrix_b.GetLength(1); j++)
        {
            matrix_c[i, j] = 0;
            for (int k = 0; k < matrix_a.GetLength(1); k++)
            {
                matrix_c[i, j] += matrix_a[i, k] * matrix_b[k, j];
            }
        }
    }
    Console.Write("\nA x B = ");
    PrintMatrix(matrix_c);
}
Console.WriteLine("Matrix A parameters");
Console.Write("Rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix_1 = new int[m, n];
FillMatrix(matrix_1);
PrintMatrix(matrix_1);

Console.WriteLine("\nMatrix B parameters");
Console.Write("Rows number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,] matrix_2 = new int[x, z];
FillMatrix(matrix_2);
PrintMatrix(matrix_2);

MatrixMultiplication(matrix_1, matrix_2);