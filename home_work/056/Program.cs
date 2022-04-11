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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],-5}");
    }
    Console.WriteLine();
}

void FindMinSumRow(int[,] matr)
{
    // Создаю одномерный массив. В него по порядку записываю сумму строк матрицы.
    int[] arr = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[i] += matr[i, j];
        }
    }
    Console.WriteLine("\nSums of rows in the matrix");
    // Печатаю массив с суммами строк матрицы.
    PrintArray(arr);
    // Ищу минимальную сумму.
    int min_SumIndex = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min_SumIndex) min_SumIndex = i;
    }
    Console.WriteLine("\nIndex of the Row with the min sum = " + min_SumIndex);
}

Console.Write("Rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);
FindMinSumRow(matrix);