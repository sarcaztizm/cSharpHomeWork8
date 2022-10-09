// Задать дву матрицы. Написать программу,
// которая будет находить произведение двух матриц.

Console.Clear();

int [,] InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
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


Console.WriteLine("Введите размерность первой матрицы:");
Console.Write("Количество строк ");
int rowsOfFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int colsOfFirstMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размерность второй матрицы:");
Console.Write("Количество строк ");
int rowsOfSecondMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int colsOfSecondMatrix = Convert.ToInt32(Console.ReadLine());

int [,] firstMatrix = new int [rowsOfFirstMatrix, colsOfFirstMatrix];
InputMatrix(firstMatrix);
Console.WriteLine("Первая матрица:");
PrintMatrix(firstMatrix);

int [,] secondMatrix = new int [rowsOfSecondMatrix, colsOfSecondMatrix];
InputMatrix (secondMatrix);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondMatrix);

int [,] resultMatrix = new int [rowsOfFirstMatrix, colsOfSecondMatrix];
Console.WriteLine("Условие перемножения матриц:");
Console.WriteLine("Количество столбцов первой матрицы равно количеству строк второй матрицы!");

if (colsOfFirstMatrix == rowsOfSecondMatrix)
{
    // Данный варинт перемножает только матрицы одинаковой размерности!
    
    Console.WriteLine ("Результирующая матрица:");
    {
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(0); j++)
                {
                    resultMatrix [i,j] = 0;
                    for (int k = 0; k < secondMatrix.GetLength(1); k++)
                    {
                        resultMatrix [i,j] += firstMatrix[i,k]*secondMatrix[k,j];
                    }
                    Console.Write ($"{resultMatrix[i,j]} ");
                }
                Console.WriteLine();
            }
    }    
}
else    Console.Write("Неправильная размерность матриц");
