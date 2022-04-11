int[,,] array =
{
    {
        {23, 12, 11},
        {15, 45, 67}
    },
    {
        {48, 49, 71},
        {85, 35, 57}
    },
    {
        {99, 98, 97},
        {96, 95, 94}
    },
};
PrintArray();
void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("Page № " + i);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.WriteLine($"Elemet {array[i, j, k]}, index {j},{k}");
            }
        }
    }
}