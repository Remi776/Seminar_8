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
            Console.Write($"{coll[i, j],-5}");
        }
        Console.WriteLine();
    }
}

void ChangeFirstLast(int[,] coll, int m, int n)
{
    int j = 0;
    while (j < coll.GetLength(1))
    {
        int temp = coll[0, j];
        coll[0, j] = coll[m - 1, j];
        coll[m - 1, j] = temp;
        j++;
    }
}

Console.Write("Rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
ChangeFirstLast(matrix, m, n);
Console.WriteLine();
PrintArray(matrix);