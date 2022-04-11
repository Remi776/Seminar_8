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

void PrintDictionary(int[] arr)
{
    Console.WriteLine();
    Console.WriteLine("Dictionary");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void CountElement(int[,] coll, int[] arr)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            arr[coll[i, j]]++;
        }
    }
}
Console.Write("Rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
int[] dictionary = new int[10];
FillArray(matrix);
PrintArray(matrix);
PrintDictionary(dictionary);
CountElement(matrix, dictionary);
PrintDictionary(dictionary);