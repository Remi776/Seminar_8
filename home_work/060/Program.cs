Console.Write("Enter the pages: ");
int pages = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,,] notebook = new int[pages, rows, columns];

FillArray(notebook);
PrintArray(notebook);
void FillArray(int[,,] array)
{
    Random rnd = new Random();
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = count;
                count++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("Page № " + (i + 1));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"Element {array[i, j, k]}, index {j}, {k}");
            }
        }
    }
}