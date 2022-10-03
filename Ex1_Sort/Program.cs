// Задать двумерный массив. Написать программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
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

int [,] SortMatrix (int [,] matrix) // сортировка методов включения
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++) // для всех элементов кроме начального
        {
            int value = matrix[i,j]; // запоминаем значение элемента матрицы
            int index = j; // запоминаем индекс элемента матрицы
            while (index > 0 && matrix[i,index - 1] > value) // смещаем другие элементы к концу массива 
            {
                matrix [i, index] = matrix[i, index-1];
                index--;
            }
            matrix[i,index] = value;
        }
    }
    return matrix;
}



Console.WriteLine("Введите размерность массива:");
Console.Write("Количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int [,] MyMatrix = new int[rows, col];
InputMatrix(MyMatrix);
Console.WriteLine("Исходный массив:");
PrintMatrix(MyMatrix);
Console.WriteLine("Массив после сортировки:");
SortMatrix(MyMatrix);
PrintMatrix(MyMatrix);


