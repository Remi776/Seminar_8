// Для n * m массивов
int sizeX = 6;
int sizeY = 3;
int[,] matrix = new int[sizeX, sizeY];
int indexX = 0;
int indexY = 0;

int changeX = 0;
int changeY = 1;

int steps = sizeY;
int direction = 0;

for (int i = 0; i < matrix.Length; i++)
{
    matrix[indexX, indexY] = i + 1;
    //Console.Write(matrix[indexX, indexY] + "\t");
    steps--;
    if (steps == 0)
    {
        steps = sizeY * (direction % 2) + sizeX * ((direction + 1) % 2) - 1 - direction / 2;
        int temp = changeX;
        changeX = changeY;
        changeY = -temp;
        direction++;
    }
    indexX += changeX;
    indexY += changeY;
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}