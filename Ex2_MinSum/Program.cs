// Задать прямоугольный двумерный массив.
// Написать программу, которая будет находить строку с наименьшей суммой элементов.

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

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine ($"{i+1}: {array[i]} ");
    }
}

int [] SumRowsOfMatrix (int [,] matrix, int rows)
{
    int [] sumResult = new int [rows];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumResult [i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumResult [i] += matrix[i,j];
        }
    }
    return sumResult;
}

Console.WriteLine("Введите размерность массива:");
Console.Write("Количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

if (rows != cols)
{
    int [,] MyMatrix = new int [rows, cols];
    InputMatrix (MyMatrix);
    Console.WriteLine("Исходный массив:");
    PrintMatrix(MyMatrix);

    int [] rowsSum = SumRowsOfMatrix(MyMatrix,rows);
    Console.WriteLine("Сумма элементов в строках:");
    PrintArray(rowsSum);

    int minSum = rowsSum[0];
    int indexMinSum = 0;
    for (int i = 0; i < rowsSum.Length; i++)
    {
        if (rowsSum[i] < minSum)
        {
            minSum = rowsSum[i];
            indexMinSum = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой: {indexMinSum+1}");
}
else    Console.WriteLine("Введены неправильные размеры массива!");




