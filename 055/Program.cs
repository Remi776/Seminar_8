void FillArray(int[,] coll)
{
    Random rnd = new Random();
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = rnd.Next(0, 11);
        }
    }
}

void PrintArray(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            Console.Write($"{coll[i, j], -5}");
        }
        Console.WriteLine();
    }
}

void ReplaceRowsColumns(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = i + 1; j < coll.GetLength(1); j++)
        {
            int temp = coll[i, j];
            coll[i, j] = coll[j, i];
            coll[j, i] = temp;
        }
    }
}

Console.Write("Rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ReplaceRowsColumns(matrix);
PrintArray(matrix);