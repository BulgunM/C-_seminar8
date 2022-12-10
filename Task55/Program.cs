// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. 
// В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max - 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] ReplaceRowsToColumns(int[,] matrix)
{
    int[,] rowsToColumns = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowsToColumns[i, j] = matrix[j, i];
        }
    }
    return rowsToColumns;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

if (array2D.GetLength(0) == array2D.GetLength(1))
{
    int[,] newArray2D = ReplaceRowsToColumns(array2D);
    PrintMatrix(newArray2D);
}
else Console.WriteLine("Замена невозможна, так как массив не квадратный");

// подумать над этим методом
// void ReplaceRowsToColumns(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i; j < matrix.GetLength(1); j++)
//         {
//             int temporaryVariable = matrix[j, i];
//             matrix[j, i] = matrix[i, j];
//             matrix[i, j] = temporaryVariable;
//         }
//     }
// }