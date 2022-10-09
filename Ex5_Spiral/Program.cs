// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

int [,]  InputMatrix(int [,] matrix)
{
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = 4;
 
    for (int i = 0; i < matrix.Length; i++) 
    {
        matrix[row, col] = i + 1;
        if (--visits == 0) 
        {
            visits = 4 * (dirChanges %2) + 4 * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
 
        col += dx;
        row += dy;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];
InputMatrix(matrix);
PrintMatrix(matrix);