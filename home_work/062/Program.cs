int number = 4;
int[,] arr = new int[number, number];
int count = 1;

for (int delta = 0; delta < number - 1; delta++)
{
    for (int i = delta; i < number - delta; i++)
    {
        arr[0 + delta, i] = count;
        count++;
    }
    count--;
    for (int i = delta; i < number - delta; i++)
    {
        arr[i, number - 1 - delta] = count;
        count++;
    }
    count--;
    for (int i = number - 1 - delta; i >= delta; i--)
    {
        arr[number - 1 - delta, i] = count;
        count++;
    }
    count--;
    for (int i = number - 1 - delta; i >= 1 + delta; i--)
    {
        arr[i, delta] = count;
        count++;
    }   
}

PrintMatrix();

void PrintMatrix()
{
    for (int i = 0; i < number; i++)
    {
        for (int j = 0; j < number; j++)
        {
            Console.Write($"{arr[i, j],-5}");
        }
        Console.WriteLine();
    }
}
