// Сформировать трехмерный массив из неповторяющихся двухзначных чисел.
// Построчно вывести массив, добавляя индекс каждого элемента.

Console.Clear();

int[,,] InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                while (matrix [i,j,k] < 10)
                {
                    matrix[i, j, k] = new Random().Next();
                    matrix [i,j,k] %= 100;
                }
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}   {(i, j, k)}  ");
            }
            Console.WriteLine();

        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите размерность массива:");
int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());
int Z = Convert.ToInt32(Console.ReadLine());

int [, ,] complexArray = new int [X,Y,Z];
InputMatrix (complexArray);

Console.WriteLine ($"Массив разметом {X} x {Y} x {Z}");
PrintMatrix(complexArray);
