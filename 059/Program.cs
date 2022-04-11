void FillArray(int[,] coll)
{
    Random rnd = new Random();
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = rnd.Next(1, 11);
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

void DeleteRowColumnMinElement(int[,] coll)
{
    int min_i = 0;
    int min_j = 0;
    int minElement = coll[0, 0];
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            if (coll[i, j] < minElement) 
            {
                minElement = coll[i, j];
                min_i = i;
                min_j = j;
            }
        }
    }
    Console.WriteLine($"Min element  = {minElement}, ind {min_i} {min_j}");

    int[,] arrNew = new int[coll.GetLength(0) - 1, coll.GetLength(1) - 1];
    int second_i = 0;
    int second_j = 0;
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        if (i != min_i)
        {
            second_j = 0;
            for (int j = 0; j < coll.GetLength(1); j++)
            {
                if (j != min_j)
                {
                    arrNew[second_i, second_j] = coll[i,j];
                    second_j++;
                }
            }
            second_i++;
        }
    }
    PrintArray(arrNew); 
}


Console.Write("Rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
DeleteRowColumnMinElement(matrix);